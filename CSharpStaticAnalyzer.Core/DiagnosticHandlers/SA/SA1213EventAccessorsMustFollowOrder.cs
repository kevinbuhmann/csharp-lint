namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1213EventAccessorsMustFollowOrder : DiagnoticHandler
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
