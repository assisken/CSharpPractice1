//3. *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
// Предусмотреть методы сложения, вычитания, умножения и деления дробей.
// Написать программу, демонстрирующую все разработанные элементы класса.
//
// Добавить свойства типа int для доступа к числителю и знаменателю;
// Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
// ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
// *** Добавить упрощение дробей.
//
// Жига Никита

using System;

namespace CSharpPractice3
{
    class SomeMath
    {
        /// <summary>
        /// Находит наибольший общий делитель двух чисел
        /// </summary>
        public static int GCF(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        /// <summary>
        /// Находит наименьшее общее кратное двух чисел
        /// </summary>
        public static int LCM(int a, int b)
        {
            return Math.Abs(a * b) / GCF(a, b);
        }

        public static (Fraction, Fraction) EqualFractionDenominators(Fraction a, Fraction b)
        {
            var lcmForDenominator = LCM(a.Denominator, b.Denominator);
            var newANumerator = a.Numerator * lcmForDenominator / a.Denominator;
            var newBNumerator = b.Numerator * lcmForDenominator / b.Denominator;

            return (
                new Fraction(newANumerator, lcmForDenominator),
                new Fraction(newBNumerator, lcmForDenominator)
            );
        }
    }

    class Fraction
    {
        private int _denominator;

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public int Numerator { get; }

        public int Denominator
        {
            get => _denominator;
            private set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Знаменатель не может быть равен 0");
                }

                _denominator = value;
            }
        }

        public double AsDouble => 1.0 * Numerator / Denominator;
        public override string ToString() => $"{Numerator} / {Denominator}";

        public Fraction Simplified()
        {
            var gcf = SomeMath.GCF(Numerator, Denominator);
            return new Fraction(Numerator / gcf, Denominator / gcf);
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            var (newA, newB) = SomeMath.EqualFractionDenominators(a, b);
            return new Fraction(newA.Numerator + newB.Numerator, newA.Denominator);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            var (newA, newB) = SomeMath.EqualFractionDenominators(a, b);
            return new Fraction(newA.Numerator - newB.Numerator, newA.Denominator);
        }

        public static Fraction operator *(Fraction a, Fraction b) =>
            new Fraction(a.Numerator * b.Numerator, a.Denominator * b.Denominator);

        public static Fraction operator /(Fraction a, Fraction b) =>
            new Fraction(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
    }

    public class ThirdProgram
    {
        public static void Run()
        {
            var a = new Fraction(1, 2);
            var b = new Fraction(1, 3);

            Console.WriteLine("Основные операций над дробями");
            Console.WriteLine($"    a = {a} ~ {a.AsDouble}");
            Console.WriteLine($"    b = {b} ~ {b.AsDouble}");
            Console.WriteLine($"a + b = {a + b}");
            Console.WriteLine($"a - b = {a - b}");
            Console.WriteLine($"a * b = {a * b}");
            Console.WriteLine($"a / b = {a / b}");
            Console.WriteLine();

            var c = new Fraction(7, 14);
            var d = new Fraction(100, 10);

            Console.WriteLine("Упрощение дробей");
            Console.WriteLine($"c = {c} = {c.Simplified()}");
            Console.WriteLine($"d = {d} = {d.Simplified()}");
        }
    }
}