namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1134AttributesMustNotShareLine : DiagnoticHandler
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
