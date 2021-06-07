using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AngleFighter
{
    //抽象棋子，用于各种棋子的统一模板
    public abstract class Chess
    {
        //棋子编号，用于棋子的唯一标识，在具体棋子当中，应该为每一个类棋子分配一个固定的编号
        private int No;
        public int num
        {
            get;
            set;
        }
        //棋子方向，用于旋转棋子
        int direction;
        const int UP = 0;
        const int LEFT = 1;
        const int DOWN = 2;
        const int RIGHT = 3;
        
        //棋子锚点，用于限定整个棋子的初始位置和颜色
        public Grid anchor;

        //棋子集合，用于表示棋子
        public List<Grid> grids = new List<Grid>();
        

        //棋子初始化的方法，利用锚点的确定整个棋子的位置
        public abstract void Init();

        //旋转棋子
        public abstract void Rotate();

        //棋子的ToString方法
        public override string ToString()
        {
            return anchor.ToString() + direction + No;
        }

        //提供棋子编号的查询
        public int GetNo()
        {
            return No;
        }

        
    }
    //目前先写了11个棋子的一部分，有问题好改，rotate方法暂未完全完成
    //妻子一
    public class chess01 : Chess
    {
        int No = 1;
        Grid anchor = new Grid(0, 0, 1);
        public void Init()
        {
            grids.Add(anchor);
        }
        //不需要旋转
        public void Rotate(int direction) { }
    }
    //棋子二
    public class chess02 : Chess
    {
        int No = 2;
        Grid anchor = new Grid(0, 0, 1);
        Grid grid = new Grid(0, length, 1);
        public void Init()
        {
            grids.Add(anchor);
            grids.Add(grid);
        }
        public void Rotate(int direction)
        {

            foreach (Grid g in grids)
            {
                g.x1 = -g.y;
                g.y1 = g.x;
                g.x = g.x1;
                g.y = g.y1 - length;
            }
        }

    }
    //棋子三
    public class chess03 : Chess
    {
        int No = 3;
        Grid anchor = new Grid(0, 0, 1);
        Grid grid1 = new Grid(0, length, 1);
        Grid grid2 = new Grid(0, 2 * length, 1);
        public void Init()
        {
            grids.Add(anchor);
            grids.Add(grid1);
            grids.Add(grid2);
        }
        public void Rotate(int direction)
        {

            foreach (Grid g in grids)
            {
                g.x1 = -g.y;
                g.y1 = g.x;
                g.x = g.x1;
                g.y = g.y1 - length;
            }
        }
    }
    //棋子四
    public class chess04 : Chess
    {
        int No = 4;
        Grid anchor = new Grid(0, 0, 1);
        Grid grid1 = new Grid(0, length, 1);
        Grid grid2 = new Grid(length, 0, 1);
        public void Init()
        {
            grids.Add(anchor);
            grids.Add(grid1);
            grids.Add(grid2);
        }
        public void Rotate(int direction)
        {

            foreach (Grid g in grids)
            {
                g.x1 = -g.y;
                g.y1 = g.x;
                g.x = g.x1;
                g.y = g.y1 - length;
            }
        }
    }
    //棋子五
    public class chess05 : Chess
    {
        int No = 5;
        Grid anchor = new Grid(0, 0, 1);
        Grid grid1 = new Grid(0, length, 1);
        Grid grid2 = new Grid(0, 2 * length, 1);
        Grid grid3 = new Grid(0, 3 * length, 1);
        public void Init()
        {
            grids.Add(anchor);
            grids.Add(grid1);
            grids.Add(grid2);
            grids.Add(grid3);
        }
        public void Rotate(int direction)
        {

            foreach (Grid g in grids)
            {
                g.x1 = -g.y;
                g.y1 = g.x;
                g.x = g.x1;
                g.y = g.y1 - length;
            }
        }
    }
    //棋子六
    public class chess06 : Chess
    {
        int No = 6;
        Grid anchor = new Grid(0, 0, 1);
        Grid grid1 = new Grid(length, 0, 1);
        Grid grid2 = new Grid(length, length, 1);
        Grid grid3 = new Grid(0, 2 * length, 1);
        public void Init()
        {
            grids.Add(anchor);
            grids.Add(grid1);
            grids.Add(grid2);
            grids.Add(grid3);
        }
        public void Rotate(int direction)
        {

            foreach (Grid g in grids)
            {
                g.x1 = -g.y;
                g.y1 = g.x;
                g.x = g.x1;
                g.y = g.y1 - length;
            }
        }
    }
    //棋子七
    public class chess07 : Chess
    {
        int No = 7;
        Grid anchor = new Grid(0, 0, 1);
        Grid grid1 = new Grid(0, length, 1);
        Grid grid2 = new Grid(length, length, 1);
        Grid grid3 = new Grid(0, 2 * length, 1);
        public void Init()
        {
            grids.Add(anchor);
            grids.Add(grid1);
            grids.Add(grid2);
            grids.Add(grid3);
        }
        public void Rotate(int direction)
        {

            foreach (Grid g in grids)
            {
                g.x1 = -g.y;
                g.y1 = g.x;
                g.x = g.x1;
                g.y = g.y1 - length;
            }
        }
    }
    //棋子八
    public class chess08 : Chess
    {
        int No = 8;
        Grid anchor = new Grid(0, 0, 1);
        Grid grid1 = new Grid(0, length, 1);
        Grid grid2 = new Grid(length, 0, 1);
        Grid grid3 = new Grid(length, length, 1);
        public void Init()
        {
            grids.Add(anchor);
            grids.Add(grid1);
            grids.Add(grid2);
            grids.Add(grid3);
        }
        public void Rotate(int direction)
        {

            foreach (Grid g in grids)
            {
                g.x1 = -g.y;
                g.y1 = g.x;
                g.x = g.x1;
                g.y = g.y1 - length;
            }
        }
    }
    //棋子九
    public class chess09 : Chess
    {
        int No = 9;
        Grid anchor = new Grid(0, 0, 1);
        Grid grid1 = new Grid(length, 0, 1);
        Grid grid2 = new Grid(length, -length, 1);
        Grid grid3 = new Grid(2 * length, -length, 1);
        public void Init()
        {
            grids.Add(anchor);
            grids.Add(grid1);
            grids.Add(grid2);
            grids.Add(grid3);
        }
        public void Rotate(int direction)
        {

            foreach (Grid g in grids)
            {
                g.x1 = -g.y;
                g.y1 = g.x;
                g.x = g.x1;
                g.y = g.y1 - length;
            }
        }
    }
    //棋子十
    public class chess10 : Chess
    {
        int No = 10;
        Grid anchor = new Grid(0, 0, 1);
        Grid grid1 = new Grid(0, length, 1);
        Grid grid2 = new Grid(0, 2 * length, 1);
        Grid grid3 = new Grid(0, 3 * length, 1);
        Grid grid4 = new Grid(0, 4 * length, 1);
        public void Init()
        {
            grids.Add(anchor);
            grids.Add(grid1);
            grids.Add(grid2);
            grids.Add(grid3);
            grids.Add(grid4);
        }
        public void Rotate(int direction)
        {

            foreach (Grid g in grids)
            {
                g.x1 = -g.y;
                g.y1 = g.x;
                g.x = g.x1;
                g.y = g.y1 - length;
            }
        }
    }
    //棋子二十一
    public class chess21 : Chess
    {
        int No = 21;
        Grid anchor = new Grid(0, 0, 1);
        Grid grid1 = new Grid(length, 0, 1);
        Grid grid2 = new Grid(2 * length, 0, 1);
        Grid grid3 = new Grid(length, length, 1);
        Grid grid4 = new Grid(0, -length, 1);
        public void Init()
        {
            grids.Add(anchor);
            grids.Add(grid1);
            grids.Add(grid2);
            grids.Add(grid3);
            grids.Add(grid4);
        }
        //无需旋转
        public void Rotate()
        {

        }
    }
}
