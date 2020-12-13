﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;

namespace GUI_projektIO
{
    /// <summary>
    /// Klasa, która odpowiada za połączenie pomiędzy jednym klientem, a serwerem.
    /// </summary>
    class Connection
    {
        #region PolaKlasy
        /// <summary>
        /// Zmienna statyczna definiująca klienta. 
        /// </summary>
        public static TcpClient client = new TcpClient("127.0.0.1", 3000);
        #endregion

        #region MetodyKlasy
        /// <summary>
        /// Funkcja wysyłająca wiadomość z loginem i hasłem do serwera oraz zczytująca wiadomość od serwera o poprawności podanych danych.
        /// </summary>
        /// <param name="login">Login podany przez klienta.</param>
        /// <param name="password">Hasło podane przez klienta</param>
        /// <returns>Wartość określająca poprawność (0-1).</returns>
        public static int sendLoginCredentials(String login, String password)
        {
            NetworkStream stream = Connection.client.GetStream();
            String credentials = String.Format("1:{0}:{1}:", login, password); //login 1 szą operacją
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(credentials);
            stream.Write(data, 0, data.Length);
            Console.WriteLine("Send credentials");
            data = new Byte[256];
            Int32 bytes = stream.Read(data, 0, data.Length);
            int responseData = Int32.Parse(System.Text.Encoding.ASCII.GetString(data, 0, bytes));
            return responseData;
        }

        /// <summary>
        /// Funkcja sprawdzająca stan konta danego klienta.
        /// </summary>
        /// <returns>Stan konta klienta.</returns>
        public static int checkBalance()
        {
            NetworkStream stream = Connection.client.GetStream();
            String credentials = String.Format("2:"); //sprawdzenie stanu konta
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(credentials);
            stream.Write(data, 0, data.Length);
            Console.WriteLine("Send balance check request");
            data = new Byte[256];
            Int32 bytes = stream.Read(data, 0, data.Length);
            int responseData = Int32.Parse(System.Text.Encoding.ASCII.GetString(data, 0, bytes));
            return responseData;
        }

        /// <summary>
        /// Funkcja odpowiedzialna za wypłacanie pieniędzy z konta danego klienta.
        /// </summary>
        /// <param name="amount">Liczba pieniędzy do wypłacenia.</param>
        /// <returns>Wartość określająca poprawność (0-1).</returns>
        public static int cashOut(int amount)
        {
            NetworkStream stream = Connection.client.GetStream();
            String credentials = String.Format("3:{0}", amount); //3:wypłata
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(credentials);
            stream.Write(data, 0, data.Length);
            Console.WriteLine("Send cash out request");
            data = new Byte[256];
            Int32 bytes = stream.Read(data, 0, data.Length);
            int responseData = Int32.Parse(System.Text.Encoding.ASCII.GetString(data, 0, bytes));
            return responseData;

        }

        /// <summary>
        /// Funkcja odpowiedzialna za wpłacanie pieniędzy na konto danego klienta.
        /// </summary>
        /// <param name="amount">Liczba pieniędzy do wpłacenia.</param>
        /// <returns>Wartość określająca poprawność (0-1).</returns>
        public static int cashIn(int amount)
        {
            NetworkStream stream = Connection.client.GetStream();
            String credentials = String.Format("4:{0}", amount); //4:wpłata
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(credentials);
            stream.Write(data, 0, data.Length);
            Console.WriteLine("Send cash in request");
            data = new Byte[256];
            Int32 bytes = stream.Read(data, 0, data.Length);
            int responseData = Int32.Parse(System.Text.Encoding.ASCII.GetString(data, 0, bytes));
            return responseData;

        }

        /// <summary>
        /// Funkcja odpowiedzialna operację przelewu pomiędzy dwoma klientami.
        /// </summary>
        /// <param name="amount">Liczba pieniędzy do przelania.</param>
        /// <param name="accountID">Liczba określająca adresata przelewu.</param>
        /// <returns>Wartość określająca poprawność (0-1).</returns>
        public static int sendCash(int accountID,int amount)
        {
            NetworkStream stream = Connection.client.GetStream();
            String credentials = String.Format("5:{0}:{1}", accountID, amount); //5-transfer na inne konto 5:konto:suma
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(credentials);
            stream.Write(data, 0, data.Length);
            Console.WriteLine("Send cash transfer");
            data = new Byte[256];
            Int32 bytes = stream.Read(data, 0, data.Length);
            int responseData = Int32.Parse(System.Text.Encoding.ASCII.GetString(data, 0, bytes));
            return responseData;

        }

        /// <summary>
        /// Funkcja zwracająca ciąg nazw wszystkich kont.
        /// </summary>
        /// <returns>Lista z nazwami identyfikującymi wszystkich kont. </returns>
        public static String downloadAccounts()
        {
            NetworkStream stream = Connection.client.GetStream();
            String credentials = String.Format("6:"); //6-Żądanie pobrania listy użytkowników kont 
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(credentials);
            stream.Write(data, 0, data.Length);
            Console.WriteLine("Send user list request"); /// id i nazwy użytkowników oddzielamy *
            data = new Byte[256];
            Int32 bytes = stream.Read(data, 0, data.Length);
            String responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            return responseData;

        }
        #endregion


    }
}
