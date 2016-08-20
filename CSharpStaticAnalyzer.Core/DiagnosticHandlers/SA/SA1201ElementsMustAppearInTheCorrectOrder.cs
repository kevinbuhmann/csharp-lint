namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1201ElementsMustAppearInTheCorrectOrder : DiagnoticHandler
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
