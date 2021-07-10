using System;

namespace CSharpPractice4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Выберите задание:");
            Console.WriteLine("4. Аутентификация. Теперь через структуры!");
            Console.WriteLine("5. Матрица случайных чисел");
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
            }

        }
    }
}