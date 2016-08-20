namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1636FileHeaderCopyrightTextMustMatch : DiagnoticHandler
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
