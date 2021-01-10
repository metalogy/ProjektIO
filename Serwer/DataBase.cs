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
        /// <summary>
        /// Słownik zawierający pola: key->login, value->hasło
        /// </summary>
        public Dictionary<string, string> dict = new Dictionary<string, string>();
        /// <summary>
        /// Słownik zawierający pola: key-key->login, key-value->imię, value-key->nazwisko, value-value->saldo
        /// </summary>
        public Dictionary<KeyValuePair<string, string>, KeyValuePair<string, int>> datas = new Dictionary<KeyValuePair<string, string>, KeyValuePair<string, int>>();
        #endregion

        #region MetodyKlasy

        /// <summary>
        /// Funkcja zczytująca informacje z bazy danych oraz dodająca poszczególne obiekty do słownika.
        /// </summary>
        public void ReadDataBase()
        {
            KeyValuePair<string, string> temp1;
            KeyValuePair<string, int> temp2;
            int counter = 0;
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(@"../../../Serwer/database.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(' ');
                dict.Add(words[0], words[1]);
                counter++;
            }
            file.Close();
            file = new System.IO.StreamReader(@"../../../Serwer/database_data.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(' ');
                temp1 = new KeyValuePair<string, string>(words[0], words[1]);
                temp2 = new KeyValuePair<string, int>(words[2], Int32.Parse(words[3]));
                datas.Add(temp1, temp2);
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
                    line = i.Key + " " + i.Value;
                    writer.WriteLine(line);
                }
            using (StreamWriter writer = new StreamWriter(@"../../../Serwer/database_data.txt"))
                foreach (var i in datas)
                {
                    line = i.Key.Key + " " + i.Key.Value + " " + i.Value.Key + " " + i.Value.Value;
                    writer.WriteLine(line);
                }
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
                    if (i.Value == password)
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
        /// <param name="fname">Imie klienta.</param>
        ///  /// <param name="lname">Nazwisko klienta.</param>

        public void AddEntry(string fname, string lname, string login, string password)
        {
            KeyValuePair<string, string> temp1 = new KeyValuePair<string, string>(login, fname);
            KeyValuePair<string, int> temp2 = new KeyValuePair<string, int>(lname, 0);
            dict.Add(login, password);
            datas.Add(temp1, temp2);
        }

            /// <summary>
            /// Funkcja cofająca przypisanie hasła i stanu konta do klienta o danym loginie.
            /// </summary>
            /// <param name="login">Login klienta.</param>
            public void DeleteEntry(string login)
        {
            string temp = "";
            KeyValuePair<string, string> temp2 = new KeyValuePair<string, string>("", "");

            foreach (var i in dict)
                if (i.Key == login)
                    temp = i.Key;
            dict.Remove(temp);
            foreach (var i in datas)
                if (i.Key.Key == login)
                    temp2 = new KeyValuePair<string, string>(i.Key.Key, i.Key.Value);
            datas.Remove(temp2);
        }

        /// <summary>
        /// Funkcja odejmująca/dodająca fundusze od stanu konta klienta.
        /// </summary>
        /// <param name="login">Login klienta.</param>
        /// <param name="money">Liczba pieniędzy zabieranych/doddawanych.</param>
        /// <returns>Wartość logiczna true, jeżeli operacja przebiegnie pomyślnie.</returns>
        public bool AddBalance(string login, int money)
        {
            foreach (var i in datas)
                if (i.Key.Key == login)
                {
                    KeyValuePair<string, int> temp = new KeyValuePair<string, int>(i.Value.Key, i.Value.Value + money);
                    datas[i.Key] = temp;
                    return true;
                }
            return false;

        }

        /// <summary>
        /// Funkcja edytująca stan konta klienta.
        /// </summary>
        /// <param name="login">Login klienta.</param>
        /// <param name="money">Liczba pieniędzy .</param>
        /// <returns>Wartość logiczna true, jeżeli operacja przebiegnie pomyślnie.</returns>
        public bool EditBalance(string login, int money)
        {
            foreach (var i in datas)
                if (i.Key.Key == login)
                {
                    KeyValuePair<string, int> temp = new KeyValuePair<string, int>(i.Value.Key, money);
                    datas[i.Key] = temp;
                    return true;
                }
            return false;

        }

        /// <summary>
        /// Funkcja edytująca imię klienta.
        /// </summary>
        /// <param name="login">Login klienta.</param>
        /// <param name="fname">Imię klienta.</param>
        /// <returns>Wartość logiczna true, jeżeli operacja przebiegnie pomyślnie.</returns>
        public bool EditFName(string login, string fname)
        {
            bool done = false;
            string tlogin = "";
            string tlname = "";
            int tbalance = 0;
            KeyValuePair<string, string> temp = new KeyValuePair<string, string>("Null", "Null");
            KeyValuePair<string, int> temp2;
            foreach (var i in datas)
                if (i.Key.Key == login)
                {
                    tlogin = i.Key.Key;
                    tlname = i.Value.Key;
                    tbalance = i.Value.Value;
                    done = true;
                    temp = new KeyValuePair<string, string>(i.Key.Key, i.Key.Value);
                    break;
                }
            if (done)
            {
                datas.Remove(temp);
                temp = new KeyValuePair<string, string>(tlogin, fname);
                temp2 = new KeyValuePair<string, int>(tlname, tbalance);
                datas.Add(temp, temp2);
                return true;
            }
            return false;

        }

        /// <summary>
        /// Funkcja edytująca nazwisko klienta.
        /// </summary>
        /// <param name="login">Login klienta.</param>
        /// <param name="lname">Nazwisko klienta.</param>
        /// <returns>Wartość logiczna true, jeżeli operacja przebiegnie pomyślnie.</returns>
        public bool EditLName(string login, string lname)
        {
            foreach (var i in datas)
                if (i.Key.Key == login)
                {
                    KeyValuePair<string, int> temp = new KeyValuePair<string, int>(lname, i.Value.Value);
                    datas[i.Key] = temp;
                    return true;
                }
            return false;

        }

        /// <summary>
        /// Funkcja edytująca hasło klienta.
        /// </summary>
        /// <param name="login">Login klienta.</param>
        /// <param name="fname">Hasło klienta.</param>
        /// <returns>Wartość logiczna true, jeżeli operacja przebiegnie pomyślnie.</returns>
        public bool EditPassword(string login, string password)
        {
            foreach (var i in dict)
                if (i.Key == login)
                {
                    dict[i.Key] = password;
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
            foreach (var i in datas)
                if (i.Key.Key == login)
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
            if (ReadBalance(giver) >= amount)
                if (AddBalance(giver, -amount))
                {
                    if (AddBalance(receiver, amount))
                    {
                        return true;
                    }
                    else
                    {
                        AddBalance(giver, amount);
                    }
                }
            return false;
        }

        /// <summary>
        /// Funkcja odpowiedzialna za pobranie listy użytkowników
        /// </summary> 
        /// <returns>String zawierający listę kont oddzielonych :</returns>
        public String downloadAccounts()
        {
            String list = "";
            foreach (var i in dict)
            {
                if (i.Equals(dict.Values.Last()))
                {
                    list += i.Key;
                }
                else

                {
                    list += i.Key + ":";
                }

            }
            return list;

        }
        /// <summary>
        /// Funkcja sprawdzająca poprawność loginu i hasła.
        /// </summary>
        /// <param name="login">Potencjalny login klienta.</param>
        /// <param name="password">Potecjalne hasło klienta.</param>
        /// <returns>Wartość true jeżeli dany klient istnieje.</returns>
        public bool adminLogin(string login, string password)
        {
            if (login == "admin")
            {
                foreach (var i in dict)
                {
                    if (i.Key == login)
                    {
                        if (i.Value == password)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    }
                }
                return false;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// Procedura zmieniające dane użytkownika
        /// </summary> 
        /// <param name="tlogin">Stary login klienta</param>
        /// <param name="login">Nowy login klienta</param>
        /// <param name="password">Nowe hasło klienta</param>
        /// <param name="fname">Nowe imię klienta</param>
        /// <param name="lname">Nowe nazwisko klienta</param>
        /// <param name="balance">Nowe saldo klienta</param>
        /// <returns>String zawierający dane użytkownika :</returns>
        public void ChangeUserData(string tlogin, string login, string password, string fname, string lname, int balance)
        {
            KeyValuePair<string, string> temp = new KeyValuePair<string, string>("", "");
            foreach (var i in datas)
                if (i.Key.Key == tlogin)
                {
                    temp = new KeyValuePair<string, string>(tlogin, i.Key.Value);
                }
            dict.Remove(tlogin);
            datas.Remove(temp);
            dict.Add(login, password);
            temp = new KeyValuePair<string, string>(login, fname);
            KeyValuePair<string, int> temp2 = new KeyValuePair<string, int>(lname, balance);
            datas.Add(temp, temp2);
        }


        /// <summary>
        /// Funkcja odpowiedzialna za pobranie danych użytkownika
        /// </summary> 
        /// <param name="login">Login klienta</param>
        /// <returns>String zawierający dane użytkownika :</returns>
        public String downloadDatas(string login)
        {
            String list = "";
            foreach (var i in dict)
            {
                if (i.Key == login)
                {
                    list += i.Key + ":" + i.Value+":";
                }
            }
            foreach (var i in datas)
            {
                if (i.Key.Key == login)
                {
                    list += i.Key.Value + ":" + i.Value.Key + ":" + i.Value.Value;
                }
            }
            return list;

        }

        #endregion
    }
}
