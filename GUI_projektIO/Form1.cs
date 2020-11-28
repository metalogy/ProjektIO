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
    public partial class Form1 : Form
    {
        private String login;
        private String password;

        public Form1()
        {
            InitializeComponent();
            loginText.Hide();
            loginText.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            login = loginText.Text;
            password = passwordText.Text;
            //tutaj łączenie się z bazą danych i logowanie
            var form2 = new Form2();
            form2.Show();
            //this.Hide;
            //Close();
            Hide(); //zamknięcie zamiast ukrycia??"?


        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
