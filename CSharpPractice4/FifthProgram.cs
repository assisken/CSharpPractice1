// 5.
//
// а) Реализовать библиотеку с классом для работы с двумерным массивом.
// Реализовать конструктор, заполняющий массив случайными числами.
// Создать методы, которые возвращают сумму всех элементов массива,
// сумму всех элементов массива больше заданного,
// свойство, возвращающее минимальный элемент массива,
// свойство, возвращающее максимальный элемент массива,
// метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out).
// *б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
// **в) Обработать возможные исключительные ситуации при работе с файлами.
// Жига Никита

using System;
using System.IO;
using System.Text;

namespace CSharpPractice4
{
    class RandomMatrix
    {
        private readonly int _width;
        private readonly int _height;
        public readonly int Min;
        public readonly int Max;
        private int[,] Matrix { get; }

        public RandomMatrix(int width, int height, int minValue = 0, int maxValue = 10)
        {
            _width = width;
            _height = height;
            Min = maxValue;
            Max = minValue;
            Matrix = new int[width, height];
            var rand = new Random(1);

            for (var w = 0; w < width; w++)
            {
                for (var h = 0; h < height; h++)
                {
                    var num = rand.Next() % (maxValue + 1 - minValue) + minValue;

                    if (num < Min) Min = num;
                    if (num > Max) Max = num;

                    Matrix[w, h] = num;
                }
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append("{");
            for (var i = 0; i < _width; i++)
            {
                sb.Append("{");
                for (var j = 0; j < _height; j++)
                {
                    sb.Append(Matrix[i, j]);
                    sb.Append(j == _height - 1 ? "}" : ", ");
                }

                sb.Append(i == _width - 1 ? "}" : "}, ");
            }

            sb.Append("}");
            return sb.ToString();
        }

        public int SumOfAllElementsBiggerThan(int biggerThan = 0)
        {
            var accumulator = 0;
            foreach (var i in Matrix)
            {
                if (i > biggerThan)
                {
                    accumulator += i;
                }
            }

            return accumulator;
        }

        public void MaxIndex(out int i, out int j)
        {
            for (var w = 0; w < _width; w++)
            {
                for (var h = 0; h < _height; h++)
                {
                    if (Matrix[w, h] != Max) continue;

                    i = w;
                    j = h;
                    return;
                }
            }

            i = -1;
            j = -1;
        }

        public static RandomMatrix FromFile(string filePath)
        {
            StreamReader sr;
            try
            {
                sr = new StreamReader(filePath);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Пустой путь не поддерживается");
                return null;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Файл {filePath} не найден");
                return null;
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine($"Папка в пути {filePath} не найдена");
                return null;
            }
            catch (IOException)
            {
                Console.WriteLine("Ошибка при открытии файла");
                return null;
            }

            var width = int.Parse(sr.ReadLine() ?? "-1");
            var height = int.Parse(sr.ReadLine() ?? "-1");
            var minValue = int.Parse(sr.ReadLine() ?? "0");
            var maxValue = int.Parse(sr.ReadLine() ?? "10");

            sr.Close();
            return new RandomMatrix(width, height, minValue, maxValue);
        }

        public void Save(string filePath)
        {
            StreamWriter sw;
            try
            {
                sw = new StreamWriter(filePath);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Не хватает прав для записи");
                return;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Пустой путь не поддерживается");
                return;
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine($"Папка в пути {filePath} не найдена");
                return;
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Слишком длинный путь");
                return;
            }
            catch (IOException)
            {
                Console.WriteLine("Ошибка при открытии файла");
                return;
            }

            sw.WriteLine(this);
            sw.Close();
        }
    }

    public class FifthProgram
    {
        public static void Run()
        {
            var matrix = new RandomMatrix(5, 5, -5, 5);

            Console.WriteLine($"Матрица: {matrix}");
            Console.WriteLine($"Сумма элементов больше 5-и: {matrix.SumOfAllElementsBiggerThan(5)}");
            Console.WriteLine($"min: {matrix.Min}, max: {matrix.Max}");

            matrix.MaxIndex(out var i, out var j);
            Console.WriteLine($"Индекс максимального значения: [{i}, {j}]");
            Console.WriteLine();

            matrix = RandomMatrix.FromFile("../../data.txt");
            if (matrix == null) return;

            Console.WriteLine($"Матрица из файла: {matrix}");
            Console.WriteLine($"Сумма элементов больше 5-и: {matrix.SumOfAllElementsBiggerThan(5)}");
            Console.WriteLine($"min: {matrix.Min}, max: {matrix.Max}");

            matrix.MaxIndex(out i, out j);
            Console.WriteLine($"Индекс первого максимального значения: [{i}, {j}]");
            
            matrix.Save("../../matrix.txt");
            Console.WriteLine("Матрица сохранена в файл");
            Console.WriteLine();
        }
    }
}