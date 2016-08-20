namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1132DoNotCombineFields : DiagnoticHandler
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
