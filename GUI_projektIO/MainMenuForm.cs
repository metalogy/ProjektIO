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
    /// <summary>
    /// Klasa będąca głównym menu 
    /// </summary>
    public partial class MainMenuForm : Form
    {
        protected String name;
        protected String surname;
        protected int accBalance;
        protected accountStructAll userData; //dane użytkownika

        /// <summary>
        /// Domyślny konstruktor
        /// </summary>
        public MainMenuForm()
        {

            userData = AccountsInformation.getAllData(Connection.getInfo(LoginForm.login));
            InitializeComponent();
            helloLabel.Text = String.Format("Witaj w Banku {0} {1}", userData.name,userData.surname);
        }
        /// <summary>
        /// Konstruktor wyświetlający wiadomość
        /// </summary>
        public MainMenuForm(String message)
        {
            userData = AccountsInformation.getAllData(Connection.getInfo(LoginForm.login));
            InitializeComponent();
            confirmationFunc(message);
        }
        /// <summary>
        /// Funkcja wyłączająca aplikację
        /// </summary>
        private void exit_Click(object sender, EventArgs e)
        {
            Connection.client.Close();
            this.Close();
            Environment.Exit(1);

        }
        private void check_Click(object sender, EventArgs e)
        {
            checkBalance();
        }
        /// <summary>
        /// Funkcja pokazująca formularz wypłaty pieniędzy
        /// </summary>
        private void cashOut_Click(object sender, EventArgs e)
        {
            var MoneyOutWindow = new MoneyOutWindow();
            MoneyOutWindow.Show();
            this.Hide();
        }
        /// <summary>
        /// Funkcja sprawdzająca stan konta i wyświetlająca stan
        /// </summary>
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
        /// <summary>
        /// Funkcja służąca do wyświetlania komunikatów przez 1.5 sekundy
        /// </summary>
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

        /// <summary>
        /// Funkcja pokazująca formularz wpłaty pieniędzy
        /// </summary>
        private void cashIn_Click(object sender, EventArgs e)
        {
            var MoneyInWindow = new MoneyInWindow();
            MoneyInWindow.Show();
            this.Hide();
        }
        /// <summary>
        /// Funkcja pokazująca formularz przelewu
        /// </summary>
        private void transferMoney_Click(object sender, EventArgs e)
        {
            var transferWindow = new transferWindow();
            transferWindow.Show();
            this.Hide();

        }
        /// <summary>
        /// Funkcja pokazująca formularz usuwania konta
        /// </summary>
        private void deleteAccount_Click(object sender, EventArgs e)
        {
            var DeleteAccountWindow = new DeleteAccountWindow(name); //przekazujemy login użytkownika
            DeleteAccountWindow.Show();
            this.Hide();
        }
    }
}
