namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1301ElementMustBeginWithLowerCaseLetter : DiagnoticHandler
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
