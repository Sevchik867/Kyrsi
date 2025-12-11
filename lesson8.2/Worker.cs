using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8._2
{
    internal class Worker : IShow
    {
        public void Show() 
        {
            Console.WriteLine("Worker");
        }
    }
}
