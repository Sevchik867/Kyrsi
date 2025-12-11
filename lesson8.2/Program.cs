namespace lesson8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            Director director = new Director();
            Accountant accountant = new Accountant();

            worker.Show();
            director.Show();
            accountant.Show();
        }
    }
}
