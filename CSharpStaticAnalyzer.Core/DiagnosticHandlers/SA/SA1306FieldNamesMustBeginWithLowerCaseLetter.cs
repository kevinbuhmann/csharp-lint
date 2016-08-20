using System.Diagnostics.CodeAnalysis;

namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "LowerCase", Justification = "Using same name as StyleCopAnalyzers.")]
    public class SA1306FieldNamesMustBeginWithLowerCaseLetter : DiagnoticHandler
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
