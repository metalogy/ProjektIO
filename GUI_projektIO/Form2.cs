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
    public partial class Form2 : Form
    {
        protected String name;
        protected String surname;
        protected int accBalance;
       
        public Form2()
        {

            //trza pobrać imię i nazwisko z banku
            name = "TESTOWY";
            InitializeComponent();
            helloLabel.Text = String.Format("Witaj w Banku {0}", name);
            moneyText.Hide(); //ukrywamy pole to wpisywania pieniędzy
            actionOutButton.Hide();//i przycisk od akcji
            actionInButton.Hide();
            confirmation.Hide(); //i potwierdzenie
            this.accBalance = 777;//testowe


        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void check_Click(object sender, EventArgs e)
        {
            checkBalance();            
        }

        private void cashOut_Click(object sender, EventArgs e)
        {
            textLabel1.Hide();
            cashIn.Hide();
            cashOut.Hide();
            check.Hide();
            balance.Hide();
            moneyText.Show();
            actionOutButton.Show();


        }

        private void actionOutButton_Click(object sender, EventArgs e)
        {
            int m = Int32.Parse(moneyText.Text);
            this.accBalance =accBalance-m;
            confirmation.Text = String.Format("Pomyślnie wypłacono pieniądze");
            confirmation.Show();
            checkBalance();
            textLabel1.Show();
            cashIn.Show();
            cashOut.Show();
            check.Show();
            balance.Show();
            moneyText.Hide(); 
            actionOutButton.Hide();

        }
        private void actionInButton_Click(object sender, EventArgs e)
        {
        }

        private void moneyText_TextChanged(object sender, EventArgs e)
        {

        }

        private void cashInButton_Click(object sender, EventArgs e)
        {

        }
        private void checkBalance()
        {
            balance.Text = String.Format("Stan twojego konta w banku wynosi {0}$", accBalance);
        }

        private void cashIn_Click(object sender, EventArgs e)
        {
            textLabel1.Hide();
            cashIn.Hide();
            cashOut.Hide();
            check.Hide();
            balance.Hide();
            moneyText.Show();
            actionInButton.Show();
        }

        private void actionInButton_Click_1(object sender, EventArgs e)
        {

            int m = Int32.Parse(moneyText.Text);
            this.accBalance = accBalance + m;
            confirmation.Text = String.Format("Pomyślnie wpłacono pieniądze");
            confirmation.Show();
            checkBalance();
            textLabel1.Show();
            cashIn.Show();
            cashOut.Show();
            check.Show();
            balance.Show();
            moneyText.Hide();
            actionInButton.Hide();

        }
    }
}
