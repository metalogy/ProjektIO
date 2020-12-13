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
    }
}
