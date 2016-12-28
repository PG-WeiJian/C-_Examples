using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    /// <summary>
    /// Rectangle class
    /// </summary>
    class Rectangle
    {
        public double Width { get; set; }
        public double Length { get; set; }

        /// <summary>
        /// 给矩形的长宽赋值
        /// </summary>
        public void Acceptdetails()
        {
            Length = 4.5;
            Width = 3.5;
        }

        /// <summary>
        /// 求矩形的面积
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            return Length * Width;
        }

        /// <summary>
        /// 打印矩形的信息到控制台中
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Length: {0}", Length);
            Console.WriteLine("Width: {0}", Width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }  //end class
}
