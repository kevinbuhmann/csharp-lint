namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1504AllAccessorsMustBeSingleLineOrMultiLine : DiagnoticHandler
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
