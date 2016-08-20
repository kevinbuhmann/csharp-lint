namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1312VariableNamesMustBeginWithLowerCaseLetter : DiagnoticHandler
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
