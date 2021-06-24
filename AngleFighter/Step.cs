/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleFighter
{
    class Step
    {
        public Chess chess;
        public int order;
        public int color;
        public Step(Chess chess,int order)
        {
            this.chess = chess;
            this.order = order;
            this.color = chess.color;
        }

        public override string ToString()
        {
            return chess.ToString() + order;
        }
        
        public Step(string str)
        {
            // 缺一个实现
        }
    }
}
*/