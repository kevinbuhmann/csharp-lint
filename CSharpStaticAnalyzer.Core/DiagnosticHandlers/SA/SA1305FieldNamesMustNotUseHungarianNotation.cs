namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1305FieldNamesMustNotUseHungarianNotation : DiagnoticHandler
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
