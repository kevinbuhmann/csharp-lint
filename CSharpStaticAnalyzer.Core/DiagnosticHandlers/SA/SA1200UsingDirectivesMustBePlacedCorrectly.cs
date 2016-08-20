namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1200UsingDirectivesMustBePlacedCorrectly : DiagnoticHandler
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
