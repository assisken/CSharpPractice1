// 1.
//
// а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
// б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок. Игрок должен получить это число за минимальное количество ходов.
// в) *Добавить кнопку «Отменить», которая отменяет последние ходы. Используйте библиотечный обобщенный класс System.Collections.Generic.Stack<int>Stack.
// Вся логика игры должна быть реализована в классе с удвоителем.
//
// Жига Никита

using System;
using System.Windows.Forms;

namespace CSharpPractice7
{
    public partial class MultiplierForm : Form
    {
        private MultiplierGame _game = new MultiplierGame();

        public MultiplierForm()
        {
            InitializeComponent();
        }

        private void MakeTick()
        {
            if (_game.IsEnded())
            {
                var message = _game.IsVictory() ? "Вы победили!" : "Вы проиграли!";
                MessageBox.Show(message);
                addOne.Enabled = doubleValue.Enabled = redo.Enabled = false;
            }

            label.Text = $"Текущее\n{_game.Current}\n\nЦель\n{_game.Goal}";
        }

        private void Form1_Load(object sender, EventArgs e) => MakeTick();

        private void AddOne_Click(object sender, EventArgs e)
        {
            _game.Add(1);
            MakeTick();
        }

        private void Double_Click(object sender, EventArgs e)
        {
            _game.Multiply(2);
            MakeTick();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            _game = new MultiplierGame();
            addOne.Enabled = doubleValue.Enabled = redo.Enabled = true;
            MakeTick();
        }

        private void redo_Click(object sender, EventArgs e)
        {
            _game.Undo();
            MakeTick();
        }
    }
}