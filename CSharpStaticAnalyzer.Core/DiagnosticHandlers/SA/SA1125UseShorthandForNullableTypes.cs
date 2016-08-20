namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1125UseShorthandForNullableTypes : DiagnoticHandler
    {
        public override Serverity Serverity
        {
            get
            {
                return Serverity.MinorWarning;
            }
        }
    }
}
