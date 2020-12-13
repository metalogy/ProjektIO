using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Serwer
{
    /// <summary>
    /// To jest klasa odpowiedzialna za analizę komunikatów.
    /// </summary>
    class CommunicationSupport
    {
        #region PolaKlasy
        private string login;
        #endregion

        #region MetodyKlasy

        /// <summary>
        /// Funkcja analizująca dany ciąg znaków.
        /// </summary>
        /// <param name="stream">Ciąg znaków reprezentujący dany komunikat.</param>
        /// <returns>Ciąg znaków będący odpowiedzią na komunikat. </returns>
        public string AnalysingCommunicate(string communicate)
        {
            string feedback;
            string[] components = communicate.Split(':');
            switch (components[0])
            {
                case "1":
                    if(BankServerAPM.db.CheckPassword(components[1], components[2]))
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
                    feedback = BankServerAPM.db.ReadBalance(this.login).ToString();
                    return feedback;
                case "3":
                    BankServerAPM.db.EditBalance(this.login, (-1*Int32.Parse(components[1])));
                    feedback = "1";
                    return feedback;
                case "4":
                    BankServerAPM.db.EditBalance(this.login, (1 * Int32.Parse(components[1])));
                    feedback = "1";
                    return feedback;
                default:
                    feedback = "Error";
                    return feedback;
            }
        }
        #endregion 

    }
}
