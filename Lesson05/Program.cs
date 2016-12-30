using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 60, b = 13;
            Console.WriteLine(Convert.ToString(a, 2));
            Console.WriteLine(Convert.ToString(b, 2));
            Console.WriteLine();
            Console.WriteLine(Convert.ToString(a | b, 2));
            Console.WriteLine(Convert.ToString(a ^ b, 2));
            Console.WriteLine(Convert.ToString(a & b, 2));
            Console.ReadKey();
        }
    }
}
