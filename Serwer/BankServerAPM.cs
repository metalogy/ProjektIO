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
    /// <summary>
    /// To jest klasa dla serwera bankowego w rozwiązaniu asynchronicznym.
    /// </summary>
    public class BankServerAPM : BankServer

    {
        #region PolaKlasy
        public delegate void TransmissionDataDelegate(NetworkStream stream);
        protected bool running;

        public static DataBase db = new DataBase();
        #endregion

        #region KonstruktoryKlasy
        public BankServerAPM(IPAddress IP, int port) : base(IP, port)
        {
           
        }
        #endregion

        #region MetodyKlasy
        /// <summary>
        /// Funkcja akceptująca różnych klientów. 
        /// </summary>
        protected override void AcceptClient()

        {

            while (true)

            {

                TcpClient client = TcpListener.AcceptTcpClient();

                Stream =client.GetStream();

                TransmissionDataDelegate transmissionDelegate = new TransmissionDataDelegate(BeginDataTransmission);

                transmissionDelegate.BeginInvoke(Stream, TransmissionCallback,client);

            }

        }


        /// <summary>
        /// Funkcja sprzątająca po kliencie. 
        /// </summary>
        private void TransmissionCallback(IAsyncResult ar)
        {
            TcpClient client = (TcpClient)ar.AsyncState;
            client.Close();
            db.Write2DataBase();

        }

        /// <summary>
        /// Funkcja odpowiedzialna za komunikację pomiędzy serwerem, a klientem.
        /// </summary>
        /// <param name="stream">Strumień komunikacjny pomiędzy poszczególnym klientem, a serwerem.</param>
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
                    Array.Clear(buffer, 0, buffer.Length);
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

        /// <summary>
        /// Funkcja rozpoczynająca działanie serwera.
        /// </summary>
        public override void Start()

        {
            db.ReadDataBase();
            StartListening();

            //transmission starts within the accept function

            AcceptClient();
            

        }

        #endregion
    }

}