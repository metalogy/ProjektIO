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
    public partial class AdminPanel : Form
    {
        protected List<accountStruct> accounts;
        
        public AdminPanel()
        {
            InitializeComponent();
            confirmationLabel.Hide();
            errorLabel.Hide();
            // accounts = AccountsInformation.getAccounts(connection.downloadAccounts());
            foreach (accountStruct user in this.accounts)
            {
                comboBoxUsers.Items.Add(user.name);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Connection.client.Close();
            this.Close();
        }

        private void deleteAccount_Click(object sender, EventArgs e)
        {
            if (Connection.deleteAccount(loginTextBox.Text, passwordTextBox.Text) == 1)
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
        private void clearTextboxes()
        {
            nameTextBox.Text=String.Empty;
            surnameTextBox.Text = String.Empty;
            loginTextBox.Text = String.Empty;
            passwordTextBox.Text = String.Empty;
            balanceTextBox.Text = String.Empty;
        }
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

        private void loadDataButton_Click(object sender, EventArgs e)
        {
            accountStructAll user=AccountsInformation.getAllData(Connection.getInfo((String)comboBoxUsers.SelectedValue)); //trzeba sprawdzić czy działa
           //co z id?
            nameTextBox.Text = user.name;
            surnameTextBox.Text = user.surname;
            loginTextBox.Text = user.login;
            passwordTextBox.Text = user.password;
            balanceTextBox.Text = user.balance.ToString();
        }

        private void editDataButton_Click(object sender, EventArgs e)
        {
            accountStructAll user;
            user.ID = 0;//id //co z id????
            user.name = nameTextBox.Text;//imie użytkownika
            user.surname = surnameTextBox.Text;//nazwisko użytkownika
            user.login = loginTextBox.Text;//login użytkownika
            user.password = passwordTextBox.Text;//hasło użytkownika
            user.balance = Int32.Parse(balanceTextBox.Text);//saldo
            //na razie zróbmy usuwanie wpisu i dodawanie nowego na jego miejsce
            if (Connection.deleteAccount(loginTextBox.Text, passwordTextBox.Text) == 1)
            {
                confirmationFunc(confirmationLabel);
                clearTextboxes();
            }
            else
            {
                confirmationFunc(errorLabel);
                clearTextboxes();

            }
          

            if (Connection.createAccount(user.name,user.surname,user.login,user.password,user.balance) == 1)
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
