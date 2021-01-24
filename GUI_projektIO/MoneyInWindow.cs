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
{   /// <summary>
    /// Klasa wpłąty pieniędzy
    /// </summary>
    public partial class MoneyInWindow : Form
    {
        public MoneyInWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Funkcja wpłaty
        /// </summary>
        private void actionInButton_Click(object sender, EventArgs e)
        {
            int m = Int32.Parse(moneyText.Text);
            if (Connection.cashIn(m) == 1)
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
        /// <summary>
        /// Funkcja wyjścia z aplikacji
        /// </summary>
        private void exit_Click(object sender, EventArgs e)
        {
            Connection.client.Close();
            this.Close();
            Environment.Exit(1);
        }
        /// <summary>
        /// Funkcja powrotu do menu głównego
        /// </summary>
        private void back_Click(object sender, EventArgs e)
        {
            var MainMenuForm = new MainMenuForm();
            this.Close();
            MainMenuForm.Show();
        }
    }
}
