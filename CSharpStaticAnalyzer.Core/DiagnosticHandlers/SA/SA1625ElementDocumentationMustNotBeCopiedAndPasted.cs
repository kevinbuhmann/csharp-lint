namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1625ElementDocumentationMustNotBeCopiedAndPasted : DiagnoticHandler
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
