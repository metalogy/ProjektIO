using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_projektIO
{
    public struct accountsStruct
    {
        public int ID;
        public String name;
        //accountsStruct() { };
    }
    class ServerCommuniacationProtocol
    {
        public static List<accountsStruct> getAccounts(String data)
        {
            List<accountsStruct> accounts = new List<accountsStruct>();
            String[] users= data.Split('*');
            accountsStruct helper;
            foreach (String user in users)
            {
                String[] organiser = user.Split(':');
                helper.ID = Int32.Parse(organiser[0]);//id
                helper.name = organiser[1];//nazwa użytkownika
                accounts.Add(helper);

            }
            return accounts;

        }
    }
}
