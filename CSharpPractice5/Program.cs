using System;

namespace CSharpPractice5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Выберите задание:");
            Console.WriteLine("3. Перестановка строк");
            Console.WriteLine("4. Задача ЕГЭ");
            Console.WriteLine("Любое другое значение -- Выход");

            var select = CSharpPractice1.SixthProgram.ReadInt();
            switch (select)
            {
                case 3:
                    ThirdProgram.Run();
                    break;
                case 4:
                    FourthProgram.Run();
                    break;
            }

        }
    }
}