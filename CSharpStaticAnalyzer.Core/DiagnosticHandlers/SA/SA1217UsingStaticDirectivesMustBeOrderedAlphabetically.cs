namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1217UsingStaticDirectivesMustBeOrderedAlphabetically : DiagnoticHandler
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
