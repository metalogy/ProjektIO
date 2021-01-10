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
    public partial class AdminLoginForm : Form
    {
        private static String login;
        private String password;
        public AdminLoginForm()
        {
            InitializeComponent();
            failedLogin.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String login = loginText.Text;
            String password = passwordText.Text;
            if (Connection.client.Connected)
            if (true)
            {
                if (Connection.loginAdmin(login, password) == 1) //dane logowania poprawne
                    //if (login=="admin") //dane logowania poprawne
                    {
                    var AdminPanel = new AdminPanel();
                    AdminPanel.Show();
                    this.Close(); //zamknięcie zamiast ukrycia??"?
                    Console.WriteLine("Zalogowano do panelu administracyjnego");
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            Connection.client.Close();
            this.Close();
            Environment.Exit(1);
        }
    
    }
}
