using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_projektIO
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {

            InitializeComponent();
            errorLabel.Hide();
            infoLabel.Hide();
        }

        private async void createButton_Click(object sender, EventArgs e)
        {
            if (Connection.createAccount(nameTextBox.Text, surnameTextBox.Text, loginTextBox.Text, passwordTextBox.Text) == 1)
            {
                infoLabel.Show();
                await Task.Delay(2000);
                this.Close();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                Console.WriteLine("Błąd tworzenia konta!");
                errorLabel.Show();
                await Task.Delay(2000);
                this.Close();
                Environment.Exit(1); //zamyka wszystkie aktywne "w tle" formularze

            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
