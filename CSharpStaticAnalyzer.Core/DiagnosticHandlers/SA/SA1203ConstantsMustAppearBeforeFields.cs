namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1203ConstantsMustAppearBeforeFields : DiagnoticHandler
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
