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
    public partial class transferWindow: Form
    {
        List<loginList> accounts;
        public transferWindow()
        {
            accounts = AccountsInformation.getAccounts(Connection.downloadAccounts()); //pobieranie listy loginów do przelewu
            InitializeComponent();
            foreach(loginList user in this.accounts)
            {
                comboBoxUsers.Items.Add(user.login);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Connection.client.Close();
            this.Close();
            Environment.Exit(1);

        }
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
                        moneyTextBox.Text = "";
                        return false;
                    }
                }
            }
            return true;
        }
        private void transferButton_Click(object sender, EventArgs e)
        {
            String amount = moneyTextBox.Text;
            if(!isNumeric(amount))
            {
                return;
            }
            
            int m = Int32.Parse(moneyTextBox.Text);
            String user=comboBoxUsers.Text;  

            if (Connection.sendCash(user,m) == 1)
            {
                var MainMenuForm = new MainMenuForm("Pomyślnie przelano pieniądze");
                MainMenuForm.Show();
                Console.WriteLine("Pomyśnie przelano");
                this.Close();
                
            }
            else
            {
                var MainMenuForm = new MainMenuForm("Błąd przelewu");
                Console.WriteLine("Błąd przelewu");
                this.Close();
                MainMenuForm.Show();
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            var MainMenuForm = new MainMenuForm();
            this.Close();
            MainMenuForm.Show();
        }
    }
}
