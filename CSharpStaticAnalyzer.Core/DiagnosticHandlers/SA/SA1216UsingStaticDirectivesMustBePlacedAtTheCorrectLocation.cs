namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1216UsingStaticDirectivesMustBePlacedAtTheCorrectLocation : DiagnoticHandler
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
