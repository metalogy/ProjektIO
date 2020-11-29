using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Serwer
{
    class CommunicationSupport
    {
        //private static DataBase _db = new DataBase();
        private string login;
        public string AnalysingCommunicate(string communicate)
        {
            string feedback;
            string[] components = communicate.Split(':');
            switch (components[0])
            {
                case "1":
                    if(ServerEchoAPM.db.CheckPassword(components[1], components[2]))
                    {
                        feedback = "1";
                        this.login = components[1];
                        return feedback;
                    }
                    else
                    {
                        feedback = "0";
                        return feedback;
                    }
                case "2":
                    feedback = ServerEchoAPM.db.ReadBalance(this.login).ToString();
                    return feedback;
                case "3":
                    ServerEchoAPM.db.EditBalance(this.login, (-1*Int32.Parse(components[1])));
                    feedback = "1";
                    return feedback;
                case "4":
                    ServerEchoAPM.db.EditBalance(this.login, (1 * Int32.Parse(components[1])));
                    feedback = "1";
                    return feedback;
                default:
                    feedback = "Error";
                    return feedback;
            }
        }

    }
}
