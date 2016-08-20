namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1503BracesMustNotBeOmitted : DiagnoticHandler
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
