namespace CSharpStaticAnalyzer.Core
{
    public class Violation
    {
        public Violation(int startLine, int endLine, string id, string name, string message, Serverity serverity)
        {
            this.StartLine = startLine;
            this.EndLine = endLine;
            this.Id = id;
            this.Name = name;
            this.Message = message;
            this.Serverity = serverity;
        }

        public int StartLine { get; }

        public int EndLine { get; }

        public string Id { get; }

        public string Name { get;  }

        public string Message { get; }

        public Serverity Serverity { get; }
    }
}
