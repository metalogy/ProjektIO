using System.Net;
using Serwer;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)

        {
            
            BankServerAPM server = new BankServerAPM(IPAddress.Parse("127.0.0.1"), 3000);   
            server.Start();

        }
    }
}
