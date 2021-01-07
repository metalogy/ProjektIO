using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;

namespace GUI_projektIO
{
     
    public partial class MainMenuForm : Form
    {
        protected String name;
        protected String surname;
        protected int accBalance;
        protected List<accountStruct> accounts;

        public MainMenuForm()
        {
            //trza pobrać imię i nazwisko z banku

            name = LoginForm.login;
           /// accounts = AccountsInformation.getAccounts(connection.downloadAccounts());
            InitializeComponent();
            helloLabel.Text = String.Format("Witaj w Banku {0}", name);
        }
        public MainMenuForm(String login,String password) //do przejścia po stworzenia konta
        {
            //trza pobrać imię i nazwisko z banku

            name = login;
            /// accounts = AccountsInformation.getAccounts(connection.downloadAccounts());
            InitializeComponent();
            helloLabel.Text = String.Format("Witaj w Banku {0}", name);
        }
        public MainMenuForm(String message)
        {
            name = LoginForm.login;
            /// accounts = AccountsInformation.getAccounts(connection.downloadAccounts());
            InitializeComponent();
            confirmationFunc(message);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Connection.client.Close();
            this.Close();
        }
        private void check_Click(object sender, EventArgs e)
        {
            checkBalance();
        }

        private void cashOut_Click(object sender, EventArgs e)
        {
            var MoneyOutWindow = new MoneyOutWindow();
            MoneyOutWindow.Show();
            this.Hide();
        }
        private void checkBalance()
        {
            this.accBalance = Connection.checkBalance();
            balance.Text = String.Format("Stan twojego konta w banku wynosi {0}$", accBalance);
            var t = new Timer();
            t.Interval = 1500; // 1,5 sekundy
            balance.Show();
            t.Tick += (s, e) =>
            {
                balance.Hide();
                t.Stop();
            };
            t.Start();

        }
        private void confirmationFunc(String message)
        {
            confirmation.Text = String.Format(message);
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


        private void cashIn_Click(object sender, EventArgs e)
        {
            var MoneyInWindow = new MoneyInWindow();
            MoneyInWindow.Show();
            this.Hide();
        }

        private void transferMoney_Click(object sender, EventArgs e)
        {
            var transferWindow = new transferWindow(this.accounts);
            transferWindow.Show();
            this.Hide();

        }

        private void deleteAccount_Click(object sender, EventArgs e)
        {
            var DeleteAccountWindow = new DeleteAccountWindow(name); //przekazujemy login użytkownika
            DeleteAccountWindow.Show();
            this.Hide();
        }
    }
}
