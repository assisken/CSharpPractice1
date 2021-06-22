// 5.
//
// а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
// б) Сделать задание, только вывод организовать в центре экрана.
// Жига Никита

using System;

namespace CSharpPractice1
{
    public class FifthProgram
    {
        public static void Run()
        {
            const string meInCity = "Никита Жига, г. Москва";
            var xCenter = (Console.WindowWidth - meInCity.Length) / 2;
            var yCenter = Console.WindowHeight / 2 - 1;

            Console.Clear();
            Console.SetCursorPosition(xCenter, yCenter);
            Console.WriteLine(meInCity);
            Console.WriteLine("Теперь попробуем вариант 2...");
            Console.ReadLine();

            Console.Clear();
            Print(meInCity, xCenter, yCenter);
            Console.WriteLine("Нажмите Enter, чтобы продолжить");
            Console.ReadLine();
        }

        private static void Print(string s, int x, int y)
        {
            var stubWidth = new string(' ', x);

            for (var i = 0; i < y; i++)
                Console.WriteLine();
            Console.Write(stubWidth);
            Console.WriteLine(s);
        }
    }
}