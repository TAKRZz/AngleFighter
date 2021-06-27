﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleFighter
{
    public abstract class Player
    {
        //游戏玩家得分
        public int score;

        //颜色，进入房间时，系统分配
        public int color;

        //每个玩家拥有一个棋盘
        private Pane pane = new Pane();

        //每个玩家有若干棋子
        private List<Chess> chesses;

        //玩家IP地址
        public string IP;

        //玩家名称

        public string name = null;

        public abstract void sendPlayChess(Chess chess);

        //根据棋子编号进行选择棋子，利用棋盘的接口进行下棋
        public void PlayChess(Chess chess)
        {
           
            pane.PlayChess(chess);//下棋

            sendPlayChess(chess);//发送网络信息

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


        //等待下棋
        public abstract void waiting();

        //开始下棋
        public abstract void playing();

        //来自网络的下棋
        public void othersPlay(string chessStr)
        {
            pane.PlayChess(TransferToChess(chessStr));
        }

        //根据字符串转换成chess
        public Chess TransferToChess(string chessStr)
        {
            string[] array = chessStr.Split(' ');
            int x = Convert.ToInt32(array[0]);
            int y = Convert.ToInt32(array[1]);
            int color = Convert.ToInt32(array[2]);
            int direction = Convert.ToInt32(array[3]);
            int No = Convert.ToInt32(array[4]);

            Chess chess = Chess.GetChess(No);
            chess.anchor.SetX(x);
            chess.anchor.SetY(y);
            chess.anchor.SetColor(color);

            for (int count = 0; count < direction; count++)
            {
                chess.Rotate();
            }

            return chess;
        }

        //初始化玩家信息，应该在player的实现子类当中调用此方法
        public void Init()
        {
            for(int count = 1;count < 22;count++)
            {
                Chess chess = Chess.GetChess(count);
                chess.anchor.SetColor(this.color);
                chesses.Add(chess);
            }
        }
    }
}
