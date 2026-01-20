using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace lesson12
{
    class Authorization
    {
        public static bool AutorizationMethod(string username, string password, string confirmPassword)
        {

                if (username.Length < 20 && username.Any(Char.IsWhiteSpace) != true)
                {
                    Regex rule = new Regex(@"^[0-9]");
                    if (password.Length < 20 && password.Any(Char.IsWhiteSpace) != true && rule.IsMatch(password) && password == confirmPassword)
                    {
                        Console.WriteLine("Выполнен вход");
                        return true;
                    }
                    else { throw new WrongPasswordException(); return false; }
                }
                else {   throw new WrongLoginException(); return false; }
        }   
    }
}
