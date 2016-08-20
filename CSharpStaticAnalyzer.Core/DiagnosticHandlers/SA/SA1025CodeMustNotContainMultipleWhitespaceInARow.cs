namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1025CodeMustNotContainMultipleWhitespaceInARow : DiagnoticHandler
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
