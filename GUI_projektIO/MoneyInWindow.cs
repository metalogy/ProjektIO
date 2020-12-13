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
    public partial class MoneyInWindow : Form
    {
        public MoneyInWindow()
        {
            InitializeComponent();
        }

        private void actionInButton_Click(object sender, EventArgs e)
        {
            int m = Int32.Parse(moneyText.Text);
            if (Connection.cashOut(m) == 1)
            {
                var MainMenuForm = new MainMenuForm("Pomyślnie wpłacono pieniądze");
                Console.WriteLine("Pomyślnie wpłacono pieniądze");
                this.Close();
                MainMenuForm.Show();

            }
            else
            {
                var MainMenuForm = new MainMenuForm("Błąd wpłaty");
                Console.WriteLine("Błąd wpłaty");
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
