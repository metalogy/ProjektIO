using System;

using System.Collections.Generic;

using System.IO;

using System.Linq;

using System.Net;

using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
using System.Text;



namespace Serwer

{

    public  class ServerEchoAPM : ServerEcho

    {
        /// <summary>
        /// zmienne do komunikatów
        /// </summary>
        static string passwd = "maslo";
        static string message = "Witaj na serwerze, podaj haslo \n\r";
        static string message2 = "Brawo, haslo to maslo. Zamykanie polaczenia \n\r";
        static string message3 = "Zle haslo, wpisz ponownie \n\r";
      
        public delegate void TransmissionDataDelegate(NetworkStream stream);
        protected bool running;


        public ServerEchoAPM(IPAddress IP, int port) : base(IP, port)
        {
           
        }
        

        protected override void AcceptClient()

        {

            while (true)

            {

                TcpClient client = TcpListener.AcceptTcpClient();

                Stream =client.GetStream();

                TransmissionDataDelegate transmissionDelegate = new TransmissionDataDelegate(BeginDataTransmission);

                //callback style

                transmissionDelegate.BeginInvoke(Stream, TransmissionCallback,client);

            }

        }



        private void TransmissionCallback(IAsyncResult ar)

        {
            TcpClient client = (TcpClient)ar.AsyncState;
            client.Close();
            // sprzątanie

        }

        protected override void BeginDataTransmission(NetworkStream stream)

        {

            byte[] buffer = new byte[Buffer_size];
            byte[] msg = Encoding.ASCII.GetBytes(message);
            stream.Write(msg, 0, msg.Length);

            while (true)

                {
                try
                {
                    stream.Read(buffer, 0,Buffer_size); ///odczyt hasla
                    string reply = Encoding.ASCII.GetString(buffer);
                    var reply_letters = new String(reply.Where(Char.IsLetter).ToArray()); /// zamiana bajtów na stringa z samymi literami
                    Array.Clear(buffer, 0, buffer.Length);
                    if (reply_letters == "") continue; ///sprawdzenie czy wiadomosc nie jest /r/n/0/0/0/...
                    if (passwd == reply_letters)
                    {
                        byte[] msg2 = Encoding.ASCII.GetBytes(message2);  ///wiadomość kończąca
                        stream.Write(msg2, 0, msg2.Length);
                        break;

                    }
                    else
                    {
                        
                        byte[] msg3 = Encoding.ASCII.GetBytes(message3);  ///wiadomość kończąca
                        stream.Write(msg3, 0, msg3.Length);
                    }
                }
                catch (IOException e)
                {
                    break;
                }

                }
           

        }
      
        public override void Start()

        {

            StartListening();

            //transmission starts within the accept function

            AcceptClient();


        }


    }

}