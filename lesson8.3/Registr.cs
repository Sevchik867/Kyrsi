using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8._3
{
    internal class Registr
    {
        protected List<Contract> contracts = new List<Contract>(); 
        public Registr() { }
        public Registr(FinancialInvoice financialInvoice) 
        {
            contracts.Add(financialInvoice);
        }
        public Registr(ContractOfGoods contractOfGoods)
        {
            contracts.Add(contractOfGoods);
        }
        public Registr(ContractWorker contractWorker)
        {
            contracts.Add(contractWorker);
        }

        public void ShowContract(int id)
        {
            foreach (Contract contract in contracts)
            {
                if(id == contract.id)
                {
                    contract.Show();
                }
            }
        }
    }
}
