using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public static class Host
    {
        public static void WriteLine(string text)
        {
            Console.WriteLine(text);
            Debug.WriteLine(text);
        }

        public static void WriteLine(object obj)
        {
            Console.WriteLine(obj);
            Debug.WriteLine(obj);
        }
    }
}
