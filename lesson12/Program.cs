namespace lesson12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Authorization.AutorizationMethod("dgsfg", "123", "123");
            }
            catch (WrongLoginException) { Console.WriteLine("Некорректный логин."); }
            catch (WrongPasswordException) { Console.WriteLine("Некорректный пароль."); }
        }
    }
}
