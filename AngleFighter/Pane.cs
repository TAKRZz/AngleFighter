using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleFighter
{
    
    class Pane
    {
        // 棋盘大小 20 × 20

        int[,] pane = new int[20, 20];

        // 每一个 位置的属性
        // 0 代表 空
        // 1 代表 蓝
        // 2 代表 黄 
        // 3 代表 红
        // 4 代表 绿

        // Pane 的 初始化
        Pane()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int n = 0; n < 20; n++)
                {
                    pane[i, n] = 0;
                }
            }
        }

        // 在终端显示Pane
        void showPane()
        {
            for(int i = 0; i < 20; i++)
            {
                for(int n = 0; n < 20; n++)
                {
                    Console.Write(pane[i, n]+ "\t");
                }
                Console.Write("\n");
            }
        }

        // 在 Form 上显示 棋盘;
        void showPaneInForm() { }


        // 下棋
        bool makeMove() { return false; }

        // 检测算法
        bool isPlaceAble() { return false; }

        // Move 生成 string
        string moveToString() { return null; }

        
    }
}
