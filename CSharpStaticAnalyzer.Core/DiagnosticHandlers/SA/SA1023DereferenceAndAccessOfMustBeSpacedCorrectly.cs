namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1023DereferenceAndAccessOfMustBeSpacedCorrectly : DiagnoticHandler
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
