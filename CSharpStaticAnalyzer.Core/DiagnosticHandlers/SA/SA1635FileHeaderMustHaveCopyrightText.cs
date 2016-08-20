namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1635FileHeaderMustHaveCopyrightText : DiagnoticHandler
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
