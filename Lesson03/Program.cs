using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            float b = 5.2f;
            double c = 6.3;
            int i = sizeof(int);
            dynamic d = true;
            d = 20;
            d = false;
            Console.WriteLine("{0}, {1}, {2}, {3}", a, b, c, d);
            Console.ReadKey();
        }
    }
}
