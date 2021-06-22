// 4. Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
//
// а) с использованием третьей переменной;
// б) *без использования третьей переменной.
// Жига Никита

using System;

namespace CSharpPractice1
{
    public class FourthProgram
    {
        public static void Run()
        {
            Console.Write("Введите a: ");
            var a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите b: ");
            var b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Текущие значения: a = {a}, b = {b}");

            Console.WriteLine("Меняю a с b используя 2 переменные!");
            SwapWith2Vars(ref a, ref b);
            Console.WriteLine($"Текущие значения: a = {a}, b = {b}");

            Console.WriteLine("Меняю a с b используя 3 переменные!");
            SwapWith3Vars(ref a, ref b);
            Console.WriteLine($"Текущие значения: a = {a}, b = {b}");

            Console.WriteLine("Меняю a с b используя кортежи!");
            TupleVersion(ref a, ref b);
            Console.WriteLine($"Текущие значения: a = {a}, b = {b}");

            Console.Write("Всё! Нажмите на Enter, чтобы выйти");
            Console.ReadLine();
        }

        static void SwapWith2Vars(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }

        static void SwapWith3Vars(ref int a, ref int b)
        {
            var tmp = a;
            a = b;
            b = tmp;
        }

        static void TupleVersion(ref int a, ref int b)
        {
            (b, a) = (a, b);
        }
    }
}