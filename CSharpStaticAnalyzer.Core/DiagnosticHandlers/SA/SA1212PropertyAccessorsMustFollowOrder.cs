namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1212PropertyAccessorsMustFollowOrder : DiagnoticHandler
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
