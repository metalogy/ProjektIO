using System.Net;
using Serwer;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)

        {
            
            ServerEchoAPM server = new ServerEchoAPM(IPAddress.Parse("127.0.0.1"), 3000);   
            server.Start();

        }
    }
}
