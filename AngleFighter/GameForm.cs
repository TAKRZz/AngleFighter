using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngleFighter
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
            DrawLinesForPanle();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            this.Width = 944;
            this.Height = 656;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        }

        private void DrawLinesForPanle()
        {
            Graphics g = this.chessPanel.CreateGraphics();
            Pen pen = Pens.Black;

            for(int count = 0; count < 19; count++)
            {
                g.DrawLine(pen,(this.chessPanel.Width / 20) * (count + 1),0, (this.chessPanel.Width / 20) * (count + 1),this.chessPanel.Height);
                g.DrawLine(pen, 0, (this.chessPanel.Height / 20) * (count + 1), this.chessPanel.Width, (this.chessPanel.Height / 20) * (count + 1));
            }
        }
    }
}
