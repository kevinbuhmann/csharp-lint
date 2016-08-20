namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1129DoNotUseDefaultValueTypeConstructor : DiagnoticHandler
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
