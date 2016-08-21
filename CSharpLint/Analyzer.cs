using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Diagnostics;
using Newtonsoft.Json;
using System;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CSharpLint
{
    public static class Analyzer
    {
        private static Violation[] saViolations = ReadSAViolations();

        public static ImmutableArray<Violation> Analyze(string filePath, string csharpSource)
        {
            ImmutableArray<Diagnostic> diagnostics = GetDiagnostics(filePath, csharpSource);

            return diagnostics
                .Select(diagnostic => CreateViolation(diagnostic))
                .Where(violation => violation.Severity > Severity.None)
                .ToImmutableArray();
        }

        [SuppressMessage("Microsoft.Reliability", "CA2001:AvoidCallingProblematicMethods", MessageId = "System.Reflection.Assembly.LoadFile", Justification = "No other option.")]
        private static ImmutableArray<Diagnostic> GetDiagnostics(string filePath, string csharpSource)
        {
            SyntaxTree tree = CSharpSyntaxTree.ParseText(csharpSource, path: filePath);

            CSharpCompilation compilation = CSharpCompilation.Create("target")
                .AddReferences(MetadataReference.CreateFromFile(typeof(object).Assembly.Location))
                .AddSyntaxTrees(tree);

            ImmutableArray<Diagnostic> parseDiagnostics = compilation.GetParseDiagnostics();

            Assembly stylecopAnalyzersAssembly = Assembly.LoadFile(GetPathToFile(@"StyleCop.Analyzers.dll"));
            ImmutableArray<DiagnosticAnalyzer> analyzers = stylecopAnalyzersAssembly.GetTypes()
                .Where(t => t.IsAbstract == false && typeof(DiagnosticAnalyzer).IsAssignableFrom(t))
                .Select(t => Activator.CreateInstance(t) as DiagnosticAnalyzer)
                .ToImmutableArray();

            CompilationWithAnalyzersOptions options = new CompilationWithAnalyzersOptions(
                new AnalyzerOptions(default(ImmutableArray<AdditionalText>)), OnAnalyzerException, false, false);

            CompilationWithAnalyzers compilationWithAnalyzers = new CompilationWithAnalyzers(compilation, analyzers, options);

            Task<ImmutableArray<Diagnostic>> analyzerDiagnosticsTask = compilationWithAnalyzers.GetAnalyzerDiagnosticsAsync();
            analyzerDiagnosticsTask.Wait();
            ImmutableArray<Diagnostic> analyzerDiagnostics = analyzerDiagnosticsTask.Result;

            return parseDiagnostics
                .Concat(analyzerDiagnostics)
                .ToImmutableArray();
        }

        private static Violation CreateViolation(Diagnostic diagnostic)
        {
            FileLinePositionSpan lineSpan = diagnostic.Location.GetLineSpan();

            int startLine = lineSpan.StartLinePosition.Line;
            int endLine = lineSpan.EndLinePosition.Line;
            string id = diagnostic.Id;
            string message = diagnostic.GetMessage();

            Severity severity = Severity.None;

            if (id.StartsWith("CS"))
            {
                severity = Severity.Error;
            }
            else if (id.StartsWith("SA"))
            {
                severity = saViolations.First(v => v.Id == id).Severity;
            }

            return new Violation(startLine, endLine, id, message, severity);
        }

        private static Violation[] ReadSAViolations()
        {
            string saViolationsJson = File.ReadAllText(GetPathToFile(@"Resources/SAViolations.json"));
            return JsonConvert.DeserializeObject<Violation[]>(saViolationsJson);
        }

        private static string GetPathToFile(string file)
        {
            string exeFilePath = Assembly.GetExecutingAssembly().Location;
            string exeFolder = Path.GetDirectoryName(exeFilePath);
            return Path.Combine(exeFolder, file);
        }

        private static void OnAnalyzerException(Exception exception, DiagnosticAnalyzer analyzer, Diagnostic diagnostic)
        {
        }
    }
}
