using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AngleFighter
{
    class MiniHost
    {
        public string name;
        public const int color = 1;
        public Socket socket;

        MiniHost()
        {
            name = null;
            socket = null;
        }

        public override string ToString()
        {
            return color.ToString() + " " + name;
        }
    }
}
