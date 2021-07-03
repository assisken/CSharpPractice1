using System;

namespace CSharpPractice3
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
                case 1:
                    FirstProgram.Run();
                    break;
                case 3:
                    ThirdProgram.Run();
                    break;
            }
        }
    }
}