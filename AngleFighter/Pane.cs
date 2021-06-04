﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleFighter
{
    
    class Pane
    {
        //记录下棋的次序
        static int order = 0;

        //定义棋盘结构
        List<Grid> grids = new List<Grid>(100);

        // Pane 的 初始化
        public Pane()
        {
            int x = 0;//左上角横坐标
            int y = 0;//左上角纵坐标

            for(int count = 0; count < grids.Capacity; count++)
            {
                grids.Add(new Grid(x, y));
                x = Grid.length * (count % 9);//
                y = Grid.length * ((count+1) / 10);
            }
        }

        // 在终端显示Pane
        void showPane()
        {
            
        }

        // 在 Form 上显示 棋盘;
        void showPaneInForm() { }


        // 下棋,利用棋子的锚点位置，将其贴合于最近的格子
        void PlayChess(Chess chess)
        {
            //下棋次序加一
            Pane.order++;

            //将棋子贴在最近的格子
            int x = chess.anchor.GetX();
            int y = chess.anchor.GetY();
            if (x % Grid.length < Grid.length / 2)
            {
                chess.anchor.SetX((x / Grid.length) * Grid.length);
            }
            else
            {
                chess.anchor.SetX((x / Grid.length + 1) * Grid.length);
            }
            if (y % Grid.length < Grid.length / 2)
            {
                chess.anchor.SetY((y / Grid.length) * Grid.length);
            }
            else
            {
                chess.anchor.SetY((y / Grid.length + 1) * Grid.length);
            }

            //修改棋盘格子状态，实现下棋
            if (isPlaceAble(chess))
            {
                foreach (var grid in chess.grids)
                {
                    ChangeColor(grid.GetX(), grid.GetY(), grid.GetColor());
                }
            }


        }

        // 检测算法
        bool isPlaceAble(Chess chess)
        {
            
            //检测是否有棋子覆盖的情况
            foreach (var grid in chess.grids)
            {
                foreach (var item in grids)
                {
                    if(grid.GetX() == item.GetX() && grid.GetY() == item.GetY())
                    {
                        if (item.GetColor() > 0) return false;
                    }
                }
            }
            //检测是否不满足游戏规定的对角放置棋子

            return true;
        }

        // Move 生成 string
        string moveToString(Chess chess)
        {
            Step step = new Step(chess, Pane.order);
            return step.ToString();
        }

        //根据输入的位置坐标修改格子的颜色
        void ChangeColor(int x,int y,int color)
        {
            foreach (var item in grids)
            {
                if (item.GetX() == x && item.GetY() == y)
                {
                    item.SetColor(color);
                }
            }
        }
    }
}
