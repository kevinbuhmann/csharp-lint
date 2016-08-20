namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1130UseLambdaSyntax : DiagnoticHandler
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
