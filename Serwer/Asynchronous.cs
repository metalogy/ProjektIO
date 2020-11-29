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
      
        public delegate void TransmissionDataDelegate(NetworkStream stream);
        protected bool running;

        public static DataBase db = new DataBase();


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
            db.Write2DataBase();
            // sprzątanie

        }

        protected override void BeginDataTransmission(NetworkStream stream)
        {
            CommunicationSupport cs = new CommunicationSupport();
            byte[] buffer = new byte[Buffer_size];


            while (true)
            {
                try
                {
                    stream.Read(buffer, 0,Buffer_size); 
                    string communicate = Encoding.ASCII.GetString(buffer);
                    //var communicate_letters = new String(communicate.Where(Char.IsLetter).ToArray()); /// zamiana bajtów na stringa z samymi literami do sprawdzenia
                    Array.Clear(buffer, 0, buffer.Length);
                    //if (communicate_letters == "") continue; ///sprawdzenie czy wiadomosc nie jest /r/n/0/0/0/...
                    string reply = cs.AnalysingCommunicate(communicate);
                    byte[] msg = Encoding.ASCII.GetBytes(reply);  ///wiadomość zwrotna
                    stream.Write(msg, 0, msg.Length);
                }
                catch (IOException e)
                {
                    break;
                }
            }
           
        }
      
        public override void Start()

        {
            db.ReadDataBase();
            StartListening();

            //transmission starts within the accept function

            AcceptClient();
            

        }


    }

}