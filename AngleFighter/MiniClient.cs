using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AngleFighter
{
    class MiniClient
    {
        public int color;
        public string name;
        public Socket socket;

        MiniClient()
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
