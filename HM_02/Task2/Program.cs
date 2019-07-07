using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class SystemType 
    {
        static void Main()
        {
            string a = "Hello, world!";
            Console.WriteLine(a.GetType());

            System.Byte b = 234;
            Console.WriteLine(b.GetType());

            Console.ReadLine();
        }
    }
}
