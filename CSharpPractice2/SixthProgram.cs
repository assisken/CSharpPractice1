using System;

namespace CSharpPractice2
{
    public static class SixthProgram
    {
        public static void Run()
        {
            Console.WriteLine("Хорошие числа:");
            var start = DateTime.Now; 
            for (var i = 1; i <= 1_000_000_000; i++)
            {
                if (IsGoodNumber(i))
                {
                    Console.WriteLine(i);
                }
            }

            var end = DateTime.Now;
            Console.WriteLine($"Программа завершена! Время выполнения: {end - start}");
        }

        static int SumOfDigits(int num)
        {
            var accumulator = 0;
            while (num > 0)
            {
                accumulator += num % 10;
                num /= 10;
            }
            return accumulator;
        }

        static bool IsGoodNumber(int num) => num % SumOfDigits(num) == 0;
    }
}