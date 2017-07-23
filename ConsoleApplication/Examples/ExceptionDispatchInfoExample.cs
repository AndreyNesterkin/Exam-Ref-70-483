using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Examples
{
    internal class ExceptionDispatchInfoExample : Example
    {
        public override void Run()
        {
            ExceptionDispatchInfo possibleException = null;

            try
            {
                int.Parse("abc");
            }
            catch (FormatException ex)
            {
                possibleException = ExceptionDispatchInfo.Capture(ex);
            }

            if (possibleException != null)
                possibleException.Throw();
        }
    }
}
