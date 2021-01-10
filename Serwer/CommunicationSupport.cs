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
                    BankServerAPM.db.AddBalance(this.login, (-1*Int32.Parse(components[1])));
                    feedback = "1";
                    return feedback;
                case "4":
                    BankServerAPM.db.AddBalance(this.login, (1 * Int32.Parse(components[1])));
                    feedback = "1";
                    return feedback;
                case "5":
                    try
                    {
                        if (BankServerAPM.db.TransferMoney(this.login, components[1], Int32.Parse(components[2])))
                        {
                            feedback = "1";
                        }
                        else
                        {
                            feedback = "0";
                        }
                        return feedback;
                    }
                    catch(Exception e)
                    {
                        feedback = "0";
                        return feedback;
                    }
                   
                case "6":
                    try
                    {
                        feedback=BankServerAPM.db.downloadAccounts();
                    }
                    catch (Exception e)
                    {
                        feedback = "0";
                        return feedback;
                    }
                    return feedback;

                case "7":
                    try
                    {
                        BankServerAPM.db.AddEntry(components[1], components[2], components[3], components[4]);
                    }
                    catch (Exception e)
                    {
                        feedback = "0";
                        return feedback;
                    }
                    feedback = "1";
                    return feedback;
                case "8":
                    try
                    {
                        BankServerAPM.db.DeleteEntry(components[1]);
                        this.login = "";
                        feedback = "1";
                        return feedback;
                    }
                    catch (Exception e)
                    {
                        feedback = "0";
                        return feedback;
                    }
                   
                case "9":
                    if (BankServerAPM.db.adminLogin(components[1], components[2]))
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
                case "10":
                    String data = BankServerAPM.db.downloadDatas(components[1]);
                    if (data!=null)
                    {
                        feedback = data;
                        return feedback;
                    }
                    else
                    {
                        feedback = "0";
                        return feedback;
                    }
                case "11":
                    try
                    {
                        BankServerAPM.db.ChangeUserData(components[1], components[2], components[3], components[4], components[5], Int32.Parse(components[6]));
                    }
                    catch (Exception e)
                    {
                        feedback = "0";
                        return feedback;
                    }
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
