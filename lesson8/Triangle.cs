using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8
{
    internal class Triangle : Figure
    {
        protected int b { get; set; }
        protected int c { get; set; }
        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override void Perimeter()
        {
            Console.WriteLine("Perimeter of triangle: " + (a+b+c));
        }
        public override void Square()
        {
            int p = (a + b + c) / 2;
            Console.WriteLine("Square of triangle: " + (Math.Sqrt(p * (p - a) * (p - b) * (p - c))));
        }
    }
}
