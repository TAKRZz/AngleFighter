using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleFighter
{
    abstract class Player
    {


        //颜色，进入房间时，系统分配
        public int color;

        
        //每个玩家拥有一个棋盘
        private Pane pane;

        //每个玩家有若干棋子
        private List<Chess> chesses;

        //玩家IP地址
        public string IP;

        //玩家名称

        public string name;

        public abstract void sendPlayChess(Step step);

        //根据棋子编号进行选择棋子，利用棋盘的接口进行下棋
        public void PlayChess(int chessNo)
        {
            Chess chess = ChooseChess(chessNo);
            pane.PlayChess(chess);//下棋

            Step step = new Step(chess, 0);

            sendPlayChess(step);//发送网络信息

            waiting();  // 将下棋等按钮置为灰色 
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


        //在棋盘显示一步棋
        public void addStep(Step step);

        //等待下棋
        public void waiting();

        //开始下棋
        public void playing();

    }
}
