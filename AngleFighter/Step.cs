using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleFighter
{
    class Step
    {
        private Chess chess;
        private int order;

        public Step(Chess chess,int order)
        {
            this.chess = chess;
            this.order = order;
        }

        public override string ToString()
        {
            return chess.ToString() + order;
        }
    }
}
