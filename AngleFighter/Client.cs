using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngleFighter
{
    class Client : Player
    {
        //创建client socket
        Socket socketSend;

        string hostName;

        const int targetPort = 23434;

        MiniHost host0;

        MiniClient client1, client2;

        Client()
        {

            socketSend = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);

        }

        public void start()
        {

            try
            {
                Thread tc = new Thread(connect);
                tc.IsBackground = true;
                tc.Start();

                Thread tr = new Thread(receive);
                tr.IsBackground = true;
                tr.Start();
            }
            catch
            {

            }


        }

        // 连接 Host
        private void connect()
        {
            try
            {
                IPAddress ip = IPAddress.Parse(serverIP.Text);// 输入框
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(targetPort));
                socketSend.Connect(point);
                sendClient();
            }
            catch { }
        }

        public void sendClient()
        {
            string str = "0 " + this.name;
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);
            List<byte> list = new List<byte>();
            list.Add(0);
            list.AddRange(buffer);
            byte[] newbuffer = list.ToArray();
            socketSend.Send(newbuffer);
        }

        // 接收消息  0 连接信息  1 开始游戏  2 下棋  3 认输  4 交流  5 结束 6 委托
        public void receive()
        {
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024 * 128];
                    int r = socketSend.Receive(buffer);
                    if (r == 0) break;
                    // 连接信息
                    if (buffer[0] == 0)
                    {
                        string str = Encoding.UTF8.GetString(buffer, 1, r - 1);



                        //等待一个正则表达式

                        //string str = Encoding.UTF8.GetString(buffer, 1, r - 1);
                        //showMessage(socketSend.RemoteEndPoint + " : " + str);
                    }
                    else if (buffer[0] == 1)
                    {


                    }
                    else if (buffer[0] == 2)
                    {
                        // 有人认输

                    }
                    else if(buffer[0] == 3)
                    {
                        //交流

                    }
                    else if(buffer[0] == 4)
                    {
                        // 轮到你下棋
                    }
                }
                catch
                {
                }
            }
        }

        // 下棋 
        override
        public void sendPlayChess(Step step)
        {
            try
            {
                // str 下棋的string信息
                string str = step.ToString();
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);
                socketSend.Send(buffer);

            }
            catch
            {


            }
        }
        private void sendGiveUp()
        {
            try
            {
                // str 下棋的string信息
                string str = null;
                List<byte> list = new List<byte>();
                list.Add(2);

                byte[] newBuffer = list.ToArray();
                
                socketSend.Send(buffer);

            }
            catch
            {

            }
        }

    }
}
