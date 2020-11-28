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
    }
}
