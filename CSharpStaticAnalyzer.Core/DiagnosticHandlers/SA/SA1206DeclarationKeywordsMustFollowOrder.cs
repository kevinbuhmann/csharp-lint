namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1206DeclarationKeywordsMustFollowOrder : DiagnoticHandler
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
