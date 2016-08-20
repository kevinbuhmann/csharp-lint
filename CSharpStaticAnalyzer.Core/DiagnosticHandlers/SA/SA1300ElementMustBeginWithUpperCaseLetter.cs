namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1300ElementMustBeginWithUpperCaseLetter : DiagnoticHandler
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
