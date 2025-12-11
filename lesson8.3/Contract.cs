using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8._3
{
    abstract class Contract
    {
        public int id {  get; set; }
        protected DateTime dateTime { get; set; }

        public void Show()
        {
            Console.WriteLine("id - " + id + " date - " + dateTime);
        }
    }
}
