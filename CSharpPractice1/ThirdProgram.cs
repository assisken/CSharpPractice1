// 3.
//
// а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2, y2
// по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
// Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
// б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
// Жига Никита

using System;

namespace CSharpPractice1
{
    public class ThirdProgram
    {
        public static void Run()
        {
            Console.Write("x1 = ");
            var x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1 = ");
            var y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x2 = ");
            var x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2 = ");
            var y2 = Convert.ToInt32(Console.ReadLine());

            var result = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
            Console.WriteLine("Результат: {0:0.00}", result);
            Console.WriteLine("Используя метод: {0:0.00}", MeasureDistance(x1, y1, x2, y2));
        }
        
        static double MeasureDistance(int x1, int y1, int x2, int y2)
        {
            return Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
        }
    }
}