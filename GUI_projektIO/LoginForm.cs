using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
namespace GUI_projektIO
{       /// <summary>
        /// Klasa będąca formularzem logowania
        /// </summary>
    public partial class LoginForm : Form
    {
        public static String login;
        private String password;

        public LoginForm()
        {
            InitializeComponent();
            failedLogin.Hide();
        }
        /// <summary>
        /// Funkcja logowania
        /// </summary>
        private void loginButton_Click(object sender, EventArgs e)
        {
            login = loginText.Text;
            password = passwordText.Text;
            //tutaj łączenie się z bazą danych i logowanie
            var MainMenuForm = new MainMenuForm();
            if (Connection.client.Connected)
                {
                

                if (Connection.sendLoginCredentials(login, this.password) == 1) //dane logowania poprawne
                    {
                    MainMenuForm.Show();
                    Hide(); //zamknięcie zamiast ukrycia??"?
                    Console.WriteLine("Zalogowano");
                }
                else
                {

                    Console.WriteLine("Nieudane logowanie");
                    var t = new Timer();
                    t.Interval = 1500; // 1,5 sekundy
                    failedLogin.Show();
                    t.Tick += (s, er) =>
                    {
                        failedLogin.Hide();
                        t.Stop();
                    };
                    t.Start();
                }

            }

        }
        /// <summary>
        /// Funkcja wychodząca z aplikacji
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Connection.client.Close();
            this.Close();
        }
        /// <summary>
        /// Funkcja przechodząca do formularza tworzenia konta
        /// </summary>
        private void createAccountButton_Click(object sender, EventArgs e)
        {
            var CreateAccountForm = new CreateAccountForm();
            CreateAccountForm.Show();
            Hide();
        }
        /// <summary>
        /// Funkcja przechodząca do panelu administracyjnego
        /// </summary>
        private void adminLoginButton_Click(object sender, EventArgs e)
        {
            var AdminLoginForm = new AdminLoginForm();
            AdminLoginForm.Show();
            Hide();
        }
    }
}
