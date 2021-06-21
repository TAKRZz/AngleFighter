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

        const int targetPort = 23434;

        MiniHost host0;

        MiniClient client1, client2;



        Client()
        {
            color = 0;
            socketSend = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);
            turn = 0;
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

                //Thread tb = new Thread();
            }
            catch
            {

            }

        }

        private void waitTurn()
        {
            while (true)
            {
                if(turn == 1) { }
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

        // 发送自己的名字 加 0 做标记
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
                        if(this.color == 0)
                        {
                            this.color = str[0] - '0';
                            host0.name = str.Substring(2);
                            
                        }
                        int c0 = str[0] - '0';
                        if (c0 != this.color)
                        {
                            if(client1.name == null)
                            {
                                client1.color = c0;
                                client1.name = str.Substring(2);
                            }
                            else if (client2.name == null)
                            {
                                client2.color = c0;
                                client2.name = str.Substring(2);
                            }
                        }
                    }
                    else if (buffer[0] == 1)
                    {
                        // 开始游戏
                        gameStart();

                    }
                    else if (buffer[0] == 2)
                    {
                        // 下棋
                        // 显示
                        string str = Encoding.UTF8.GetString(buffer, 1, r - 1);
                        Step step = new Step(str);
                        
                        addStep(step);

                        // 轮到你下棋
                        if(step.color == this.color - 1)//这个判断条件还需要优化 如果有人投降
                        {
                            Playing();
                        }

                    }
                    else if(buffer[0] == 3)
                    {

                        // 认输

                    }
                    else if(buffer[0] == 4)
                    {

                        // 交流
                    }
                    else if(buffer[0] == 5)
                    {

                        // 结束
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
                string str = this.color.ToString();
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);
                List<byte> list = new List<byte>();
                
                list.Add(2);
                list.AddRange(buffer);

                byte[] newBuffer = list.ToArray();
                socketSend.Send(newBuffer);

            }
            catch
            {

            }
        }

    }
}
