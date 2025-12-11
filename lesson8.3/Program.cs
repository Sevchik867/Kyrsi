namespace lesson8._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2015, 7, 20);
            DateTime date2 = new DateTime(2016, 7, 20);
            ContractWorker worker = new ContractWorker(0, date1, date2, "Name0");
            ContractWorker worker1 = new ContractWorker(1, date1, date2, "Name1");
            Registr registr = new Registr(worker);
            registr.ShowContract(0);
        }
    }
}
