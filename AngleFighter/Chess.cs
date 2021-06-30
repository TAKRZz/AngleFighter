/*
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngleFighter
{
    //抽象棋子，用于各种棋子的统一模板
    public abstract class Chess : Button
    {
        //棋子编号，用于棋子的唯一标识，在具体棋子当中，应该为每一个类棋子分配一个固定的编号
        private int No;

        //用来记录位于边角的格子的个数
        public int count;

        // 记录格子的颜色
        public int color;

        //棋子方向，用于旋转棋子
        int direction;
        /*UP = 0;
        LEFT = 1;
        DOWN = 2;
        RIGHT = 3;*/

        //棋子锚点，用于限定整个棋子的初始位置和颜色
        public Grid anchor = new Grid();

        //棋子集合，用于表示棋子
        public List<Grid> grids = new List<Grid>();

        //棋子初始化的方法，利用锚点的确定整个棋子的位置,在棋子的构造函数当中需要调用该方法
        public abstract void Init();
        //为棋子设置颜色
        public void InitColor(int x)
        {
            this.color = x;
            for (int i = 0; i < grids.Count; i++)
            {
                grids[i].SetColor(x);
                Invalidate();
            }

        }

        //旋转棋子
        public void Rotate()
        {
            //每个grid的坐标都乘一个旋转矩阵，且每次旋转度数为90度
            for (int i = 0; i < grids.Count; i++)
            {
                int x1 = -grids[i].GetX();
                int y1 = grids[i].GetY();
                grids[i].SetX(x1);
                grids[i].SetY(y1);
                direction = (direction +1)%4;
                this.Invalidate();
            }
        }

        //通过锚点初始化棋子在棋盘上的坐标数据
        public void InitPosition(int x, int y)
        {
            //获得坐标偏移量
            int offsetX = x - anchor.GetX();
            int offsetY = y - anchor.GetY();

            //变化坐标
            foreach(Grid grid in grids)
            {
                grid.SetX(grid.GetX() + offsetX);
                grid.SetX(grid.GetY() + offsetY);
            }
        }

        //棋子的ToString方法
        public override string ToString()
        {
            return anchor.ToString() + direction+ " "  + No ;
        }

        //提供棋子编号的查询
        public int GetNo()
        {
            return No;
        }

        public void SetNo(int no)
        {
            No = no;
        }

        //重写鼠标方法，用于实现拖拽
        private Point m_MousePoint;
        private Point m_LastPoint;//记录鼠标按下的位置
        public bool m_clicked = false;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            this.m_LastPoint = this.Location; 
            this.m_MousePoint = this.PointToScreen(e.Location);
            /*this.DoDragDrop(this,DragDropEffects.Move);*/
            m_clicked = true;    
        }


        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (m_clicked)
            {
                base.OnMouseMove(e);
                if (e.Button == MouseButtons.Left)
                {
                    Point t = this.PointToScreen(e.Location);
                    Point l = this.m_LastPoint;

                    l.Offset(t.X - this.m_MousePoint.X, t.Y - this.m_MousePoint.Y);
                    this.Location = l;
                }
            }
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            this.m_clicked = false;
        }

        //画棋子的方法
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Image img = null;
            switch (color)
            {
                case 0:
                    img = null;
                    break;
                case 1:
                    img = Image.FromFile("C:\\Users\\24962\\Documents\\GitHub\\AngleFighter\\AngleFighter\\Resources\\BlueGrid.png");
                    break;
                case 2:
                    img = Image.FromFile("C:\\Users\\24962\\Documents\\GitHub\\AngleFighter\\AngleFighter\\Resources\\YellowGrid.png");
                    break;
                case 3:
                    img = Image.FromFile("C:\\Users\\24962\\Documents\\GitHub\\AngleFighter\\AngleFighter\\Resources\\GreenGrid.png");
                    break;
                case 4:
                    img = Image.FromFile("C:\\Users\\24962\\Documents\\GitHub\\AngleFighter\\AngleFighter\\Resources\\RedGrid.png");
                    break;
            }

            Graphics g = e.Graphics;
            GraphicsPath gp = new GraphicsPath();

            foreach (Grid grid in grids)
            {
                gp.AddRectangle(new RectangleF(grid.GetX(), grid.GetY(), Grid.length, Grid.length));
                g.DrawImage(img,grid.GetX(), grid.GetY(), Grid.length, Grid.length);
            }

            this.Region = new Region(gp);
            this.Size = Parent.Size;
        }



        //根据棋子编号得到相应的棋子类
        public static Chess GetChess(int no)
        {
            switch (no)
            {
                case 1:
                    return new Chess01();
                case 2:
                    return new Chess02();
                case 3:
                    return new Chess03();
                case 4:
                    return new Chess04();
                case 5:
                    return new Chess05();
                case 6:
                    return new Chess06();
                case 7:
                    return new Chess07();
                case 8:
                    return new Chess08();
                case 9:
                    return new Chess09();
                case 10:
                    return new Chess10();
                case 11:
                    return new Chess11();
                case 12:
                    return new Chess12();
                case 13:
                    return new Chess13();
                case 14:
                    return new Chess14();
                case 15:
                    return new Chess15();
                case 16:
                    return new Chess16();
                case 17:
                    return new Chess17();
                case 18:
                    return new Chess18();
                case 19:
                    return new Chess19();
                case 20:
                    return new Chess20();
                case 21:
                    return new Chess21();
                default:
                    return null;
            }
        }
    }

    //通过给anchor坐标赋值来确定棋子在棋盘上的位置，其他grid记录与anchor的相对位置来组成棋子
    //棋子一
    class Chess01 : Chess
    {
        public Chess01()
        {
            Init();
        }

        public override void Init()
        {
            base.SetNo(1);
            base.count = 1;
            grids.Add(base.anchor);
        }

        
    }
    //棋子二
    class Chess02 : Chess
    {
        public Chess02()
        {
            Init();
        }
        public override void Init()
        {
            base.SetNo(2);
            base.count = 2;
            grids.Add(base.anchor);
            grids.Add(new Grid(anchor.GetX(), anchor.GetY()+Grid.length));
        }

    }

    //棋子三
    class Chess03 : Chess
    {
        public Chess03()
        {
            Init();
        }
        public override void Init()
        {
            base.SetNo(3);
            base.count = 2;
            grids.Add(base.anchor);
            grids.Add(new Grid(base.anchor.GetX()+Grid.length, base.anchor.GetY()));
        }

    }
    //棋子四
    class Chess04 : Chess
    {
        public Chess04()
        {
            Init();
        }
        public override void Init()
        {
            base.SetNo(4);
            base.count = 3;
            grids.Add(base.anchor);
            grids.Add(new Grid(base.anchor.GetX(), base.anchor.GetY() + Grid.length));
            grids.Add(new Grid(base.anchor.GetX() + Grid.length, base.anchor.GetY() + Grid.length));
        }
    }
    //棋子五
    class Chess05 : Chess
    {
        public Chess05()
        {
            Init();
        }
        public override void Init()
        {
            base.SetNo(5);
            base.count = 2;
            grids.Add(base.anchor);
            grids.Add(new Grid(anchor.GetX(), anchor.GetY() + 3 * Grid.length));
            grids.Add(new Grid(anchor.GetX(), anchor.GetY() + Grid.length));
            grids.Add(new Grid(anchor.GetX(), anchor.GetY() + 2 * Grid.length));
        }
        
    }
    //棋子六
    class Chess06 : Chess
    {
        public Chess06()
        {
            Init();
        }
        public override void Init()
        {
            base.SetNo(6);
            count = 3;
            grids.Add(anchor);
            grids.Add(new Grid(anchor.GetX() + Grid.length, anchor.GetY()));
            grids.Add(new Grid(anchor.GetX() + Grid.length, anchor.GetY() + 2 * Grid.length));
            grids.Add(new Grid(anchor.GetX() + Grid.length, anchor.GetY() + Grid.length));
        }

    }
    //棋子七
    class Chess07 : Chess
    {
        public Chess07()
        {
            Init();
        }
        public override void Init()
        {
            SetNo(7);
            count = 3;
            grids.Add(anchor);
            grids.Add(new Grid(anchor.GetX(), anchor.GetY() + 2 * Grid.length));
            grids.Add(new Grid(anchor.GetX() + Grid.length, anchor.GetY() + Grid.length));
            grids.Add(new Grid(anchor.GetX(), anchor.GetY() + Grid.length));
        }

    }
    //棋子八
    class Chess08 : Chess
    {
        public Chess08()
        {
            Init();
        }
        public override void Init()
        {
            SetNo(8);
            count = 4;
            grids.Add(anchor);
            grids.Add(new Grid(anchor.GetX(), anchor.GetY() + Grid.length));
            grids.Add(new Grid(anchor.GetX() + Grid.length, anchor.GetY()));
            grids.Add(new Grid(anchor.GetX() + Grid.length, anchor.GetY() + Grid.length));
        }
    }
    //棋子九
    class Chess09 : Chess
    {
        public Chess09()
        {
            Init();
        }
        public override void Init()
        {
            SetNo(9);
            count = 4;
            grids.Add(anchor);
            grids.Add(new Grid(anchor.GetX() + Grid.length, anchor.GetY()));
            grids.Add(new Grid(anchor.GetX() + Grid.length, anchor.GetY() - Grid.length));
            grids.Add(new Grid(anchor.GetX()+2*Grid.length,anchor.GetY()-Grid.length));
        }
    }
    //棋子十
    class Chess10 : Chess
    {
        public Chess10()
        {
            Init();
        }
        public override void Init()
        {
            SetNo(10);
            count = 2;
            grids.Add(anchor);
            grids.Add(new Grid(anchor.GetX(), anchor.GetY() + 4 * Grid.length));
            grids.Add(new Grid(anchor.GetX(), anchor.GetY() + Grid.length));
            grids.Add(new Grid(anchor.GetX(), anchor.GetY() + 2 * Grid.length));
            grids.Add(new Grid(anchor.GetX(), anchor.GetY() + 3 * Grid.length));
        }
    }
    //棋子十一
    class Chess11 : Chess
    {
        public Chess11()
        {
            Init();
        }
        public override void Init()
        {
            SetNo(11);
            count = 3;
            grids.Add(anchor);
            grids.Add(new Grid(anchor.GetX() + Grid.length, anchor.GetY()));
            grids.Add(new Grid(anchor.GetX(), anchor.GetY() + Grid.length));
            grids.Add(new Grid(anchor.GetX(), anchor.GetY() + 2 * Grid.length));
            grids.Add(new Grid(anchor.GetX(), anchor.GetY() + 3 * Grid.length));
        }

    }
    //棋子十二
    class Chess12 : Chess
    {
        public Chess12()
        {
            Init();
        }
        public override void Init()
        {
            SetNo(12);
            count = 4;
            grids.Add(anchor);
            grids.Add(new Grid(anchor.GetX(), anchor.GetY() +Grid.length));
            grids.Add(new Grid(anchor.GetX() + Grid.length, anchor.GetY() + Grid.length));
            grids.Add(new Grid(anchor.GetX() + Grid.length, anchor.GetY() + 3 * Grid.length));
            grids.Add(new Grid(anchor.GetX() + Grid.length, anchor.GetY() + 2 * Grid.length));
        }

    }
    //棋子十三
    class Chess13 : Chess
    {
        public Chess13()
        {
            Init();
        }
        public override void Init()
        {
            SetNo(13);
            count = 4;
            grids.Add(anchor);
            grids.Add(new Grid(anchor.GetX(), anchor.GetY() + Grid.length));
            grids.Add(new Grid(anchor.GetX() + Grid.length, anchor.GetY()));
            grids.Add(new Grid(anchor.GetX() + Grid.length, anchor.GetY() + 2 *  Grid.length));
            grids.Add(new Grid(anchor.GetX() + Grid.length, anchor.GetY() + Grid.length));
        }
    }
    //棋子十四
    class Chess14 : Chess
    {
        public Chess14()
        {
            Init();
        }
        public override void Init()
        {
            SetNo(14);
            count = 4;
            grids.Add(anchor);
            grids.Add(new Grid(anchor.GetX(), anchor.GetY() + Grid.length * 2));
            grids.Add(new Grid(anchor.GetX() + Grid.length, anchor.GetY()));
            grids.Add(new Grid(anchor.GetX() + Grid.length, anchor.GetY() + Grid.length * 2));
            grids.Add(new Grid(anchor.GetX() + Grid.length, anchor.GetY() + Grid.length));
        }
        
    }
    //棋子十五
    class Chess15 : Chess
    {
        public Chess15()
        {
            Init();
        }
        public override void Init()
        {
            SetNo(15);
            count = 3;
            grids.Add(anchor);
            grids.Add(new Grid(anchor.GetX() + Grid.length, anchor.GetY() + Grid.length * 3));
            grids.Add(new Grid(anchor.GetX(), anchor.GetY() + Grid.length * 3));
            grids.Add(new Grid(anchor.GetX(), anchor.GetY() + Grid.length));
            grids.Add(new Grid(anchor.GetX(), anchor.GetY() + Grid.length * 2));
        }
  
    }
    //棋子十六
    class Chess16 : Chess
    {
        public Chess16()
        {
            Init();
        }
        public override void Init()
        {
            SetNo(16);
            count = 3;
            grids.Add(anchor);
            grids.Add(new Grid(anchor.GetX() + Grid.length, anchor.GetY() + Grid.length * 2));
            grids.Add(new Grid(anchor.GetX() + 2 * Grid.length, anchor.GetY()));
            grids.Add(new Grid(anchor.GetX() + Grid.length, anchor.GetY()));
            grids.Add(new Grid(anchor.GetX() + Grid.length, anchor.GetY()+ Grid.length));
        }

    }
    //棋子十七
    class Chess17 : Chess
    {
        public Chess17()
        {
            Init();
        }
        public override void Init()
        {
            SetNo(17);
            count = 3;
            grids.Add(anchor);
            grids.Add(new Grid(anchor.GetX(), anchor.GetY() + 2 * Grid.length));
            grids.Add(new Grid(anchor.GetX() + 2 * Grid.length, anchor.GetY()));
            grids.Add(new Grid(anchor.GetX(), anchor.GetY() + Grid.length));
            grids.Add(new Grid(anchor.GetX() + Grid.length, anchor.GetY()));
        }

    }
    //棋子十八
    class Chess18 : Chess
    {
        public Chess18()
        {
            Init();
        }
        public override void Init()
        {
            SetNo(18);
            count = 5;
            grids.Add(anchor);
            grids.Add(new Grid(anchor.GetX()-Grid.length,anchor.GetY()+Grid.length));
            grids.Add(new Grid(anchor.GetX(), anchor.GetY() + Grid.length));
            grids.Add(new Grid(anchor.GetX() + Grid.length, anchor.GetY()));
            grids.Add(new Grid(anchor.GetX() + Grid.length, anchor.GetY() - Grid.length));
        }

    }
    //棋子十九
    class Chess19 : Chess
    {
        public Chess19()
        {
            Init();
        }
        public override void Init()
        {
            SetNo(19);
            count = 2;
            grids.Add(anchor);
            grids.Add(new Grid(anchor.GetX() + Grid.length * 2, anchor.GetY() - Grid.length));
            grids.Add(new Grid(anchor.GetX(), anchor.GetY() + Grid.length));
            grids.Add(new Grid(anchor.GetX() + Grid.length, anchor.GetY()));
            grids.Add(new Grid(anchor.GetX() + Grid.length * 2, anchor.GetY()));
        }

    }
    //棋子二十
    class Chess20 : Chess
    {
        public Chess20()
        {
            Init();
        }
        public override void Init()
        {
            SetNo(20);
            count = 4;
            grids.Add(anchor);
            grids.Add(new Grid(anchor.GetX(),anchor.GetY()+ Grid.length));
            grids.Add(new Grid(anchor.GetX()+ 2 * Grid.length, anchor.GetY()));
            grids.Add(new Grid(anchor.GetX() + Grid.length, anchor.GetY() - Grid.length));
            grids.Add(new Grid(Grid.length + anchor.GetX(), anchor.GetY()));
        }

    }
    //棋子二十一
    class Chess21 : Chess
    {
    public Chess21()
        {
            Init();
        }
        public override void Init()
        {
            SetNo(21);
            count = 4;
            grids.Add(anchor);
            grids.Add(new Grid(Grid.length + anchor.GetX(), Grid.length + anchor.GetY()));
            grids.Add(new Grid(anchor.GetX()+Grid.length,anchor.GetY()-Grid.length));
            grids.Add(new Grid(anchor.GetX() + Grid.length * 2, anchor.GetY()));
            grids.Add(new Grid(anchor.GetX()+Grid.length,anchor.GetY()));
        }

    }
}
*/