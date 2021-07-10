// 4. Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
// Создайте структуру Account, содержащую Login и Password.
// Жига Никита

using System;
using System.Collections.Generic;
using System.IO;
using static CSharpPractice2.FourthProgram;

namespace CSharpPractice4
{
    struct Account
    {
        public string Login;
        public string Password;
    }
    
    public class FourthProgram
    {
        public static void Run()
        {
            var attempts = 3;
            var accounts = new List<Account>(); 
            
            using (var sr = new StreamReader("../../accounts.txt"))
            {
                for (var i = 0; i < attempts; i++)
                    accounts.Add(new Account {Login = sr.ReadLine(), Password = sr.ReadLine()});
            }

            foreach (var account in accounts)
            {
                if (Check(account.Login, account.Password))
                {
                    Console.WriteLine("Аутентификация успешно пройдена. До свидания!");
                    return;
                }
            }
            Console.WriteLine($"Неверные логины или пароли. Попробуйте в другой раз");
        }
    }
}