using System.Diagnostics.CodeAnalysis;

namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "MultiLine", Justification = "Using same name as StyleCopAnalyzers.")]
    public class SA1413UseTrailingCommasInMultiLineInitializers : DiagnoticHandler
    {
        public override Serverity Serverity
        {
            get
            {
                return Serverity.None;
            }
        }
    }
}
