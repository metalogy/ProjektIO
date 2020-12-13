using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serwer
{
    /// <summary>
    /// To jest klasa odpowiedzialna za obsługiwanie bazy danych.
    /// </summary>
    public class DataBase
    {
        #region PolaKlasy
        public Dictionary<String, KeyValuePair<string, int>> dict = new Dictionary<string, KeyValuePair<string, int>>();
        #endregion

        #region MetodyKlasy

        /// <summary>
        /// Funkcja zczytująca informacje z bazy danych oraz dodająca poszczególne obiekty do słownika.
        /// </summary>
        public void ReadDataBase()
        {
            KeyValuePair<string, int> temp;
            int counter = 0;
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(@"../../../Serwer/database.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(' ');
                temp = new KeyValuePair<string, int>(words[1], Int32.Parse(words[2]));
                dict.Add(words[0], temp);
                counter++;
            }
            file.Close();
        }


        /// <summary>
        /// Funkcja zapisująca aktualny stan słownika do bazy danych.
        /// </summary>
        public void Write2DataBase()
        {
            string line;
            using (StreamWriter writer = new StreamWriter(@"../../../Serwer/database.txt"))
                foreach (var i in dict)
                {
                    line = i.Key + " " + i.Value.Key + " " + i.Value.Value;
                    writer.WriteLine(line);
                }
        }

        /// <summary>
        /// Funkcja wyświetlająca listę klientów. 
        /// </summary>
        public void Print()
        {
            foreach (var i in dict)
                Console.WriteLine("Login: {0}, Password: {1}, Balance: {2}", i.Key, i.Value.Key, i.Value.Value);
        }

        /// <summary>
        /// Funkcja wyświetlająca informacje o danym kliencie.
        /// </summary>
        /// <param name="login">Login klienta.</param>
        public void PrintPerson(string login)
        {
            foreach (var i in dict)
                if (i.Key == login)
                    Console.WriteLine("Login: {0}, Password: {1}, Balance: {2}", i.Key, i.Value.Key, i.Value.Value);
        }

        /// <summary>
        /// Funkcja sprawdzająca poprawność loginu i hasła.
        /// </summary>
        /// <param name="login">Potencjalny login klienta.</param>
        /// <param name="password">Potecjalne hasło klienta.</param>
        /// <returns>Wartość true jeżeli dany klient istnieje.</returns>
        public bool CheckPassword(string login, string password)
        {
            foreach (var i in dict)
                if (i.Key == login)
                    if (i.Value.Key == password)
                    {
                        return true;
                    }
            return false;
        }

        /// <summary>
        /// Funkcja przypisujaca hasło i stan konta do klienta o danym loginie.
        /// </summary>
        /// <param name="login">Login klienta.</param>
        /// <param name="password">Hasło klienta.</param>
        /// <param name="balance">Stan konta klienta.</param>
        public void AddEntry(string login, string password, int balance)
        {
            KeyValuePair<string, int> temp = new KeyValuePair<string, int>(password, balance);
            dict.Add(login, temp);
        }

        /// <summary>
        /// Funkcja cofająca przypisanie hasła i stanu konta do klienta o danym loginie.
        /// </summary>
        /// <param name="login">Login klienta.</param>
        public void DeleteEntry(string login)
        {

            foreach (var i in dict)
                if (i.Key == login)
                {
                    dict.Remove(login);
                }
        }

        /// <summary>
        /// Funkcja edytująca stan konta klienta.
        /// </summary>
        /// <param name="login">Login klienta.</param>
        /// <param name="money">Liczba pieniędzy zabieranych/doddawanych.</param>
        /// <returns>Wartość logiczna true, jeżeli operacja przebiegnie pomyślnie.</returns>
        public bool EditBalance(string login, int money)
        {
            foreach (var i in dict)
                if (i.Key == login)
                {
                    KeyValuePair<string, int> temp = new KeyValuePair<string, int>(i.Value.Key, i.Value.Value + money);
                    dict[i.Key] = temp;
                    return true;
                }
            return false;

        }

        /// <summary>
        /// Funkcja odczytująca stan konta klienta.
        /// </summary>
        /// <param name="login">Login klienta.</param>
        /// <returns>Wartość liczbowa odpowiadająca stanowi konta.</returns>
        public int ReadBalance(string login)
        {
            foreach (var i in dict)
                if (i.Key == login)
                {
                    return i.Value.Value;
                }
            Console.WriteLine("Error! No such login");
            return 0;
        }

        /// <summary>
        /// Funkcja odpowiedzialna za transfer pieniędzy pomiędzy dwoma klientami.
        /// </summary>
        /// <param name="amount">Liczba przelewanych pieniędzy</param>
        /// <param name="giver">Login osoby przelewającej pieniądze.</param>
        /// <param name="receiver">Login odbiorcy przelewu.</param>
        /// <returns>Wartość logiczna true, jeżeli operacja przebiegnie pomyślnie</returns>
        public bool TransferMoney(string giver, string receiver, int amount)
        {
            if (EditBalance(giver, -amount))
            {
                if (EditBalance(receiver, amount))
                {
                    return true;
                }
                else
                {
                    EditBalance(giver, amount);
                }
            }
            return false;
        }
        #endregion
    }
}
