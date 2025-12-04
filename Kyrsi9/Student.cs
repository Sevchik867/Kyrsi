using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9
{
    internal class Student:Person
    {
        public override void Doing()
        {
            Console.WriteLine("Study");
        }
        public void ShowAge()
        {
            Console.WriteLine("Age:" + age);
        }
    }
}
