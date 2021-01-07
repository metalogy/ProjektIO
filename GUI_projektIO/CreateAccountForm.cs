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
        public static String login;
        public CreateAccountForm()
        {

            InitializeComponent();
            errorLabel.Hide();
        }

        private async void createButton_Click(object sender, EventArgs e)
        {
            if (Connection.createAccount(nameTextBox.Text, surnameTextBox.Text,loginTextBox.Text, passwordTextBox.Text) == 1)
               // if(nameTextBox.Text == "xd")
            {
                login = loginTextBox.Text;
                var MainMenuForm = new MainMenuForm(login, passwordTextBox.Text); //dla rozróżnienia konstruktorów :v
                MainMenuForm.Show();
                this.Close();

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
    }
}
