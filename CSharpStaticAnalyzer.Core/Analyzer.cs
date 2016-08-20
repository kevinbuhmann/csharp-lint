using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Diagnostics;
using System;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CSharpStaticAnalyzer.Core
{
    public static class Analyzer
    {
        public static ImmutableArray<Violation> Analyze(string filePath, string csharpSource)
        {
            ImmutableArray<Diagnostic> diagnostics = GetDiagnostics(filePath, csharpSource);

            ImmutableArray<DiagnoticHandler> handlers = typeof(Analyzer).Assembly.GetTypes()
                .Where(t => t.IsAbstract == false && typeof(DiagnoticHandler).IsAssignableFrom(t))
                .Select(t => Activator.CreateInstance(t) as DiagnoticHandler)
                .ToImmutableArray();

            return diagnostics
                .Select(diagnostic => handlers.FirstOrDefault(handler => handler.Id == diagnostic.Descriptor.Id)?.CreateViolation(diagnostic))
                .Where(violation => violation != null)
                .ToImmutableArray();
        }

        private static ImmutableArray<Diagnostic> GetDiagnostics(string filePath, string csharpSource)
        {
            SyntaxTree tree = CSharpSyntaxTree.ParseText(csharpSource, path: filePath);

            CSharpCompilation compilation = CSharpCompilation.Create("target")
                .AddReferences(MetadataReference.CreateFromFile(typeof(object).Assembly.Location))
                .AddSyntaxTrees(tree);

            ImmutableArray<Diagnostic> compilationDiagnostics = compilation.GetDiagnostics();
            string stylycopAnalyzersPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "StyleCop.Analyzers.dll");
            Assembly stylecopAnalyzersAssembly = Assembly.LoadFrom(stylycopAnalyzersPath);
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

            return compilationDiagnostics
                .Concat(analyzerDiagnostics)
                .ToImmutableArray();
        }

        private static void OnAnalyzerException(Exception exception, DiagnosticAnalyzer analyzer, Diagnostic diagnostic)
        {
        }
    }
}
