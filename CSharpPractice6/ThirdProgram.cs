// 3. Переделать программу Пример использования коллекций для решения следующих задач:
//
// а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
// б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
// в) отсортировать список по возрасту студента;
// г) *отсортировать список по курсу и возрасту студента;
//
// Жига Никита

using System;
using System.Collections.Generic;
using System.IO;

namespace CSharpPractice6
{
    struct Student
    {
        public readonly string FirstName;
        public readonly string SecondName;
        public readonly int Age;
        public readonly int Course;

        public Student(string[] row)
        {
            FirstName = row[0];
            SecondName = row[1];
            Age = int.Parse(row[5]);
            Course = int.Parse(row[6]);
        }

        public override string ToString() => $"{FirstName} {SecondName} ({Age}, {Course}-й курс)";
    }
    
    
    public static class ThirdProgram
    {
        static int CompareStudentByCourseAndAge(Student first, Student second)
        {
            var comparator = first.Course.CompareTo(second.Course);
            if (comparator == 0)
                comparator = first.Age.CompareTo(second.Age);
            return comparator;
        }

        public static void Run()
        {
            var students = new List<Student>();
            var startTime = DateTime.Now;
            var olderCourse = 0;
            int[] courseFrequency = {0, 0, 0, 0, 0, 0};
            
            using (var sr = new StreamReader("..\\..\\students.csv"))
            {
                while(!sr.EndOfStream)
                {
                    try {
                        var row = sr.ReadLine().Split(';');
                        var student = new Student(row);
                        
                        students.Add(student);
                        
                        if (student.Course >= 5)
                            olderCourse++;
                        if (18 <= student.Age && student.Age <= 20)
                            courseFrequency[student.Course - 1]++;
                    }
                    catch
                    {
                    }
                }
            }
            
            students.Sort((first, second) => first.Age.CompareTo(second.Age));
            Console.WriteLine("Список студентов по возрасту:");
            foreach (var student in students)
                Console.WriteLine(student);
            Console.WriteLine();

            students.Sort(CompareStudentByCourseAndAge);
            Console.WriteLine("Список студентов по курсу и возрасту:");
            foreach (var student in students)
                Console.WriteLine(student);
            Console.WriteLine();

            Console.WriteLine("Статистика");
            Console.WriteLine($"Всего студентов: {students.Count}");
            Console.WriteLine($"Из них в 5м и 6м курсах: {olderCourse}");
            Console.WriteLine($"Частотный массив, на каких курсах учатся студенты от 18 до 20-и лет\n(сначала номер курса, под ним количество человек)");
            for (var i = 0; i < 6; i++)
                Console.Write($"{i + 1} ");
            Console.WriteLine();
            for (var i = 0; i < 6; i++)
                Console.Write($"{courseFrequency[i]} ");
            Console.WriteLine();
            Console.WriteLine($"Время работы: {DateTime.Now - startTime}");
            Console.ReadKey();
        }
    }
}