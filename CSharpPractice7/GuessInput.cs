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
    public partial class GuessInput : Form
    {
        public int Result { get; private set; }
        public GuessInput()
        {
            InitializeComponent();
            AcceptButton = acceptButton;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out var number))
            {
                Result = number;
                DialogResult = DialogResult.OK;
                Close();
                return;
            }

            MessageBox.Show("Неверное число");
            DialogResult = DialogResult.None;
        }
    }
}