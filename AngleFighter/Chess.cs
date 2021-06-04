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
    abstract class Chess
    {
        //棋子编号，用于棋子的唯一标识，在具体棋子当中，应该为每一个类棋子分配一个固定的编号
        private int No;

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
}
