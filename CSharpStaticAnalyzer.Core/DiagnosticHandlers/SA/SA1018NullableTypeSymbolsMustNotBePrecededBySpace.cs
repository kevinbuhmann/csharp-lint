namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1018NullableTypeSymbolsMustNotBePrecededBySpace : DiagnoticHandler
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
