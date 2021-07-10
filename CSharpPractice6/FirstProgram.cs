// 1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double).
// Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
// Жига Никита

using System;

public delegate double Fun(double a, double x);

namespace CSharpPractice6
{
    public static class FirstProgram
    {
        public static void Table(Fun F, double constant, double from, double to, double step = 1.0)
        {
            Console.WriteLine("------ X ----- Y ------");
            for (var i = from; i <= to; i += step)
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", i, F(constant, i));

            Console.WriteLine("-----------------------");
        }

        static double Hyperbola(double a, double x) => a * Math.Pow(x, 2);

        public static void Run()
        {
            Console.WriteLine("Таблица функции Hyperbola:");
            Table(Hyperbola, 2, -2, 2);
            
            Console.WriteLine("Таблица функции Sin:");
            Table((a, x) => a * Math.Sin(x), 2, -2 * Math.PI, 2 * Math.PI, 0.25 * Math.PI);
        }
    }
}