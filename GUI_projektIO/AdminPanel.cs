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
    /// <summary>
    /// Klasa będąca panelem administracyjnym
    /// </summary>
    public partial class AdminPanel : Form
    {
        protected List<loginList> accounts;

        /// <summary>
        /// Konstruktor
        /// </summary>
        public AdminPanel()
        {
            InitializeComponent();
            confirmationLabel.Hide();
            errorLabel.Hide();
            updateCombo();
           
        }
        /// <summary>
        /// Funkcja pobierająca dostępne konta i umieszczająca je w comboboxie
        /// </summary>
        private void updateCombo()
        {
            comboBoxUsers.Items.Clear();
            accounts = AccountsInformation.getAccounts(Connection.downloadAccounts());
            foreach (loginList user in this.accounts)
            {
                comboBoxUsers.Items.Add(user.login);
            }
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

        /// <summary>
        /// Funkcja usuwająca konto z banku
        /// </summary>
        private void deleteAccount_Click(object sender, EventArgs e)
        {
            String a = comboBoxUsers.Text;
            if (Connection.deleteAccount(a) == 1) 
            {
                confirmationFunc(confirmationLabel);
                clearTextboxes();
            }
            else
            {
                confirmationFunc(errorLabel);
                clearTextboxes();
            }
            updateCombo();
        }
        /// <summary>
        /// Funkcja czyszcząca pola textowe
        /// </summary>
        private void clearTextboxes()
        {
            nameTextBox.Text=String.Empty;
            surnameTextBox.Text = String.Empty;
            loginTextBox.Text = String.Empty;
            passwordTextBox.Text = String.Empty;
            balanceTextBox.Text = String.Empty;
        }
        /// <summary>
        /// Funkcja sprawdzająca czy dane są numeryczne
        /// </summary>
        /// <returns>
        /// Prawda lub fałsz w zależności czy dane są numeryczne
        /// </returns>
        private bool isNumeric(String data)
        {
            foreach (char c in data)
            {
                if (!Char.IsDigit(c))
                {

                    string message = "Wprowadzono litery!";
                    string caption = "Error Detected in Input";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;

                    // Displays the MessageBox.
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        balanceTextBox.Text = "";
                        return false;
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// Funkcja wyświetlająca potweirdzenie
        /// </summary>
        private void confirmationFunc(Label label)
        {
            label.Show();
            var t = new Timer();
            t.Interval = 1500; // 1,5 sekundy
            t.Tick += (s, e) =>
            {
                label.Hide();
                t.Stop();
            };
            t.Start();

        }
        /// <summary>
        /// Funkcja ładujące dane
        /// </summary>
        private void loadDataButton_Click(object sender, EventArgs e)
        {
            accountStructAll user=AccountsInformation.getAllData(Connection.getInfo((String)comboBoxUsers.Text)); //trzeba sprawdzić czy działa
            nameTextBox.Text = user.name;
            surnameTextBox.Text = user.surname;
            loginTextBox.Text = user.login;
            passwordTextBox.Text = user.password;
            balanceTextBox.Text = user.balance.ToString();
        }
        /// <summary>
        /// Funkcja edytująca dane klienta
        /// </summary>
        private void editDataButton_Click(object sender, EventArgs e)
        {
            String amount = balanceTextBox.Text;
            if (!isNumeric(amount))
            { 
                return;
            }
            accountStructAll user;
            user.name = nameTextBox.Text;//imie użytkownika
            user.surname = surnameTextBox.Text;//nazwisko użytkownika
            user.login = loginTextBox.Text;//login użytkownika
            user.password = passwordTextBox.Text;//hasło użytkownika
            user.balance = Int32.Parse(balanceTextBox.Text);//saldo
            //na razie zróbmy usuwanie wpisu i dodawanie nowego na jego miejsce
            if (Connection.deleteAccount(loginTextBox.Text) == 1) //zmein
            {
                confirmationFunc(confirmationLabel);
                clearTextboxes();
            }
            else
            {
                confirmationFunc(errorLabel);
                clearTextboxes();

            }
          

            if (Connection.editAccount(comboBoxUsers.Text,user.login,user.password, user.name, user.surname, user.balance) == 1)
            {
                confirmationFunc(confirmationLabel);
                clearTextboxes();
            }
            else
            {
                confirmationFunc(errorLabel);
                clearTextboxes();

            }



        }
    }
}
