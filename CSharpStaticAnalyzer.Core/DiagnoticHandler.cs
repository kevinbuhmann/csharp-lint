using Microsoft.CodeAnalysis;
using System;
using System.Text.RegularExpressions;

namespace CSharpStaticAnalyzer.Core
{
    public abstract class DiagnoticHandler
    {
        private static readonly Regex TypeNameRegex = new Regex("([A-Z]+[0-9]+)([a-zA-Z]+)");

        public string Id
        {
            get
            {
                return TypeNameRegex.Match(this.GetType().Name).Groups[1].Value;
            }
        }

        public string Name
        {
            get
            {
                return TypeNameRegex.Match(this.GetType().Name).Groups[2].Value;
            }
        }

        public abstract Serverity Serverity { get; }

        public Violation CreateViolation(Diagnostic diagnostic)
        {
            if (this.Id != diagnostic.Descriptor.Id)
            {
                throw new ArgumentException("Diagnostic Id mismatch.");
            }

            FileLinePositionSpan lineSpan = diagnostic.Location.GetLineSpan();
            return new Violation(lineSpan.StartLinePosition.Line, lineSpan.EndLinePosition.Line, this.Id, this.Name, diagnostic.GetMessage(), this.Serverity);
        }
    }
}
