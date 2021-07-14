// 2. Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток. Компьютер говорит, больше или меньше загаданное число введенного.
//
// a) Для ввода данных от человека используется элемент TextBox;
// б) **Реализовать отдельную форму c TextBox для ввода числа.
//
// Жига Никита

using System;
using System.Windows.Forms;

namespace CSharpPractice7
{
    public partial class GuessTheNumberForm : Form
    {
        private GuessTheNumberGame _game = new();

        public GuessTheNumberForm()
        {
            InitializeComponent();
            label.Text = "Попробуйте угадать число";
        }

        private void makeGuess(int num)
        {
            label.Text = _game.MakeGuess(num) switch
            {
                0 => $"Верно! Это {num}",
                < 0 => $"Неверно! Это не {num}\nЗагаданное число меньше",
                > 0 => $"Неверно! Это не {num}\nЗагаданное число больше"
            };
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            using (var input = new GuessInput())
            {
                switch (input.ShowDialog())
                {
                    case DialogResult.OK:
                        makeGuess(input.Result);
                        break;
                }
            }
        }
    }
}