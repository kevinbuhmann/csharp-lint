namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1518UseLineEndingsCorrectlyAtEndOfFile : DiagnoticHandler
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
