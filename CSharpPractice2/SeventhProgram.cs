using System;

namespace CSharpPractice2
{
    public static class SeventhProgram
    {
        public static void Run()
        {
            Console.Write("Введите a: ");
            var a = CSharpPractice1.SixthProgram.ReadInt();
            Console.Write("Введите b: ");
            var b = CSharpPractice1.SixthProgram.ReadInt();
            Console.WriteLine("Рекурсивные вызовы от a до b:");
            RecursiveFromAToB(a, b);
            Console.WriteLine($"Сумма a и b: {RecursiveSum(a, b)}");
        }

        static void RecursiveFromAToB(int a, int b)
        {
            if (a > b)
                return;
            Console.WriteLine(a);
            RecursiveFromAToB(a + 1, b);
        }

        static int RecursiveSum(int a, int b)
        {
            static int ActualRecurse(int sum, int a, int b)
            {
                if (a == b)
                    sum += a;
                if (a >= b)
                    return sum;
                return ActualRecurse(sum + a + b, a + 1, b - 1);
            }
            return ActualRecurse(0, a, b);
        }
    }
}