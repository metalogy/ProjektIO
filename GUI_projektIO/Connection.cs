using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;

namespace GUI_projektIO
{
    class connection
    {
        public static TcpClient client = new TcpClient("127.0.0.1", 3000);
        public static int sendLoginCredentials(String login, String password)
        {
            NetworkStream stream = connection.client.GetStream();
            String credentials = String.Format("1:{0}:{1}:", login, password); //login 1 szą operacją
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(credentials);
            stream.Write(data, 0, data.Length);
            Console.WriteLine("Send credentials");
            data = new Byte[256];
            Int32 bytes = stream.Read(data, 0, data.Length);
            int responseData = Int32.Parse(System.Text.Encoding.ASCII.GetString(data, 0, bytes));
            return responseData;
        }
        public static int checkBalance()
        {
            NetworkStream stream = connection.client.GetStream();
            String credentials = String.Format("2:"); //sprawdzenie stanu konta
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(credentials);
            stream.Write(data, 0, data.Length);
            Console.WriteLine("Send balance check request");
            data = new Byte[256];
            Int32 bytes = stream.Read(data, 0, data.Length);
            int responseData = Int32.Parse(System.Text.Encoding.ASCII.GetString(data, 0, bytes));
            return responseData;
        }
        public static int cashOut(int amount)
        {
            NetworkStream stream = connection.client.GetStream();
            String credentials = String.Format("3:{0}", amount); //3:wypłata
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(credentials);
            stream.Write(data, 0, data.Length);
            Console.WriteLine("Send cash out request");
            data = new Byte[256];
            Int32 bytes = stream.Read(data, 0, data.Length);
            int responseData = Int32.Parse(System.Text.Encoding.ASCII.GetString(data, 0, bytes));
            return responseData;

        }
        public static int cashIn(int amount)
        {
            NetworkStream stream = connection.client.GetStream();
            String credentials = String.Format("4:{0}", amount); //4:wpłata
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(credentials);
            stream.Write(data, 0, data.Length);
            Console.WriteLine("Send cash in request");
            data = new Byte[256];
            Int32 bytes = stream.Read(data, 0, data.Length);
            int responseData = Int32.Parse(System.Text.Encoding.ASCII.GetString(data, 0, bytes));
            return responseData;

        }
        public static int sendCash(int accountID,int amount)
        {
            NetworkStream stream = connection.client.GetStream();
            String credentials = String.Format("5:{0}:{1}", accountID, amount); //5-transfer na inne konto 5:konto:suma
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(credentials);
            stream.Write(data, 0, data.Length);
            Console.WriteLine("Send cash transfer");
            data = new Byte[256];
            Int32 bytes = stream.Read(data, 0, data.Length);
            int responseData = Int32.Parse(System.Text.Encoding.ASCII.GetString(data, 0, bytes));
            return responseData;

        }
        public static String downloadAccounts()
        {
            NetworkStream stream = connection.client.GetStream();
            String credentials = String.Format("6:"); //6-Żądanie pobrania listy użytkowników kont 
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(credentials);
            stream.Write(data, 0, data.Length);
            Console.WriteLine("Send user list request"); /// id i nazwy użytkowników oddzielamy *
            data = new Byte[256];
            Int32 bytes = stream.Read(data, 0, data.Length);
            String responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            return responseData;

        }


    }
}
