using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8
{
    internal class Circle : Figure
    {
        public Circle(int a)
        {
            this.a = a;
        }
        public override void Perimeter()
        {
            Console.WriteLine("Perimeter of circle: " + (2 * 3.14 * a));
        }
        public override void Square()
        {
            Console.WriteLine("Square of circle: " + (3.14 * Math.Pow(a, 2)));
        }
    }
}
