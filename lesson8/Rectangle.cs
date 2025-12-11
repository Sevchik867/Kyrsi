using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8
{
    internal class Rectangle : Figure
    {
        protected int b {  get; set; }
        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public override void Perimeter()
        {
            Console.WriteLine("Perimeter of rectangle: " + (a+a+b+b));
        }
        public override void Square()
        {
            Console.WriteLine("Square of rectangle: " + (a*b));
        }
    }
}
