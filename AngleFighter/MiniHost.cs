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
        public int color;
        public Socket socket;

        public MiniHost()
        {
            color = 1;
            name = null;
            socket = null;
        }

        public override string ToString()
        {
            return color.ToString() + " " + name;
        }
    }
}
