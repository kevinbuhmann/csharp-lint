namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1124DoNotUseRegions : DiagnoticHandler
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
