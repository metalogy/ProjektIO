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
    public partial class MoneyOutWindow : Form
    {
        public MoneyOutWindow()
        {
            InitializeComponent();
        }

        private void actionOutButton_Click(object sender, EventArgs e)
        {
            int m = Int32.Parse(moneyText.Text);
            if (Connection.cashOut(m) == 1)
            {
                var MainMenuForm = new MainMenuForm("Pomyślnie wypłacono pieniądze");
                Console.WriteLine("Pomyślnie wypłacono pieniądze");
                this.Close();
                MainMenuForm.Show();

            }
            else
            {
                var MainMenuForm = new MainMenuForm("Błąd wypłaty");
                Console.WriteLine("Błąd wypłaty");
                this.Close();
                MainMenuForm.Show();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Connection.client.Close();
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            var MainMenuForm = new MainMenuForm();
            this.Close();
            MainMenuForm.Show();
        }
    }
}
