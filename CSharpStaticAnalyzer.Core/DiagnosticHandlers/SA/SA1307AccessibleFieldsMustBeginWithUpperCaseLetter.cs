using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;

namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1307AccessibleFieldsMustBeginWithUpperCaseLetter : DiagnoticHandler
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
