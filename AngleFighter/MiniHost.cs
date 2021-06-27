using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AngleFighter
{
    public class MiniHost
    {
        public string name;
        public const int color = 1;
        public Socket socket;

        public MiniHost()
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
