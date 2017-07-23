using ConsoleApplication.Examples;
using ConsoleApplication.Examples.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        public static void Main()
        {
            try
            {
                new ExceptionDispatchInfoExample().Run();
            }
            catch (Exception exception)
            {
                Host.WriteLine(exception);
            }

            Console.ReadKey();
        }
    }
}
