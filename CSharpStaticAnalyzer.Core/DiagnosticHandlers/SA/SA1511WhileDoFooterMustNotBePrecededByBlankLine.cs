namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1511WhileDoFooterMustNotBePrecededByBlankLine : DiagnoticHandler
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
