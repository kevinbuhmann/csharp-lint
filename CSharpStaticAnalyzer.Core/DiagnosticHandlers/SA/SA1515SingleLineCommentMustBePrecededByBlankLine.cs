namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1515SingleLineCommentMustBePrecededByBlankLine : DiagnoticHandler
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
