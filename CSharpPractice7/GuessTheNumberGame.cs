// 2. Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток. Компьютер говорит, больше или меньше загаданное число введенного.
//
// a) Для ввода данных от человека используется элемент TextBox;
// б) **Реализовать отдельную форму c TextBox для ввода числа.
//
// Жига Никита

using System;

namespace CSharpPractice7
{
    public class GuessTheNumberGame
    {
        private readonly int _number;

        public GuessTheNumberGame()
        {
            var random = new Random();
            _number = random.Next() % 100 + 1;
        }

        public int MakeGuess(int number) => _number.CompareTo(number);
    }
}