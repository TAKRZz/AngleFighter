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
        private int count;

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
        public void initPosition(int x, int y)·
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
        public void SetNo(int no)
    {
        this.No = no;
    }
    public int GetCount()
    {
        return count;
    }
    public void SetCount(int c)
    {
        this.count = c;
    }


}
    //通过给anchor坐标赋值来确定棋子在棋盘上的位置，其他grid记录与anchor的相对位置来组成棋子
    //棋子一
    class Chess01 : Chess
    {
        override
            public void Init()
        {
        base.SetNo(1);
        base.SetCount(1);
        grids.Add(base.anchor);
        }
        //不需要旋转
        override
        public void Rotate()
        { }
    }
//棋子二
class Chess02 : Chess
{
    override
    public void Init()
    {
        base.SetNo(2);
        base.SetCount(2);
        grids.Add(base.anchor);
        grids.Add(new Grid(base.anchor.GetX(), base.anchor.GetY() + Grid.length));
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
    override
public void Init()
    {
        base.SetNo(3);
        base.SetCount(2);
        grids.Add(base.anchor);
        grids.Add(new Grid(base.anchor.GetX(), base.anchor.GetY() + 2 * Grid.length));
        grids.Add(new Grid(base.anchor.GetX(), base.anchor.GetY() + Grid.length));
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
    override
public void Init()
    {
        base.SetNo(4);
        base.SetCount(3);
        grids.Add(base.anchor);
        grids.Add(new Grid(base.anchor.GetX(), base.anchor.GetY() + Grid.length));
        grids.Add(new Grid(base.anchor.GetX() + Grid.length, base.anchor.GetY() + Grid.length));
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
    override
public void Init()
    {
        base.SetNo(5);
        base.SetCount(2);
        grids.Add(base.anchor);
        grids.Add(new Grid(base.anchor.GetX(), base.anchor.GetY() + 3 * Grid.length));
        grids.Add(new Grid(base.anchor.GetX(), base.anchor.GetY() + Grid.length));
        grids.Add(new Grid(base.anchor.GetX(), base.anchor.GetY() + 2 * Grid.length));
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
    override
public void Init()
    {
        base.SetNo(6);
        base.SetCount(3);
        grids.Add(base.anchor);
        grids.Add(new Grid(base.anchor.GetX() + Grid.length, base.anchor.GetY()));
        grids.Add(new Grid(base.anchor.GetX() + Grid.length, base.anchor.GetY() + 2 * Grid.length));
        grids.Add(new Grid(base.anchor.GetX() + Grid.length, base.anchor.GetY() + Grid.length));
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
    override
public void Init()
    {
        base.SetNo(7);
        base.SetCount(3);
        grids.Add(base.anchor);
        grids.Add(new Grid(base.anchor.GetX(), base.anchor.GetY() + 2 * Grid.length));
        grids.Add(new Grid(base.anchor.GetX() + Grid.length, base.anchor.GetY() + Grid.length));
        grids.Add(new Grid(base.anchor.GetX(), base.anchor.GetY() + 2 * Grid.length));
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
    override
public void Init()
    {
        base.SetNo(8);
        base.SetCount(4);
        grids.Add(base.anchor);
        grids.Add(new Grid(base.anchor.GetX(), base.anchor.GetY() + Grid.length));
        grids.Add(new Grid(base.anchor.GetX() + Grid.length, base.anchor.GetY()));
        grids.Add(new Grid(base.anchor.GetX() + Grid.length, base.anchor.GetY() + Grid.length));
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
    override
public void Init()
    {
        base.SetNo(9);
        base.SetCount(4);
        grids.Add(base.anchor);
        grids.Add(new Grid(base.anchor.GetX() + Grid.length, base.anchor.GetY()));
        grids.Add(new Grid(base.anchor.GetX() + Grid.length, base.anchor.GetY() - Grid.length));
        grids.Add(new Grid(base.anchor.GetX() + 2 * Grid.length, base.anchor.GetY() -Grid.length));
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
    override
    public void Init()
    {
        base.SetNo(10);
        base.SetCount(2);
        grids.Add(base.anchor);
        grids.Add(new Grid(base.anchor.GetX(), base.anchor.GetY() + 4 * Grid.length));
        grids.Add(new Grid(base.anchor.GetX(), base.anchor.GetY() + Grid.length));
        grids.Add(new Grid(base.anchor.GetX(), base.anchor.GetY() + 2 * Grid.length));
        grids.Add(new Grid(base.anchor.GetX(), base.anchor.GetY() + 3 * Grid.length));
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
    override
    public void Init()
    {
        base.SetNo(11);
        base.SetCount(3);
        grids.Add(base.anchor);
        grids.Add(new Grid(base.anchor.GetX() + Grid.length, base.anchor.GetY()));
        grids.Add(new Grid(base.anchor.GetX(), base.anchor.GetY() + Grid.length));
        grids.Add(new Grid(base.anchor.GetX(), base.anchor.GetY() + 2 * Grid.length));
        grids.Add(new Grid(base.anchor.GetX(), base.anchor.GetY() + 3 * Grid.length));
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
    override
    public void Init()
    {
        base.SetNo(12);
        base.SetCount(4);
        grids.Add(base.anchor);
        grids.Add(new Grid(base.anchor.GetX(), base.anchor.GetY() + Grid.length));
        grids.Add(new Grid(base.anchor.GetX() + Grid.length, base.anchor.GetY() + Grid.length));
        grids.Add(new Grid(base.anchor.GetX() + Grid.length, base.anchor.GetY() + 3 * Grid.length));
        grids.Add(new Grid(base.anchor.GetX() + Grid.length, base.anchor.GetY() + 2 * Grid.length));
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
    override
    public void Init()
    {
        base.SetNo(13);
        base.SetCount(4);
        grids.Add(base.anchor);
        grids.Add(new Grid(base.anchor.GetX(), base.anchor.GetY() + Grid.length));
        grids.Add(new Grid(base.anchor.GetX() + Grid.length, base.anchor.GetY()));
        grids.Add(new Grid(base.anchor.GetX() + Grid.length, base.anchor.GetY() + 2 * Grid.length));
        grids.Add(new Grid(base.anchor.GetX() + Grid.length, base.anchor.GetY() + Grid.length));
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
    override
    public void Init()
    {
        base.SetNo(14);
        base.SetCount(4);
        grids.Add(base.anchor);
        grids.Add(new Grid(base.anchor.GetX(), base.anchor.GetY() + 2 * Grid.length));
        grids.Add(new Grid(base.anchor.GetX() + Grid.length, base.anchor.GetY()));
        grids.Add(new Grid(base.anchor.GetX() + Grid.length, base.anchor.GetY() + 2 * Grid.length));
        grids.Add(new Grid(base.anchor.GetX() + Grid.length, base.anchor.GetY() + Grid.length));
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
    override
    public void Init()
    {
        base.SetNo(15);
        base.SetCount(3);
        grids.Add(base.anchor);
        grids.Add(new Grid(base.anchor.GetX(), base.anchor.GetY() + 3 * Grid.length));
        grids.Add(new Grid(base.anchor.GetX() + Grid.length, base.anchor.GetY() + 2 * Grid.length));
        grids.Add(new Grid(base.anchor.GetX(), base.anchor.GetY() + Grid.length));
        grids.Add(new Grid(base.anchor.GetX(), base.anchor.GetY() + 2 * Grid.length));
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
    override
    public void Init()
    {
        base.SetNo(16);
        base.SetCount(3);
        grids.Add(base.anchor);
        grids.Add(new Grid(base.anchor.GetX() + Grid.length, base.anchor.GetY() + 2 * Grid.length));
        grids.Add(new Grid(base.anchor.GetX() + 2 * Grid.length, base.anchor.GetY()));
        grids.Add(new Grid(base.anchor.GetX() + Grid.length, base.anchor.GetY()));
        grids.Add(new Grid(base.anchor.GetX() + Grid.length, base.anchor.GetY() + Grid.length));
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
    override
    public void Init()
    {
        base.SetNo(17);
        base.SetCount(3);
        grids.Add(base.anchor);
        grids.Add(new Grid(base.anchor.GetX(), base.anchor.GetY() + 2 * Grid.length));
        grids.Add(new Grid(base.anchor.GetX() + 2 * Grid.length, base.anchor.GetY()));
        grids.Add(new Grid(base.anchor.GetX(), base.anchor.GetY() + Grid.length));
        grids.Add(new Grid(base.anchor.GetX() + Grid.length, base.anchor.GetY()));
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
    override
    public void Init()
    {
        base.SetNo(18);
        base.SetCount(5);
        grids.Add(base.anchor);
        grids.Add(new Grid(base.anchor.GetX() - Grid.length, base.anchor.GetY() + Grid.length));
        grids.Add(new Grid(base.anchor.GetX(), base.anchor.GetY() + Grid.length));
        grids.Add(new Grid(base.anchor.GetX() + Grid.length, base.anchor.GetY()));
        grids.Add(new Grid(base.anchor.GetX() + Grid.length, base.anchor.GetY() - Grid.length));
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
    override
    public void Init()
    {
        base.SetNo(19);
        base.SetCount(2);
        grids.Add(base.anchor);
        grids.Add(new Grid(base.anchor.GetX() + 2 * Grid.length, base.anchor.GetY() - Grid.length));
        grids.Add(new Grid(base.anchor.GetX(), base.anchor.GetY() + Grid.length));
        grids.Add(new Grid(base.anchor.GetX() + Grid.length, base.anchor.GetY()));
        grids.Add(new Grid(base.anchor.GetX() + 2 * Grid.length, base.anchor.GetY()));
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
    override
    public void Init()
    {
        base.SetNo(20);
        base.SetCount(4);
        grids.Add(base.anchor);
        grids.Add(new Grid(base.anchor.GetX(), base.anchor.GetY() + Grid.length));
        grids.Add(new Grid(base.anchor.GetX() + 2 * Grid.length, base.anchor.GetY()));
        grids.Add(new Grid(base.anchor.GetX() + Grid.length, base.anchor.GetY() - Grid.length));
        grids.Add(new Grid(base.anchor.GetX() + Grid.length, base.anchor.GetY()));
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
        override
    public void Init()
        {
        base.SetNo(21);
        base.SetCount(4);
        grids.Add(base.anchor));
            grids.Add(new Grid(base.anchor.GetX()+Grid.length, base.anchor.GetY()+Grid.length));
            grids.Add(new Grid(base.anchir.GetX()+Grid.length, base.anchor.GetY()-Grid.length));
            grids.Add(new Grid(base.anchor.GetX() + 2 * Grid.length, base.anchor.GetY()));
            grids.Add(new Grid(base.anchor.GetX() + Grid.length, base.anchor.GetY()));
        }
        //无需旋转
        override
        public void Rotate()
        {

        }
    }
}
