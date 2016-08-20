namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1309FieldNamesMustNotBeginWithUnderscore : DiagnoticHandler
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
