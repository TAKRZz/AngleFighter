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

    class Host : Player
    {

        //Socket socketSend;
        Dictionary<string, Socket> dicSocket;

        Dictionary<string, MiniClient> dicClient;

        //MiniClient client1, client2, client3;

        // 回合计数
        int turnCount;
        const int Port = 23434;
        // 记录连接进来的client数量
        int ClientCount;
        public Host()
        {
            this.color = 1;
            dicSocket = new Dictionary<string, Socket>();
            dicClient = new Dictionary<string, MiniClient>();
            Control.CheckForIllegalCrossThreadCalls = false;
            string name = Dns.GetHostName();
            IPAddress[] ip = Dns.GetHostAddresses(name);
            this.IP = ip[ip.Length - 1].ToString();
            ClientCount = 0;
            turnCount = 0;

        }


        // 创建房间后
        // 接收消息  0连接信息  1 开始游戏  2 下棋  3 认输  4 交流  5 结束 6 委托

        public void creRoom()
        {
            try
            {
                Socket socketWatch = new Socket(
                       AddressFamily.InterNetwork,
                       SocketType.Stream,
                       ProtocolType.Tcp);
                // ip
                IPAddress ip = IPAddress.Any;
                //创建端口
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(Port));

                socketWatch.Bind(point);

                //设置监听队列
                socketWatch.Listen(3);
                //在某一个时间点内，能连接server的最大client数量
                //等待连接、创建通信socket
                Thread thread = new Thread(listen);
                thread.IsBackground = true;
                thread.Start(socketWatch);

            }
            catch
            {

            }

        }


        // 开始监听
        public void listen(object o)
        {
            Socket socketWatch = o as Socket;
       
            // 人数
            while (ClientCount != 3) 
            {
                Socket socketSend = socketWatch.Accept(); // 一直在等待连接
                dicSocket.Add(socketSend.RemoteEndPoint.ToString(), socketSend);
                //if (ClientCount == 0)
                //{
                //    dicClient.Add(socketSend.RemoteEndPoint.ToString(), new MiniClient(socketSend));
                //    //client1.socket = socketSend;
                //}
                //if (ClientCount == 1)
                //{
                //    dicClient.Add(socketSend.RemoteEndPoint.ToString(), new MiniClient(soc);
                //    client2.socket = socketSend;
                //}
                //if (ClientCount == 2)
                //{
                //    dicClient.Add(socketSend.RemoteEndPoint.ToString(), client3);
                //    client3.socket = socketSend;
                //}

                dicClient.Add(socketSend.RemoteEndPoint.ToString(), new MiniClient(socketSend));

                Thread th = new Thread(receive);
                th.IsBackground = true;
                th.Start(socketSend);

                ClientCount++;
                sendHost(socketSend);
                roomRefresh();

            }
        }

        // 接受信息
        // 信息的种类    
        public void receive(object o)
        {
            Socket socketSend = o as Socket;
            
            // 关掉后死循环
            while (true)
            {
                try
                {
                    // 接收消息 : 0连接信息  1 开始游戏  2 下棋  3 认输  4 交流  5 结束 
                    byte[] buffer = new byte[1024 * 128];
                    int r = socketSend.Receive(buffer);//接收的有效字节数
                    if (r == 0) break;
                    //showMessage(socketSend.RemoteEndPoint + " : " + str);
                    // 判断 连接 开始游戏 下棋 投降
                    if (buffer[0] == 0)
                    {
                        string str = Encoding.UTF8.GetString(buffer, 1, r - 1);
                        if (str[0] == '0')
                        {
                            dicClient[socketSend.RemoteEndPoint.ToString()].name = str.Substring(2);
                        }
                    }
                    else if(buffer[0] == 1)
                    {
                        // 接收不到

                    }
                    else if(buffer[0] == 2)
                    {
                        string str = Encoding.UTF8.GetString(buffer, 1, r - 1);
                        
                        Step step = new Step(str); // 缺少实现

                        sendPlayChess(step);

                    }



                }
                catch
                {
                }
            }

        }

        // 当client 加入房间时 发送host的名称 0 和 玩家序号 1
        public void sendHost(Socket socket)
        {
            try
            {  

                // toString 方法
                string str = dicSocket.Count.ToString()+ " " + this.name;
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);
                List<byte> list = new List<byte>();
                // 加 0
                list.Add(0);
                list.AddRange(buffer);
                byte[] newBuffer = list.ToArray();
                socket.Send(newBuffer);


            }
            catch
            {

            }

            return;
        }

        public void sendMessage(string str,Socket socket,byte n)
        {
            try
            {
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);
                List<byte> list = new List<byte>();
                list.Add(n);
                list.AddRange(buffer);
                byte[] newbuffer = list.ToArray();
                socket.Send(newbuffer);
            }
            catch { }
        }

        // 刷新房间信息
        public void roomRefresh()
        {
            try
            {
                foreach (var i in dicClient.Values)
                {

                    foreach (var n in dicClient.Values)
                    {
                        sendMessage(n.ToString(), i.socket, 0);
                    }
                }
            }
            catch { }
        }

        // 开始下棋 首位为2
        public void sendStartGame()
        {
            try
            {
                // toString 方法
                string str = null;
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);
                List<byte> list = new List<byte>();
                // 开始下棋 加 2
                list.Add(2);
                list.AddRange(buffer);
                byte[] newBuffer = list.ToArray();
                
                
                //每一个都发送
                foreach (var i in dicSocket.Values)
                {
                    i.Send(newBuffer);
                }

                //client1.socket.Send(newBuffer);
                //client2.socket.Send(newBuffer);
                //client3.socket.Send(newBuffer);
                //string ip = cboUsers.SelectedItem.ToString();
                //dicSocket[ip].Send(newBuffer);
                //socketSend.Send(buffer);

            }
            catch { }

        }


        // 发送信息 正常下棋 首位为3
        override
        public void sendPlayChess(Step step)
        {

            try
            {
                // toString 方法
                string str = step.ToString();
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);
                List<byte> list = new List<byte>();
                // 正常下棋 加 3
                list.Add(3);
                list.AddRange(buffer);
                byte[] newBuffer = list.ToArray();
                // 每一个都发送
                foreach(var i in dicClient.Values)
                {
                    i.socket.Send(newBuffer);
                }

            }
            catch { }
        }

        public void sendEndGame()
        {
            try
            {
                // toString 方法
                string str = null;
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);
                List<byte> list = new List<byte>();
                // 结束游戏 加 2
                list.Add(2);
                list.AddRange(buffer);
                byte[] newBuffer = list.ToArray();
                // 每一个都发送
                foreach (var i in dicClient.Values)
                {
                    i.socket.Send(newBuffer);
                }
               
            }
            catch { }

        }

    }
}
