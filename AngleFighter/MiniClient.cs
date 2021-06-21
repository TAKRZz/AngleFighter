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

        public MiniClient()
        {
            color = 0;
            name = null;
            socket = null;
        }

        public MiniClient(Socket socket)
        {
            this.socket = socket;
            name = null;
            color = 0;
        }
        public override string ToString()
        {
            return color.ToString() + " " + name;
        }
    }
}
