// 1.
// а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
// б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
// в) Добавить диалог с использованием switch демонстрирующий работу класса.
// Жига Никита

using System;

namespace CSharpPractice3
{
    struct Complex
    {
        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        public double re;

        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        public double im;

        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public override string ToString()
        {
            return $"{re} + {im}i";
        }

        public static Complex operator +(Complex a, Complex b) => new Complex(a.re + b.re, a.im + b.im);
        public static Complex operator -(Complex a, Complex b) => new Complex(a.re - b.re, a.im - b.im);
    }

    class Complex2
    {
        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        public double re;

        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        public double im;

        public Complex2(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public override string ToString()
        {
            return $"{re} + {im}i";
        }

        public static Complex2 operator +(Complex2 a, Complex2 b) => new Complex2(a.re + b.re, a.im + b.im);
        public static Complex2 operator -(Complex2 a, Complex2 b) => new Complex2(a.re - b.re, a.im - b.im);

        public static Complex2 operator *(Complex2 a, Complex2 b) =>
            new Complex2(a.re * b.re - a.im * b.im, a.re * b.im + a.im * b.re);

        public static Complex2 operator /(Complex2 a, Complex2 b) => new Complex2(
            (a.re * a.im + b.re * b.im) / (a.im * a.im + b.im * b.im),
            (a.im * b.re - a.re * b.im) / (a.im * a.im + b.im * b.im));
    }

    public class FirstProgram
    {
        public static void Run()
        {
            Console.WriteLine("Выберите, какие комплексные числа продемонстрировать:");
            Console.WriteLine("1. Complex через структуру");
            Console.WriteLine("2. Complex через класс");

            var select = CSharpPractice1.SixthProgram.ReadInt();
            switch (select)
            {
                case 1:
                    DemoStruct();
                    break;
                case 2:
                    DemoClass();
                    break;
            }
        }

        public static void DemoStruct()
        {
            var x = new Complex(2, 4);
            var y = new Complex(5, -1);

            Console.WriteLine("Как работают комплексные числа");
            Console.WriteLine($"    x = {x}");
            Console.WriteLine($"    y = {y}");
            Console.WriteLine($"x + y = {x + y}");
            Console.WriteLine($"x - y = {x - y}");
        }

        public static void DemoClass()
        {
            var x = new Complex2(2, 1);
            var y = new Complex2(1, 2);

            Console.WriteLine("Как работают комплексные классы");
            Console.WriteLine($"    x = {x}");
            Console.WriteLine($"    y = {y}");
            Console.WriteLine($"x + y = {x + y}");
            Console.WriteLine($"x - y = {x - y}");
            Console.WriteLine($"x * y = {x * y}");
            Console.WriteLine($"x / y = {x / y}");
        }
    }
}