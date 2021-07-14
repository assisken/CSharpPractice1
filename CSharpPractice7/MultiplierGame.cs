// 1.
//
// а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
// б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок. Игрок должен получить это число за минимальное количество ходов.
// в) *Добавить кнопку «Отменить», которая отменяет последние ходы. Используйте библиотечный обобщенный класс System.Collections.Generic.Stack<int>Stack.
// Вся логика игры должна быть реализована в классе с удвоителем.
//
// Жига Никита

using System;
using System.Collections.Generic;

namespace CSharpPractice7
{
    public class MultiplierGame
    {
        public int Current { get; private set; }
        public readonly int Goal;
        private readonly Stack<int> _history;

        public MultiplierGame()
        {
            var r = new Random();
            Goal = r.Next() % 100;
            Current = 0;

            _history = new Stack<int>();
        }

        public void Add(int count)
        {
            if (IsEnded())
                throw new ArgumentException("Game was ended");
            _history.Push(Current);
            Current += count;
        }

        public void Multiply(int count)
        {
            if (IsEnded())
                throw new ArgumentException("Game was ended");
            _history.Push(Current);
            Current *= count;
        }

        public void Undo() {
            if (_history.Count > 0)
                Current = _history.Pop();
        }

        public bool IsEnded() => Current >= Goal;
        public bool IsVictory() => Current == Goal;
    }
}