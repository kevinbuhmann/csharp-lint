namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1209UsingAliasDirectivesMustBePlacedAfterOtherUsingDirectives : DiagnoticHandler
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
