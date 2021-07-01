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

    public class Host : Player
    {

        //Socket socketSend;
        Dictionary<string, Socket> dicSocket;

        Dictionary<string, MiniClient> dicClient;

        //MiniClient client1, client2, client3;

        public RoomForm1 roomForm1;

        public GameForm gameForm;

        // 回合计数
        int turnCount;
        const int Port = 23434;
        // 记录连接进来的client数量
        int ClientCount;
        public Host(string name)
        {
            this.name = name;
            this.color = 1;
            base.Init();
            dicSocket = new Dictionary<string, Socket>();
            dicClient = new Dictionary<string, MiniClient>();
            Control.CheckForIllegalCrossThreadCalls = false;
            string name0 = Dns.GetHostName();
            IPAddress[] ip = Dns.GetHostAddresses(name0);

            this.IP = ip[ip.Length - 1].ToString();

            this.roomForm1 = new RoomForm1();
            this.roomForm1.Host_IP_txt.Text = this.IP;

            this.gameForm = new GameForm();
            this.gameForm.P = this;

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
                socketWatch.Listen(10);
                //在某一个时间点内，能连接server的最大client数量
                //等待连接、创建通信socket
                Thread thread = new Thread(listen);
                thread.IsBackground = true;
                thread.Start(socketWatch);

                roomForm1.ShowDialog();
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
            while (true) 
            {
                Socket socketSend = socketWatch.Accept(); // 一直在等待连接
                dicSocket.Add(socketSend.RemoteEndPoint.ToString(), socketSend);

                dicClient.Add(socketSend.RemoteEndPoint.ToString(), new MiniClient(socketSend));

                Thread th = new Thread(receive);
                th.IsBackground = true;
                th.Start(socketSend);
                ClientCount++;
                if(ClientCount == 3)
                {
                    roomForm1.begin_btn.Enabled = true;
                }
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

                        dicClient[socketSend.RemoteEndPoint.ToString()].name = str;
                       
                    }
                    else if(buffer[0] == 1)
                    {
                        // 接收不到

                    }
                    else if(buffer[0] == 2)
                    {
                        string str = Encoding.UTF8.GetString(buffer, 1, r - 1);

                        // 缺少实现
                        othersPlay(str);

                        sendPlayChess(TransferToChess(str));

                        if (TransferToChess(str).color == 4)
                        {
                            playing();
                        }
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
                string str = dicSocket.Count.ToString() + " " + this.name;
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
                        if (i.color == n.color) continue;
                        sendMessage(n.ToString(), i.socket, 0);
                    }
                }
            }
            catch { }
        }

        // 开始下棋 首位为2

        public void StartGame()
        {
            try
            {
                // toString 方法
                List<byte> list = new List<byte>();
                list.Add(1);
                byte[] newBuffer = list.ToArray();
                
                //每一个都发送
                foreach (var i in dicSocket.Values)
                {
                    i.Send(newBuffer);
                }
                this.gameForm.ShowDialog();

            }
            catch { }

        }


        // 发送信息 正常下棋 首位为3
        override
        public void sendPlayChess(Chess chess)
        {
            try
            {
                // toString 方法
                string str = chess.ToString();
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

        public override void waiting()
        {
            throw new NotImplementedException();
        }

        public override void playing()
        {
            throw new NotImplementedException();
        }
    }
}
