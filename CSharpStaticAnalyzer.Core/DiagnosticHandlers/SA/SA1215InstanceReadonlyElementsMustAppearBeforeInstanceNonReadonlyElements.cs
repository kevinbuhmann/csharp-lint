using System.Diagnostics.CodeAnalysis;

namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Readonly", Justification = "Using same name as StyleCopAnalyzers.")]
    public class SA1215InstanceReadonlyElementsMustAppearBeforeInstanceNonReadonlyElements : DiagnoticHandler
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
