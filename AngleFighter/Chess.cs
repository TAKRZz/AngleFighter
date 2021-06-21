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

        //用来记录位于边角的格子的个数
        public int count;

        // 记录格子的颜色
        public int color;
        
        //棋子方向，用于旋转棋子
        int direction;
        const int UP = 0;
        const int LEFT = 1;
        const int DOWN = 2;
        const int RIGHT = 3;

        //棋子锚点，用于限定整个棋子的初始位置和颜色
        public Grid anchor = new Grid();

        //棋子集合，用于表示棋子
        public List<Grid> grids = new List<Grid>();


        //棋子初始化的方法，利用锚点的确定整个棋子的位置
        public abstract void Init();
        //为棋子设置颜色
        public void initColor(int x)
        {
            this.color = x;
            for (int i = 0; i < grids.Count; i++)
            {
                grids[i].SetColor(x);
            }

        }
        //旋转棋子
        public abstract void Rotate();
        //通过锚点初始化棋子在棋盘上的位置
        public void initPosition(int x, int y)
        {
            anchor.SetX(x);
            anchor.SetY(y);
        }
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
    //通过给anchor坐标赋值来确定棋子在棋盘上的位置，其他grid记录与anchor的相对位置来组成棋子
    //棋子一
    class Chess01 : Chess
    {
        int No = 1;
        public Grid getAnchor()
        {
            return this.anchor;
        }
        int count = 1;
        override
            public void Init()
        {
            grids.Add(getAnchor());
        }
        //不需要旋转
        override
        public void Rotate()
        { }
    }
    //棋子二
    class Chess02 : Chess
    {
        int No = 2;
        public Grid getAnchor()
        {
            return this.anchor;
        }
        Grid grid = new Grid(0, Grid.length);
        int count = 2;
        override
        public void Init()
        {
            grids.Add(getAnchor());
            grids.Add(grid);
        }
        override
        public void Rotate()
        {
            //每个grid的坐标都乘一个旋转矩阵，且每次旋转度数为90度
            for (int i = 0; i < grids.Count; i++)
            {
                int x1 = -grids[i].GetX();
                int y1 = grids[i].GetY();
                grids[i].SetX(x1);
                grids[i].SetY(y1);
            }
        }
    }

    //棋子三
    class Chess03 : Chess
    {
        int No = 3;
        public Grid getAnchor()
        {
            return this.anchor;
        }
        Grid grid1 = new Grid(0, Grid.length);
        Grid grid2 = new Grid(0, 2 * Grid.length);
        int count = 2;
        override
    public void Init()
        {
            grids.Add(getAnchor());
            grids.Add(grid2);
            grids.Add(grid1);
        }
        override
        public void Rotate()
        {
            //每个grid的坐标都乘一个旋转矩阵，且每次旋转度数为90度
            for (int i = 0; i < grids.Count; i++)
            {
                int x1 = -grids[i].GetX();
                int y1 = grids[i].GetY();
                grids[i].SetX(x1);
                grids[i].SetY(y1);
            }

        }
    }
    //棋子四
    class Chess04 : Chess
    {
        int No = 4;
        public Grid getAnchor()
        {
            return this.anchor;
        }
        Grid grid1 = new Grid(0, Grid.length);
        Grid grid2 = new Grid(Grid.length, Grid.length);
        int count = 3;
        override
    public void Init()
        {
            grids.Add(getAnchor());
            grids.Add(grid1);
            grids.Add(grid2);
        }
        override
        public void Rotate()
        {
            //每个grid的坐标都乘一个旋转矩阵，且每次旋转度数为90度
            for (int i = 0; i < grids.Count; i++)
            {
                int x1 = -grids[i].GetX();
                int y1 = grids[i].GetY();
                grids[i].SetX(x1);
                grids[i].SetY(y1);
            }

        }
    }
    //棋子五
    class Chess05 : Chess
    {
        int No = 5;
        public Grid getAnchor()
        {
            return this.anchor;
        }
        Grid grid1 = new Grid(0, Grid.length);
        Grid grid2 = new Grid(0, 2 * Grid.length);
        Grid grid3 = new Grid(0, 3 * Grid.length);
        int count = 2;
        override
public void Init()
        {
            grids.Add(getAnchor());
            grids.Add(grid3);
            grids.Add(grid1);
            grids.Add(grid2);
        }
        override
        public void Rotate()
        {
            //每个grid的坐标都乘一个旋转矩阵，且每次旋转度数为90度
            for (int i = 0; i < grids.Count; i++)
            {
                int x1 = -grids[i].GetX();
                int y1 = grids[i].GetY();
                grids[i].SetX(x1);
                grids[i].SetY(y1);
            }

        }
    }
    //棋子六
    class Chess06 : Chess
    {
        int No = 6;
        public Grid getAnchor()
        {
            return this.anchor;
        }
        Grid grid1 = new Grid(Grid.length, 0);
        Grid grid2 = new Grid(Grid.length, Grid.length);
        Grid grid3 = new Grid(Grid.length, 2 * Grid.length);
        int count = 3;
        override
public void Init()
        {
            grids.Add(getAnchor());
            grids.Add(grid1);
            grids.Add(grid3);
            grids.Add(grid2);
        }
        override
        public void Rotate()
        {
            //每个grid的坐标都乘一个旋转矩阵，且每次旋转度数为90度
            for (int i = 0; i < grids.Count; i++)
            {
                int x1 = -grids[i].GetX();
                int y1 = grids[i].GetY();
                grids[i].SetX(x1);
                grids[i].SetY(y1);
            }

        }
    }
    //棋子七
    class Chess07 : Chess
    {
        int No = 7;
        public Grid getAnchor()
        {
            return this.anchor;
        }
        Grid grid1 = new Grid(0, Grid.length);
        Grid grid2 = new Grid(0, 2 * Grid.length);
        Grid grid3 = new Grid(Grid.length, Grid.length);
        int count = 3;
        override
public void Init()
        {
            grids.Add(getAnchor());
            grids.Add(grid2);
            grids.Add(grid3);
            grids.Add(grid2);
        }
        override
        public void Rotate()
        {
            //每个grid的坐标都乘一个旋转矩阵，且每次旋转度数为90度
            for (int i = 0; i < grids.Count; i++)
            {
                int x1 = -grids[i].GetX();
                int y1 = grids[i].GetY();
                grids[i].SetX(x1);
                grids[i].SetY(y1);
            }

        }
    }
    //棋子八
    class Chess08 : Chess
    {
        int No = 8;
        public Grid getAnchor()
        {
            return this.anchor;
        }
        Grid grid1 = new Grid(0, Grid.length);
        Grid grid2 = new Grid(Grid.length, 0);
        Grid grid3 = new Grid(Grid.length, Grid.length);
        int count = 4;
        override
public void Init()
        {
            grids.Add(getAnchor());
            grids.Add(grid1);
            grids.Add(grid2);
            grids.Add(grid3);
        }
        override
        public void Rotate()
        {
            //每个grid的坐标都乘一个旋转矩阵，且每次旋转度数为90度
            for (int i = 0; i < grids.Count; i++)
            {
                int x1 = -grids[i].GetX();
                int y1 = grids[i].GetY();
                grids[i].SetX(x1);
                grids[i].SetY(y1);
            }

        }
    }
    //棋子九
    class Chess09 : Chess
    {
        int No = 9;
        public Grid getAnchor()
        {
            return this.anchor;
        }
        Grid grid1 = new Grid(Grid.length, 0);
        Grid grid2 = new Grid(Grid.length, -Grid.length);
        Grid grid3 = new Grid(2 * Grid.length, -Grid.length);
        int count = 4;
        override
public void Init()
        {
            grids.Add(getAnchor());
            grids.Add(grid1);
            grids.Add(grid2);
            grids.Add(grid3);
        }
        override
        public void Rotate()
        {
            //每个grid的坐标都乘一个旋转矩阵，且每次旋转度数为90度
            for (int i = 0; i < grids.Count; i++)
            {
                int x1 = -grids[i].GetX();
                int y1 = grids[i].GetY();
                grids[i].SetX(x1);
                grids[i].SetY(y1);
            }

        }
    }
    //棋子十
    class Chess10 : Chess
    {
        int No = 10;
        public Grid getAnchor()
        {
            return this.anchor;
        }
        Grid grid1 = new Grid(0, Grid.length);
        Grid grid2 = new Grid(0, 2 * Grid.length);
        Grid grid3 = new Grid(0, 3 * Grid.length);
        Grid grid4 = new Grid(0, 4 * Grid.length);
        int count = 2;
        override
        public void Init()
        {
            grids.Add(getAnchor());
            grids.Add(grid4);
            grids.Add(grid1);
            grids.Add(grid2);
            grids.Add(grid3);
        }
        override
            public void Rotate()
        {
            //每个grid的坐标都乘一个旋转矩阵，且每次旋转度数为90度
            for (int i = 0; i < grids.Count; i++)
            {
                int x1 = -grids[i].GetX();
                int y1 = grids[i].GetY();
                grids[i].SetX(x1);
                grids[i].SetY(y1);
            }

        }
    }
    //棋子十一
    class Chess11 : Chess
    {
        int No = 11;
        public Grid getAnchor()
        {
            return this.anchor;
        }
        Grid grid1 = new Grid(Grid.length, 0);
        Grid grid2 = new Grid(0, Grid.length);
        Grid grid3 = new Grid(0, 2 * Grid.length);
        Grid grid4 = new Grid(0, 3 * Grid.length);
        int count = 3;
        override
        public void Init()
        {
            grids.Add(getAnchor());
            grids.Add(grid1);
            grids.Add(grid2);
            grids.Add(grid3);
            grids.Add(grid4);
        }
        override
            public void Rotate()
        {
            //每个grid的坐标都乘一个旋转矩阵，且每次旋转度数为90度
            for (int i = 0; i < grids.Count; i++)
            {
                int x1 = -grids[i].GetX();
                int y1 = grids[i].GetY();
                grids[i].SetX(x1);
                grids[i].SetY(y1);
            }

        }
    }
    //棋子十二
    class Chess12 : Chess
    {
        int No = 12;
        public Grid getAnchor()
        {
            return this.anchor;
        }
        Grid grid1 = new Grid(0, Grid.length);
        Grid grid2 = new Grid(Grid.length, Grid.length);
        Grid grid3 = new Grid(Grid.length, 2 * Grid.length);
        Grid grid4 = new Grid(Grid.length, 3 * Grid.length);
        int count = 4;
        override
        public void Init()
        {
            grids.Add(getAnchor());
            grids.Add(grid1);
            grids.Add(grid2);
            grids.Add(grid4);
            grids.Add(grid3);
        }
        override
            public void Rotate()
        {
            //每个grid的坐标都乘一个旋转矩阵，且每次旋转度数为90度
            for (int i = 0; i < grids.Count; i++)
            {
                int x1 = -grids[i].GetX();
                int y1 = grids[i].GetY();
                grids[i].SetX(x1);
                grids[i].SetY(y1);
            }

        }
    }
    //棋子十三
    class Chess13 : Chess
    {
        int No = 13;
        public Grid getAnchor()
        {
            return this.anchor;
        }
        Grid grid1 = new Grid(0, Grid.length);
        Grid grid2 = new Grid(Grid.length, 0);
        Grid grid3 = new Grid(Grid.length, Grid.length);
        Grid grid4 = new Grid(Grid.length, 2 * Grid.length);
        int count = 4;
        override
        public void Init()
        {
            grids.Add(getAnchor());
            grids.Add(grid1);
            grids.Add(grid2);
            grids.Add(grid4);
            grids.Add(grid3);
        }
        override
            public void Rotate()
        {
            //每个grid的坐标都乘一个旋转矩阵，且每次旋转度数为90度
            for (int i = 0; i < grids.Count; i++)
            {
                int x1 = -grids[i].GetX();
                int y1 = grids[i].GetY();
                grids[i].SetX(x1);
                grids[i].SetY(y1);
            }

        }
    }
    //棋子十四
    class Chess14 : Chess
    {
        int No = 14;
        public Grid getAnchor()
        {
            return this.anchor;
        }
        Grid grid1 = new Grid(0, 2 * Grid.length);
        Grid grid2 = new Grid(Grid.length, 0);
        Grid grid3 = new Grid(Grid.length, Grid.length);
        Grid grid4 = new Grid(Grid.length, 2 * Grid.length);
        int count = 4;
        override
        public void Init()
        {
            grids.Add(getAnchor());
            grids.Add(grid1);
            grids.Add(grid2);
            grids.Add(grid4);
            grids.Add(grid3);
        }
        override
            public void Rotate()
        {
            //每个grid的坐标都乘一个旋转矩阵，且每次旋转度数为90度
            for (int i = 0; i < grids.Count; i++)
            {
                int x1 = -grids[i].GetX();
                int y1 = grids[i].GetY();
                grids[i].SetX(x1);
                grids[i].SetY(y1);
            }

        }
    }
    //棋子十五
    class Chess15 : Chess
    {
        int No = 15;
        public Grid getAnchor()
        {
            return this.anchor;
        }
        Grid grid1 = new Grid(0, Grid.length);
        Grid grid2 = new Grid(0, 2 * Grid.length);
        Grid grid3 = new Grid(0, 3 * Grid.length);
        Grid grid4 = new Grid(Grid.length, 2 * Grid.length);
        int count = 3;
        override
        public void Init()
        {
            grids.Add(getAnchor());
            grids.Add(grid3);
            grids.Add(grid4);
            grids.Add(grid1);
            grids.Add(grid2);
        }
        override
            public void Rotate()
        {
            //每个grid的坐标都乘一个旋转矩阵，且每次旋转度数为90度
            for (int i = 0; i < grids.Count; i++)
            {
                int x1 = -grids[i].GetX();
                int y1 = grids[i].GetY();
                grids[i].SetX(x1);
                grids[i].SetY(y1);
            }

        }
    }
    //棋子十六
    class Chess16 : Chess
    {
        int No = 16;
        public Grid getAnchor()
        {
            return this.anchor;
        }
        Grid grid1 = new Grid(Grid.length, 0);
        Grid grid2 = new Grid(Grid.length, Grid.length);
        Grid grid3 = new Grid(Grid.length, 2 * Grid.length);
        Grid grid4 = new Grid(2 * Grid.length, 0);
        int count = 3;
        override
        public void Init()
        {
            grids.Add(getAnchor());
            grids.Add(grid3);
            grids.Add(grid4);
            grids.Add(grid1);
            grids.Add(grid2);
        }
        override
            public void Rotate()
        {
            //每个grid的坐标都乘一个旋转矩阵，且每次旋转度数为90度
            for (int i = 0; i < grids.Count; i++)
            {
                int x1 = -grids[i].GetX();
                int y1 = grids[i].GetY();
                grids[i].SetX(x1);
                grids[i].SetY(y1);
            }

        }
    }
    //棋子十七
    class Chess17 : Chess
    {
        int No = 17;
        public Grid getAnchor()
        {
            return this.anchor;
        }
        Grid grid1 = new Grid(0, Grid.length);
        Grid grid2 = new Grid(0, 2 * Grid.length);
        Grid grid3 = new Grid(Grid.length, 0);
        Grid grid4 = new Grid(2 * Grid.length, 0);
        int count = 3;
        override
        public void Init()
        {
            grids.Add(getAnchor());
            grids.Add(grid2);
            grids.Add(grid4);
            grids.Add(grid1);
            grids.Add(grid3);
        }
        override
            public void Rotate()
        {
            //每个grid的坐标都乘一个旋转矩阵，且每次旋转度数为90度
            for (int i = 0; i < grids.Count; i++)
            {
                int x1 = -grids[i].GetX();
                int y1 = grids[i].GetY();
                grids[i].SetX(x1);
                grids[i].SetY(y1);
            }

        }
    }
    //棋子十八
    class Chess18 : Chess
    {
        int No = 18;
        public Grid getAnchor()
        {
            return this.anchor;
        }
        Grid grid1 = new Grid(-Grid.length, Grid.length);
        Grid grid2 = new Grid(0, Grid.length);
        Grid grid3 = new Grid(Grid.length, 0);
        Grid grid4 = new Grid(Grid.length, -Grid.length);
        int count = 5;
        override
        public void Init()
        {
            grids.Add(getAnchor());
            grids.Add(grid1);
            grids.Add(grid2);
            grids.Add(grid3);
            grids.Add(grid4);
        }
        override
            public void Rotate()
        {
            //每个grid的坐标都乘一个旋转矩阵，且每次旋转度数为90度
            for (int i = 0; i < grids.Count; i++)
            {
                int x1 = -grids[i].GetX();
                int y1 = grids[i].GetY();
                grids[i].SetX(x1);
                grids[i].SetY(y1);
            }

        }
    }
    //棋子十九
    class Chess19 : Chess
    {
        int No = 19;
        public Grid getAnchor()
        {
            return this.anchor;
        }
        Grid grid1 = new Grid(0, Grid.length);
        Grid grid2 = new Grid(Grid.length, 0);
        Grid grid3 = new Grid(2 * Grid.length, 0);
        Grid grid4 = new Grid(2 * Grid.length, -Grid.length);
        int count = 2;
        override
        public void Init()
        {
            grids.Add(getAnchor());
            grids.Add(grid4);
            grids.Add(grid1);
            grids.Add(grid2);
            grids.Add(grid3);
        }
        override
            public void Rotate()
        {
            //每个grid的坐标都乘一个旋转矩阵，且每次旋转度数为90度
            for (int i = 0; i < grids.Count; i++)
            {
                int x1 = -grids[i].GetX();
                int y1 = grids[i].GetY();
                grids[i].SetX(x1);
                grids[i].SetY(y1);
            }

        }
    }
    //棋子二十
    class Chess20 : Chess
    {
        int No = 20;
        public Grid getAnchor()
        {
            return this.anchor;
        }
        Grid grid1 = new Grid(0, Grid.length);
        Grid grid2 = new Grid(Grid.length, 0);
        Grid grid3 = new Grid(2 * Grid.length, 0);
        Grid grid4 = new Grid(Grid.length, -Grid.length);
        int count = 4;
        override
        public void Init()
        {
            grids.Add(getAnchor());
            grids.Add(grid1);
            grids.Add(grid3);
            grids.Add(grid4);
            grids.Add(grid2);
        }
        override
            public void Rotate()
        {
            //每个grid的坐标都乘一个旋转矩阵，且每次旋转度数为90度
            for (int i = 0; i < grids.Count; i++)
            {
                int x1 = -grids[i].GetX();
                int y1 = grids[i].GetY();
                grids[i].SetX(x1);
                grids[i].SetY(y1);
            }

        }
    }
    //棋子二十一
    class Chess21 : Chess
    {
        int No = 21;
        public Grid getAnchor()
        {
            return this.anchor;
        }
        Grid grid1 = new Grid(Grid.length, Grid.length);
        Grid grid2 = new Grid(Grid.length, 0);
        Grid grid3 = new Grid(Grid.length, -Grid.length);
        Grid grid4 = new Grid(2 * Grid.length, 0);
        int count = 4;
        override
    public void Init()
        {
            grids.Add(getAnchor());
            grids.Add(grid1);
            grids.Add(grid3);
            grids.Add(grid4);
            grids.Add(grid2);
        }
        //无需旋转
        override
        public void Rotate()
        {

        }
    }
}
