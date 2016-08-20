using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Diagnostics;
using System;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CSharpStaticAnalyzer.Core
{
    public static class Analyzer
    {
        public static ImmutableArray<Violation> Analyze(string csharpSource)
        {
            SyntaxTree tree = CSharpSyntaxTree.ParseText(csharpSource);

            CSharpCompilation compilation = CSharpCompilation.Create("target")
                .AddReferences(MetadataReference.CreateFromFile(typeof(object).Assembly.Location))
                .AddSyntaxTrees(tree);

            ImmutableArray<Diagnostic> compilationDiagnostics = compilation.GetDiagnostics();

            Assembly stylecopAnalyzersAssembly = Assembly.LoadFrom(@"StyleCop.Analyzers.dll");
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
                .Select(i => {
                    FileLinePositionSpan lineSpan = i.Location.GetLineSpan();
                    return new Violation(lineSpan.StartLinePosition.Line, lineSpan.EndLinePosition.Line, i.Descriptor.Id, i.GetMessage());
                 })
                .ToImmutableArray();
        }

        private static void OnAnalyzerException(Exception exception, DiagnosticAnalyzer analyzer, Diagnostic diagnostic)
        {
        }
    }
}
