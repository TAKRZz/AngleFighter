using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleFighter
{
    class Player
    {
        //颜色，进入房间时，系统分配
        int color;

        //每个玩家拥有一个棋盘
        private Pane pane;

        //每个玩家有若干棋子
        private List<Chess> chesses;

        //玩家IP地址
        public int IP;

        //创建房间，返回房间号
        int CreateRoom()
        {
            //查询IP
            return IP;
        }

        //根据房间号加入房间
        void JoinRoom(int IP)
        {

        }

        void sendMessage()
        {
            string message = pane.ToStep();
        }

        //根据棋子编号进行选择棋子，利用棋盘的接口进行下棋
        void PlayChess(int chessNo)
        {
            Chess chess = ChooseChess(chessNo);
            pane.PlayChess(chess);//下棋
            sendMessage();//发送网络信息
            chesses.Remove(chess);//将棋子从剩余棋子当中移除
        }

        //选择棋子
        Chess ChooseChess(int No)
        {
            foreach(Chess chess in chesses)
            {
                if(chess.GetNo() == No)
                {
                    return chess;
                }
            }
            return null;
        }
    }
}
