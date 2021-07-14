using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSharpPractice7
{
    public partial class MainMenuForm : Form
    {
        private readonly Dictionary<string, Form> _forms = new()
        {
            {"Задание 1. Удвоитель", new MultiplierForm()},
            {"Задание 2. Угадай число", new GuessTheNumberForm()},
        };
        public MainMenuForm()
        {
            InitializeComponent();
            foreach (var key in _forms.Keys)
                applications.Items.Add(key);
        }

        private void launch_Click(object sender, EventArgs e)
        {
            var selectedForm = _forms[(string) applications.SelectedItem];
            selectedForm.Closed += (_, _) => Close(); 
            selectedForm.Show();
            Hide();
        }

        private void exit_Click(object sender, EventArgs e) => Close();

        private void applications_SelectedIndexChanged(object sender, EventArgs e)
        {
            launch.Enabled = true;
        }
    }
}