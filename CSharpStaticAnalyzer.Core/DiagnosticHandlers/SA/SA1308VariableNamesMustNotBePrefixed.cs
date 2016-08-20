namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1308VariableNamesMustNotBePrefixed : DiagnoticHandler
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
