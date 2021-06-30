using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleFighter;

namespace test
{
    class Program
    {
        private static int X = 209;
        private static int Y = 155;
        static void Main(string[] args)
        {
            Pane pane = new Pane();
            Console.WriteLine(pane.GetGrid(209,155));
            Console.WriteLine()
            Console.ReadKey();
        }

        private static  void InitPosition(int x, int y)
        {
            int offsetX = x - X;
            int offsetY = y - Y;

            X = X + offsetX;
            Y = Y + offsetY;
        }
    }
}
