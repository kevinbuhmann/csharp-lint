namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1508ClosingBracesMustNotBePrecededByBlankLine : DiagnoticHandler
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
