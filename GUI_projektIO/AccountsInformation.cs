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
    public struct accountStruct
    {
        /// <summary>
        /// ID klienta.
        /// </summary>
        public int ID;
        /// <summary>
        /// Nazwa klienta.
        /// </summary>
        public String name;
    }
    public struct accountStructAll
    {
        /// <summary>
        /// ID klienta.
        /// </summary>
        public int ID;
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
        public static List<accountStruct> getAccounts(String data)
        {
            List<accountStruct> accounts = new List<accountStruct>();
            String[] users= data.Split('*');
            accountStruct helper;
            foreach (String user in users)
            {
                String[] organiser = user.Split(':');
                helper.ID = Int32.Parse(organiser[0]);//id
                helper.name = organiser[1];//nazwa użytkownika
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
            user.ID = Int32.Parse(organiser[0]);//id
            user.name = organiser[1];//imie użytkownika
            user.surname = organiser[2];//nazwisko użytkownika
            user.login = organiser[3];//login użytkownika
            user.password = organiser[4];//hasło użytkownika
            user.balance = Int32.Parse(organiser[5]);//saldo
            return user;

        }
      
    }
}
