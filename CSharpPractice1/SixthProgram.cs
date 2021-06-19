// 6. *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
//
// Жига Никита

using System;

namespace CSharpPractice1
{
    public class SixthProgram
    {
        public static void Print(string msg) => Console.WriteLine(msg);
        public static int ReadInt() => Convert.ToInt32(Console.ReadLine());
        public static void Pause() => Console.ReadKey();
    }
}