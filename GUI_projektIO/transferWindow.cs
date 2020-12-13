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
        List<accountsStruct> accounts;
        public transferWindow(List<accountsStruct> accounts)
        {
            this.accounts = accounts;
            InitializeComponent();
            foreach(accountsStruct user in this.accounts)
            {
                comboBoxUsers.Items.Add(user.name);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            connection.client.Close();
            this.Close();
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            
            int m = Int32.Parse(moneyText.Text);
            String u=comboBoxUsers.Text;
            int id=0;
            foreach(accountsStruct user in this.accounts)
            {
                if(user.name==u)
                {
                    id = user.ID;
                    break;
                }
            }  
            if (connection.sendCash(id,m) == 1)
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
