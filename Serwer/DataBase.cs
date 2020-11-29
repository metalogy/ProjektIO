using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serwer
{
    public class DataBase
    {
        public Dictionary<String, KeyValuePair<string, int>> dict = new Dictionary<string, KeyValuePair<string, int>>();

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

        public void Print()
        {
            foreach (var i in dict)
                Console.WriteLine("Login: {0}, Password: {1}, Balance: {2}", i.Key, i.Value.Key, i.Value.Value);
        }

        public void PrintPerson(string login)
        {
            foreach (var i in dict)
                if (i.Key == login)
                    Console.WriteLine("Login: {0}, Password: {1}, Balance: {2}", i.Key, i.Value.Key, i.Value.Value);
        }
        
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

        public void AddEntry(string login, string password, int balance)
        {
            KeyValuePair<string, int> temp = new KeyValuePair<string, int>(password, balance);
            dict.Add(login, temp);
        }

        public void EditBalance(string login, int money)
        {
            foreach (var i in dict)
                if (i.Key == login)
                {
                    KeyValuePair<string, int> temp = new KeyValuePair<string, int>(i.Value.Key, i.Value.Value + money);
                    dict[i.Key] = temp;
                    break;
                }
        }

        public int ReadBalance(string login)
        {
            foreach (var i in dict)
                if (i.Key == login)
                {
                    return i.Value.Value;
                }
            return 0;
        }

    }
}
