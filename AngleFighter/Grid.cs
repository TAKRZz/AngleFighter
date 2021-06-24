using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleFighter
{
    //格子类，用于表示棋子和棋盘的简单结构
   public class Grid
    {
        //横纵坐标
        private int x;
        private int y;

        //颜色
        const int EMPTY = 0;
        const int BLUE = 1;
        const int YELLOW = 2;
        const int RED = 3;
        const int GREEN = 4;

        int color;

        //格子边长，用于定义格子大小,假设是25像素，根据具体窗体大小进行调整
        public static int length = 25;

        public Grid()
        {
            this.x = 0;
            this.y = 0;
            this.color = EMPTY;
        }

        public Grid(int x,int y)
        {
            this.x = x;
            this.y = y;
            this.color = EMPTY;
        }

        public Grid(int x, int y,int color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }

        //坐标的Set Get
        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }

        public void SetX(int x)
        {
            this.x = x;
        }

        public void SetY(int y)
        {
            this.y = y;
        }

        //设置颜色的接口
        public void SetColor(int color)
        {
            this.color = color;
        }

        public int GetColor()
        {
            return this.color;
        }

        public override string ToString()
        {
            return Convert.ToString(this.x) + Convert.ToString(this.y) + Convert.ToString(this.color);
        }
    }
}
