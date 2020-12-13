﻿using System;
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
{
    public partial class LoginForm : Form
    {
        public static String login;
        private String password;

        public LoginForm()
        {
            InitializeComponent();
            failedLogin.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            login = loginText.Text;
            password = passwordText.Text;
            //tutaj łączenie się z bazą danych i logowanie
            var form2 = new MainMenuForm();
            if (connection.client.Connected)
                //if (true)
                {
                int a=connection.sendLoginCredentials(login, this.password);

                if (connection.sendLoginCredentials(login, this.password) == 1) //dane logowania poprawne
                    //if (true) //dane logowania poprawne
                    {
                    form2.Show();
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            connection.client.Close();
            this.Close();
        }

    }
}