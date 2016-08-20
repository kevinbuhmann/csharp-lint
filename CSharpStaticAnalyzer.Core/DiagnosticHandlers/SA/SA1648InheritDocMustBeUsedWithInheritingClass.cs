namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1648InheritDocMustBeUsedWithInheritingClass : DiagnoticHandler
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
