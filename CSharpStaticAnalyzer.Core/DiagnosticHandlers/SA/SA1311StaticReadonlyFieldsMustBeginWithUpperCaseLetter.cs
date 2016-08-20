namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1311StaticReadonlyFieldsMustBeginWithUpperCaseLetter : DiagnoticHandler
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
