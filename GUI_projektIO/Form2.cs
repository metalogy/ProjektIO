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
    public partial class Form2 : Form
    {
        protected String name;
        protected String surname;
        protected int accBalance;
       
        public Form2()
        {
            //trza pobrać imię i nazwisko z banku
            
            name = Form1.login;
            InitializeComponent();
            helloLabel.Text = String.Format("Witaj w Banku {0}", name);
            moneyText.Hide(); //ukrywamy pole to wpisywania pieniędzy
            actionOutButton.Hide();//i przycisk od akcji
            actionInButton.Hide();
           //confirmation.Hide(); //i potwierdzenie
            back.Hide();
            this.accBalance = 777;//testowe


            //TESTOWE POŁĄCZENIE CZEŚĆ 2!!!!!!!!
            /*if (connection.client.Connected)
            {
                
                NetworkStream stream = connection.client.GetStream();
                Byte[] data = System.Text.Encoding.ASCII.GetBytes("maslo");
                stream.Write(data, 0, data.Length);
                data = new Byte[256];
                String responseData = String.Empty;
                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                Console.WriteLine("Received: {0}", responseData);
            }*/

        }

        private void exit_Click(object sender, EventArgs e)
        {
            connection.client.Close();
            this.Close();
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
            back.Show();
            moneyText.Show();
            actionOutButton.Show();


        }

        private void actionOutButton_Click(object sender, EventArgs e)
        {
            int m = Int32.Parse(moneyText.Text);
            //this.accBalance =accBalance-m;
            if(connection.cashOut(m)==1)
            {
                Console.WriteLine("Pomyśnie wypłacono");
            }
            else
            {
                Console.WriteLine("Błąd");
            }

            checkBalance();
            operationOutConfrimation();
            textLabel1.Show();
            cashIn.Show();
            cashOut.Show();
            check.Show();
            balance.Show();
            moneyText.Hide(); 
            actionOutButton.Hide();
            back.Hide();

        }

        private void checkBalance()
        {
            this.accBalance = connection.checkBalance();
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
        private void operationInConfrimation()
        {
            confirmation.Text = String.Format("Pomyślnie wpłacono pieniądze");
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
        private void operationOutConfrimation()
        {
            confirmation.Text = String.Format("Pomyślnie wypłacono pieniądze");
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

        private void cashIn_Click(object sender, EventArgs e)
        {
            
            textLabel1.Hide();
            cashIn.Hide();
            cashOut.Hide();
            check.Hide();
            balance.Hide();
            moneyText.Show();
            back.Show();
            actionInButton.Show();
        }

        private void actionInButton_Click_1(object sender, EventArgs e)
        {

            int m = Int32.Parse(moneyText.Text);
            //this.accBalance = accBalance + m;
            if (connection.cashIn(m) == 1)
            {
                Console.WriteLine("Pomyśnie wpłacono");
            }
            else
            {
                Console.WriteLine("Błąd");
            }
            checkBalance();
            textLabel1.Show();
            cashIn.Show();
            cashOut.Show();
            check.Show();
            balance.Show();
            moneyText.Hide();
            actionInButton.Hide();
            back.Hide();
            operationInConfrimation();

        }

        private void back_Click(object sender, EventArgs e)
        {
            back.Hide();
            textLabel1.Show();
            cashIn.Show();
            cashOut.Show();
            check.Show();
            moneyText.Hide();
            actionInButton.Hide();
            actionOutButton.Hide();
        }
    }
}
