using System;
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

        //记录当前下的棋
        Step step;

        //定义棋盘结构
        List<Grid> grids = new List<Grid>(100);

        // Pane 的 初始化
        public Pane()
        {
            int x = 0;//左上角横坐标
            int y = 0;//左上角纵坐标

            for(int count = 0; count < grids.Capacity; count++)
            {
                grids.Add(new Grid(x, y));//将棋盘初始化为空白棋子
                x = Grid.length * (count % 9);
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
        public void PlayChess(Chess chess)
        {
            //下棋次序加一
            Pane.order++;

            //记录棋子的初始状态，用于不能下棋时的状态恢复
            Chess tempChess = chess;

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
                    //记录这一次下的棋
                    step = new Step(chess, order);
                }
            }
            else
            {
                //棋子下不了 ，应该恢复棋子初始状态，并且将系统记录下棋次序减一
                Console.WriteLine("you can't place a chess here");
                chess = tempChess;
                order--;
            }

        }

        // 检测算法
        bool isPlaceAble(Chess chess)
        {
            if (IsOver(chess))
            {
                return false;
            }

            //棋子覆盖与否
            foreach (var grid in chess.grids)
            {
                foreach (var item in grids)
                {
                    if(grid.GetX() == item.GetX() && grid.GetY() == item.GetY())
                    {
                        if (item.GetColor() > 0) return false;//棋子覆盖，则不能下棋
                    }

                    if (grid.GetX() + Grid.length == item.GetX() && grid.GetY() == item.GetY())
                    {
                        if (item.GetColor()==grid.GetColor()) return false;
                    }
                    if (grid.GetX()  == item.GetX() && grid.GetY() + Grid.length == item.GetY())
                    {
                        if (item.GetColor() == grid.GetColor()) return false;
                    }
                    if (grid.GetX() - Grid.length== item.GetX() && grid.GetY() == item.GetY())
                    {
                        if (item.GetColor() == grid.GetColor()) return false;
                    }
                    if (grid.GetX() == item.GetX() && grid.GetY() - Grid.length == item.GetY())
                    {
                        if (item.GetColor() == grid.GetColor()) return false;
                    }
                }
            }

            for (int i = 0; i < chess.count; i++)
            {
                return AngleCheck(chess.grids[i]);
            }

            return true;
        }

        //根据输入的位置坐标修改格子的颜色
        void ChangeColor(int x,int y,int color)
        {
            GetGrid(x,y).SetColor(color);
        }

        Grid GetGrid(int x, int y)
        {
            foreach (var item in grids)
            {
                if (item.GetX() == x && item.GetY() == y)
                {
                    return item;
                }
            }
            return null;
        }

        //得到下棋的步骤信息，用于网络通信
        public string ToStep()
        {
            return step.ToString();
        }

        //四角检测
        private bool AngleCheck(Grid grid)
        {
            if (GetGrid(grid.GetX() + Grid.length, grid.GetY() + Grid.length).GetColor()== grid.GetColor())
            {
                return false;
            }
            if (GetGrid(grid.GetX() + Grid.length, grid.GetY() - Grid.length).GetColor() == grid.GetColor())
            {
                return false;
            }
            if (GetGrid(grid.GetX() - Grid.length, grid.GetY() + Grid.length).GetColor() == grid.GetColor())
            {
                return false;
            }
            if (GetGrid(grid.GetX() - Grid.length, grid.GetY() - Grid.length).GetColor() == grid.GetColor())
            {
                return false;
            }
            return true;
        }

        //越界检测
        bool IsOver(Chess chess)
        {
            foreach (Grid grid in chess.grids)
            {
                if (this.grids.Contains(grid)) return false;
            }
            return true ;
        }

    }
}
