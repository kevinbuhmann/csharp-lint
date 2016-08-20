namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1310FieldNamesMustNotContainUnderscore : DiagnoticHandler
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
