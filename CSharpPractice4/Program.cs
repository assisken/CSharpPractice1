using System;

namespace CSharpPractice4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Выберите задание:");
            Console.WriteLine("1. Вычисления комплексных чисел");
            Console.WriteLine("3. Демонстрация класса дробей");
            Console.WriteLine("Любое другое значение -- Выход");

            var select = CSharpPractice1.SixthProgram.ReadInt();
            switch (select)
            {
                case 5:
                    FifthProgram.Run();
                    break;
            }

        }
    }
}