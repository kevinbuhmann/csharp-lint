namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1502ElementMustNotBeOnSingleLine : DiagnoticHandler
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
