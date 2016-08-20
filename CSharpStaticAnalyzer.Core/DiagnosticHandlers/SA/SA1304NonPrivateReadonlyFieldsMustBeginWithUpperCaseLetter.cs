using System.Diagnostics.CodeAnalysis;

namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Readonly", Justification = "Using same name as StyleCopAnalyzers.")]
    [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "UpperCase", Justification = "Using same name as StyleCopAnalyzers.")]
    public class SA1304NonPrivateReadonlyFieldsMustBeginWithUpperCaseLetter : DiagnoticHandler
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
