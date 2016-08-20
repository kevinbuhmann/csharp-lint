namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1122UseStringEmptyForEmptyStrings : DiagnoticHandler
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
