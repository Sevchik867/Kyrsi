using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9
{
    internal class Person
    {
        protected int age { get; set; }
        public void Greet()
        {
            Console.WriteLine("Hi");
        }
        public void SetAge(int Age)
        {
            age = Age;
        }
        public virtual void Doing() { }
    }
}
