namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1006PreprocessorKeywordsMustNotBePrecededBySpace : DiagnoticHandler
    {
        public override Serverity Serverity
        {
            get
            {
                return Serverity.MinorWarning;
            }
        }
    }
}
