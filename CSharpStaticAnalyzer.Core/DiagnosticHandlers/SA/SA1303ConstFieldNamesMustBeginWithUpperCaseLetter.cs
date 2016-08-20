namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1303ConstFieldNamesMustBeginWithUpperCaseLetter : DiagnoticHandler
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
