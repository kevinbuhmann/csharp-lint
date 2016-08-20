namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1501StatementMustNotBeOnSingleLine : DiagnoticHandler
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
