using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8._3
{
    internal class ContractWorker : Contract
    {
        protected DateTime dateEndContract { get; set;}
        protected string name {  get; set;}
        public ContractWorker() { }
        public ContractWorker(int id, DateTime dateTime, DateTime dateEndContract, string name)
        {
            this.id = id;
            this.dateTime = dateTime;
            this.dateEndContract = dateEndContract;
            this.name = name;
        }
        public void Show()
        {
            Console.WriteLine("id - " + id + " date - " + dateTime + " date end - " + dateEndContract + " name - " + name);
        }
    }
}
