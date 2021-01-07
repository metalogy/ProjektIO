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
    public partial class DeleteAccountWindow : Form
    {
        String login;
        public DeleteAccountWindow(String login)
        {
            InitializeComponent();
            this.login = login;
            confirmation.Hide();
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            String password = passwordText.Text;
            if (Connection.deleteAccount(this.login, password) == 1)
               // if (password == "xd")
                {
                confirmationLabel.Hide();
                confirmationLabelPassword.Hide();
                confirmationFunc();
                await Task.Delay(2000);
                Console.WriteLine("Pomyśnie usunięto konto");
                Environment.Exit(1); //zamyka wszystkie aktywne "w tle" formularze

            }
            else
            {
                confirmation.Text = "";
                confirmation.Text = "Błędne hasło!"; //ustawienie poprawnej wiadomości
                confirmationFunc();
                var MainMenuForm = new MainMenuForm("Błąd usuwania konta!");
                Console.WriteLine("Błąd usuwania konta!");
                this.Close();
                MainMenuForm.Show();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var MainMenuForm = new MainMenuForm();
            MainMenuForm.Show();
            this.Close();

        }
         private void confirmationFunc()
            {
                confirmation.Show();
                var t = new Timer();
                t.Interval = 1500; // 1,5 sekundy
                t.Tick += (s, e) =>
                {
                    confirmation.Hide();
                    t.Stop();
                };
                t.Start();

            }
    }
}
