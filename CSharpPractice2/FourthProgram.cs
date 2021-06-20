// 4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
// На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
// Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
// программа пропускает его дальше или не пропускает.
// С помощью цикла do while ограничить ввод пароля тремя попытками.
// Жига Никита

using System;

namespace CSharpPractice2
{
    public static class FourthProgram
    {
        public static void Run()
        {
            var attempts = 3;

            while (attempts > 0)
            {
                Console.Write("Ваш логин: ");
                var login = Console.ReadLine();
                Console.Write("Ваш пароль: ");
                var password = Console.ReadLine();

                if (Check(login, password))
                {
                    Console.WriteLine("Аутентификация успешно пройдена. До свидания!");
                    return;
                }

                attempts--;
                Console.WriteLine($"Неверный логин или пароль. Попробуйте ещё раз. Осталось попыток: {attempts}");
            }
            Console.WriteLine("Все попытки исчерпаны, до свидания!");
        }

        static bool Check(string login, string password) => login == "root" && password == "GeekBrains";
    }
}