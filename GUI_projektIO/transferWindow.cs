﻿using System;
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
                var form2 = new Form2("Pomyślnie przelano pieniądze"); 
                form2.Show();
                Console.WriteLine("Pomyśnie przelano");
                this.Close();
                
            }
            else
            {
                var form2 = new Form2("Błąd przelewu");
                Console.WriteLine("Błąd przelewu");
                this.Close();
                form2.Show();
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            this.Close();
            form2.Show();
        }
    }
}
