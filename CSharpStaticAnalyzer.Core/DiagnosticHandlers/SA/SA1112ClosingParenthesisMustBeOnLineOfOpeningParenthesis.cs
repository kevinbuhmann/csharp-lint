using System.Diagnostics.CodeAnalysis;

namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "OnLine", Justification = "Using same name as StyleCopAnalyzers.")]
    public class SA1112ClosingParenthesisMustBeOnLineOfOpeningParenthesis : DiagnoticHandler
    {
        public override Serverity Serverity
        {
            get
            {
                return Serverity.MajorWarning;
            }
        }
    }
}
