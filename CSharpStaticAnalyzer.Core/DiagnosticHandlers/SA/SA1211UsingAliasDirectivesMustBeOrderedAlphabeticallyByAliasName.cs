namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1211UsingAliasDirectivesMustBeOrderedAlphabeticallyByAliasName : DiagnoticHandler
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
