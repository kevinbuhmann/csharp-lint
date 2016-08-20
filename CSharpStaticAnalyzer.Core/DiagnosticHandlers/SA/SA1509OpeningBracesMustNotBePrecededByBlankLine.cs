namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1509OpeningBracesMustNotBePrecededByBlankLine : DiagnoticHandler
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
