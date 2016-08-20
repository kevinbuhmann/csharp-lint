namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
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
