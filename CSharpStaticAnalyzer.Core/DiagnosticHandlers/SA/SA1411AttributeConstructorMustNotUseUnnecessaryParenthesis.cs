namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1411AttributeConstructorMustNotUseUnnecessaryParenthesis : DiagnoticHandler
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
