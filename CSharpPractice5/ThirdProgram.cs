// 3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
// Например: badc являются перестановкой abcd.
// Жига Никита

using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpPractice5
{
    public class ThirdProgram
    {
        static bool IsShiftedUsingSets(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;

            var s1 = new HashSet<char>(str1);
            var s2 = new HashSet<char>(str2);

            return s1.SetEquals(s2);
        }

        static bool IsShiftedUsingLists(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;

            var l1 = str1.ToList();
            var l2 = str2.ToList();
            l1.Sort();
            l2.Sort();

            return l1.SequenceEqual(l2);
        }

        static bool IsShiftedUsingDict(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;

            var d1 = new Dictionary<char, int>();
            foreach (var ch in str1)
                if (d1.TryGetValue(ch, out _))
                    d1[ch]++;
                else
                    d1[ch] = 1;

            var d2 = new Dictionary<char, int>();
            foreach (var ch in str2)
                if (d2.TryGetValue(ch, out _))
                    d2[ch]++;
                else
                    d2[ch] = 1;

            return d1.Count == d2.Count && !d1.Except(d2).Any();
        }

        public static void Run()
        {
            var str1 = "abcd";
            var str2 = "dbca";

            Console.WriteLine($"Даны строки: {str1} и {str2}");
            Console.WriteLine("Являются ли они перестановкой друг друга?");
            Console.WriteLine($"Метод 1: {IsShiftedUsingSets(str1, str2)}");
            Console.WriteLine($"Метод 2: {IsShiftedUsingLists(str1, str2)}");
            Console.WriteLine($"Метод 3: {IsShiftedUsingDict(str1, str2)}");
        }
    }
}