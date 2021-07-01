using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleFighter
{

    public class Pane
    {
        //记录下棋的次序
        static int order = 0;

        //记录当前下的棋
        Step step;

        //定义棋盘结构
        List<Grid> grids = new List<Grid>(400);


        public void InitGrids(int x,int y)
        {
            for (int count = 0; count < grids.Capacity; count++)
            {
                grids.Add(new Grid(x, y));//将棋盘初始化为空白棋子
                x = Grid.length * (count % 19);
                y = Grid.length * ((count + 1) / 20);
            }
        }

        //下棋
        public void PlayChess(Chess chess)
        {
            foreach (var grid in chess.grids)
            {
                ChangeColor(grid.GetX(), grid.GetY(), grid.GetColor());
                //记录这一次下的棋
                step = new Step(chess, order);

            }
        }

        // 检测算法
        public bool isPlaceAble(Chess chess)
        {
            bool isPlaceable = true;

            if (IsOver(chess))
            {
                isPlaceable = false;
            }

            //棋子覆盖与否
            foreach (var grid in chess.grids)
            {
                foreach (var item in grids)
                {
                    if (grid.GetX() == item.GetX() && grid.GetY() == item.GetY())
                    {
                        if (item.GetColor() > 0) isPlaceable = false;//棋子覆盖，则不能下棋
                    }

                    if (grid.GetX() + Grid.length == item.GetX() && grid.GetY() == item.GetY())
                    {
                        if (item.GetColor() == grid.GetColor()) isPlaceable = false;
                    }
                    if (grid.GetX() == item.GetX() && grid.GetY() + Grid.length == item.GetY())
                    {
                        if (item.GetColor() == grid.GetColor()) isPlaceable = false;
                    }
                    if (grid.GetX() - Grid.length == item.GetX() && grid.GetY() == item.GetY())
                    {
                        if (item.GetColor() == grid.GetColor()) isPlaceable = false;
                    }
                    if (grid.GetX() == item.GetX() && grid.GetY() - Grid.length == item.GetY())
                    {
                        if (item.GetColor() == grid.GetColor()) isPlaceable = false;
                    }
                }
            }

            for (int i = 0; i < chess.count; i++)
            {
                if (!AngleCheck(chess.grids[i]))
                {
                    isPlaceable = false;
                }
            }

            return isPlaceable;
        }

        //根据输入的位置坐标修改格子的颜色
        void ChangeColor(int x, int y, int color)
        {
            GetGrid(x, y).SetColor(color);
        }

        public Grid GetGrid(int x, int y)
        {
            foreach (var item in this.grids)
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
            if (GetGrid(grid.GetX() + Grid.length, grid.GetY() + Grid.length).GetColor() == grid.GetColor())
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
        private bool IsOver(Chess chess)
        {
            foreach (Grid grid in chess.grids)
            {
                if (this.grids.Contains(grid)) return false;
            }
            return true;
        }

    }
}
