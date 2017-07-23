using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Examples
{
    internal class FailFastExample : Example
    {
        public override void Run()
        {
            Host.WriteLine("int.Parse()");

            try
            {
                int i = int.Parse("42");

                if (i == 42)
                    Environment.FailFast("Special number entered");
            }
            finally
            {
                Host.WriteLine("Program complete.");
            }
        }
    }
}
