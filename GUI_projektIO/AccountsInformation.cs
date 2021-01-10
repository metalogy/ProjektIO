using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_projektIO
{
    /// <summary>
    /// Struktura opisująca dane konto klienckie. 
    /// </summary>
    public struct loginList
    {
        /// <summary>
        /// Nazwa klienta.
        /// </summary>
        public String login;
    }
    public struct accountStructAll
    {
        /// <summary>
        /// Imie klienta.
        /// </summary>
        public String name;
        /// <summary>
        /// Nazwisko klienta.
        /// </summary>
        public String surname;
        /// <summary>
        /// login klienta.
        /// </summary>
        public String login;
        /// <summary>
        /// hasło klienta.
        /// </summary>
        public String password;
        /// <summary>
        /// Saldo klienta.
        /// </summary>
        public int balance;
    }

    /// <summary>
    /// Klasa odpowiedzialna za pobranie informacji o wszystkich klientach występujących w bazie danych. 
    /// </summary>
    class AccountsInformation
    {
        /// <summary>
        /// Funkcja pobierająca informację o wszystkich kontach. 
        /// </summary>
        /// <param name="data">Parametr zawierający ciąg z informacjami o wszystkich kontach w odpowiednim formacie.</param>
        /// <returns>Lista obiektów accountStruct.</returns>
        public static List<loginList> getAccounts(String data)
        {
            List<loginList> accounts = new List<loginList>();
            String[] users = data.Split(':');
            
            for(int i=0;i<users.Length-1;i++)
            {
                loginList helper = new loginList();
                helper.login =users[i];//login
                accounts.Add(helper);

            }
            return accounts;

        }
        public static accountStructAll getAllData(String data)
        {
            /// <summary>
            /// Funkcja pobierająca informację o koncie 
            /// </summary>
            /// <param name="data">Parametr zawierający ciąg z informacjami o wszystkich kontach w odpowiednim formacie.</param>
            /// <returns>Lista obiektów accountStruct.</returns>

            accountStructAll user;
            String[] organiser = data.Split(':');
            user.name = organiser[2];//imie użytkownika
            user.surname = organiser[3];//nazwisko użytkownika
            user.login = organiser[0];//login użytkownika 
            user.password = organiser[1];//hasło użytkownika
            user.balance = Int32.Parse(organiser[4]);//saldo
            return user;

        }
      
    }
}
