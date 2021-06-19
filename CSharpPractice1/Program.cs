using System;

namespace CSharpPractice1
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Выберите задание:");
            Console.WriteLine("3. Написать программу, которая подсчитывает расстояние между точками с координатами");
            Console.WriteLine("4. Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.");
            Console.WriteLine("5. Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.");
            Console.WriteLine("Любое другое значение -- Выход");

            var select = SixthProgram.ReadInt();
            switch (select)
            {
                case 3:
                    ThirdProgram.Run();
                    break;
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