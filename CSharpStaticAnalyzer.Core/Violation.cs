namespace CSharpStaticAnalyzer.Core
{
    public class Violation
    {
        public Violation(int startLine, int endLine, string id, string message)
        {
            this.StartLine = startLine;
            this.EndLine = endLine;
            this.Id = id;
            this.Message = message;
        }

        public int StartLine { get; }

        public int EndLine { get; }

        public string Id { get;  }

        public string Message { get; }
    }
}
