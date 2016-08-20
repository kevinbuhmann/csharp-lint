namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1304NonPrivateReadonlyFieldsMustBeginWithUpperCaseLetter : DiagnoticHandler
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
