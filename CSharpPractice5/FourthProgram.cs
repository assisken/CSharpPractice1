// 4. *Задача ЕГЭ.
// На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы.
// В первой строке сообщается количество учеников N,
// которое не меньше 10, но не превосходит 100, каждая из следующих N строк имеет следующий формат:
// <Фамилия> <Имя> <оценки>,
//
// где <Фамилия> — строка, состоящая не более чем из 20 символов,
// <Имя> — строка, состоящая не более чем из 15 символов,
// <оценки> — через пробел три целых числа, соответствующие оценкам по пятибалльной системе.
// <Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом.
//
// Пример входной строки:
// Иванов Петр 4 5 3
// Требуется написать как можно более эффективную программу,
// которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников.
// Если среди остальных есть ученики, набравшие тот же средний балл,
// что и один из трёх худших, следует вывести и их фамилии и имена.
//
// Жига Никита

using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpPractice5
{
    class Pupil
    {
        public readonly string LastName;
        public readonly string FirstName;
        public readonly List<int> Score;

        public Pupil(string row)
        {
            Score = new List<int>();
            var data = row.Split(' ');
            LastName = data[0];
            FirstName = data[1];

            foreach (var mark in data.Skip(2))
                Score.Add(int.Parse(mark));
        }

        public double AverageScore() => Score.Sum() * 1.0 / Score.Count;

        public override string ToString() => $"{LastName} {FirstName}";
    }

    public class FourthProgram
    {
        public static void Run()
        {
            var pupilByAverageScore = new SortedDictionary<double, List<Pupil>>();

            Console.Write("Введите количество учеников: ");
            var pupilCount = CSharpPractice1.SixthProgram.ReadInt();

            Console.WriteLine("Введите учеников:");

            for (var i = 0; i < pupilCount; i++)
            {
                var pupil = new Pupil(Console.ReadLine());
                var average = pupil.AverageScore();

                if (pupilByAverageScore.TryGetValue(average, out var l))
                    l.Add(pupil);
                else
                    pupilByAverageScore[average] = new List<Pupil> {pupil};
            }

            Console.WriteLine("Худшие ученики:");
            foreach (var worstPupils in pupilByAverageScore.Take(3))
            foreach (var pupil in worstPupils.Value)
                Console.WriteLine(pupil);
        }
    }
}