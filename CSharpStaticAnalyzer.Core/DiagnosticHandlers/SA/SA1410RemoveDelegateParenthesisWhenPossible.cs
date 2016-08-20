namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1410RemoveDelegateParenthesisWhenPossible : DiagnoticHandler
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
