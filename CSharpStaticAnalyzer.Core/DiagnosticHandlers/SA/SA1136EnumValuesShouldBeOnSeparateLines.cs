namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1136EnumValuesShouldBeOnSeparateLines : DiagnoticHandler
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
