using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Examples.Reflection
{
    internal  class ConditionalAttributeExample : Example
    {
        public override void Run()
        {
            WriteConditionalDebug();

            Host.WriteLine("AfterWriteConditionalDebug");
        }

        [Conditional("DEBUG")]
        private void WriteConditionalDebug()
        {
            Host.WriteLine("WriteConditionalDebug");
        }
    }
}
