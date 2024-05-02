using System.Windows.Forms;
using System;

namespace FitnesCenter
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void loginTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void passwordTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                proccesAutorization();
            }
        }

        private void autorizeButton1_Click(object sender, EventArgs e)
        {
            proccesAutorization();
        }

        private void proccesAutorization()
        {
            if ((loginTextBox1.Text == "й") && (passwordTextBox2.Text == "ц"))
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else if ((loginTextBox1.Text.Length == 0) || (passwordTextBox2.Text.Length == 0)) return;
            else
            {
                MessageBox.Show("Неправильный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void loginTextBox1_Enter(object sender, EventArgs e)
        {
            loginTextBox1.TextAlign = HorizontalAlignment.Left;
        }

        private void loginTextBox1_Leave(object sender, EventArgs e)
        {
            loginTextBox1.TextAlign = loginTextBox1.Text.Length > 0 ? HorizontalAlignment.Left : HorizontalAlignment.Center;
        }

        private void passwordTextBox2_Enter(object sender, EventArgs e)
        {
            passwordTextBox2.TextAlign = HorizontalAlignment.Left;
        }

        private void passwordTextBox2_Leave(object sender, EventArgs e)
        {
            passwordTextBox2.TextAlign = passwordTextBox2.Text.Length > 0 ? HorizontalAlignment.Left : HorizontalAlignment.Center;
        }
    }
}
