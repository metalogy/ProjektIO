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
        List<accountStruct> accounts;
        public transferWindow(List<accountStruct> accounts)
        {
            this.accounts = accounts;
            InitializeComponent();
            foreach(accountStruct user in this.accounts)
            {
                comboBoxUsers.Items.Add(user.name);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Connection.client.Close();
            this.Close();
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            
            int m = Int32.Parse(moneyText.Text);
            String u=comboBoxUsers.Text;  //nie jestem pewien czy działa, może być coś w stylu  int selectedValue = (int)cmb.SelectedValue;
            int id=0;
            foreach(accountStruct user in this.accounts)
            {
                if(user.name==u)
                {
                    id = user.ID;
                    break;
                }
            }  
            if (Connection.sendCash(id,m) == 1)
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
