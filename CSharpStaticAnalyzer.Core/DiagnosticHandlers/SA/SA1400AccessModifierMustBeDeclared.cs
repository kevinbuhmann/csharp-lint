namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1400AccessModifierMustBeDeclared : DiagnoticHandler
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
