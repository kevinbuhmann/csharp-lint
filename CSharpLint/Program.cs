using Newtonsoft.Json;
using System;
using System.Collections.Immutable;
using System.IO;

namespace CSharpLint
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            if (args == null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            if (args.Length != 1)
            {
                Console.Write("Must specify exactly one argument which is the path to the file to analyze.");
                Environment.Exit(1);
            }

            string filePath = args[0];

            if (!File.Exists(filePath))
            {
                Console.Write("The specified file could not be found.");
                Environment.Exit(1);
            }

            string csharpSource = File.ReadAllText(filePath);
            ImmutableArray<Violation> violations = Analyzer.Analyze(filePath, csharpSource);
            Console.WriteLine(JsonConvert.SerializeObject(violations, Formatting.Indented));
        }
    }
}
