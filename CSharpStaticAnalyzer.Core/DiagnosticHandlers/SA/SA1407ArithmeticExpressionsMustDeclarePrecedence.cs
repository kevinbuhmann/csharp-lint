namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1407ArithmeticExpressionsMustDeclarePrecedence : DiagnoticHandler
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
