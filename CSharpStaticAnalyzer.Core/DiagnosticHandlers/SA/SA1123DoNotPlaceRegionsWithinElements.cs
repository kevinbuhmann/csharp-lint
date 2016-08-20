namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1123DoNotPlaceRegionsWithinElements : DiagnoticHandler
    {
        public override Serverity Serverity
        {
            get
            {
                return Serverity.MajorWarning;
            }
        }
    }
}
