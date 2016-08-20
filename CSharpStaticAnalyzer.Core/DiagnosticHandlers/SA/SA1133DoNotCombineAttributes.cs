namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1133DoNotCombineAttributes : DiagnoticHandler
    {
        public override Serverity Serverity
        {
            get
            {
                return Serverity.MajorWarning;
            }
        }
    }
}
