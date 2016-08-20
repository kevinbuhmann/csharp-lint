namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1306FieldNamesMustBeginWithLowerCaseLetter : DiagnoticHandler
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
