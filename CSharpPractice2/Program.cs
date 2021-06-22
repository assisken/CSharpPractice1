using System;

namespace CSharpPractice2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Выберите задание:");
            Console.WriteLine("4. Реализовать метод проверки логина и пароля.");
            Console.WriteLine("5. Написать программу, которая запрашивает массу и рост человека и даёт рекомендацию");
            Console.WriteLine("6. Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.");
            Console.WriteLine("7. Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).");
            Console.WriteLine("Любое другое значение -- Выход");

            var select = CSharpPractice1.SixthProgram.ReadInt();
            switch (select)
            {
                case 4:
                    FourthProgram.Run();
                    break;
                case 5:
                    FifthProgram.Run();
                    break;
                case 6:
                    SixthProgram.Run();
                    break;
                case 7:
                    SeventhProgram.Run();
                    break;
            }
        }
    }
}