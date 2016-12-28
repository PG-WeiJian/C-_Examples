using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.Acceptdetails();
            rect.GetArea();
            rect.Display();
            Console.ReadKey();
        }
    }
}
