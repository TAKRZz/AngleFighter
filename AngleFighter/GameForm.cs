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
    public partial class GameForm : Form
    {
        public Player P = new Host();//玩家对象，加入房间时进行绑定
        int current = 0;
        private Chess chessToDisPlay;//容器中要展示的chess
        private bool Down = false;//用于检测控件是否进去容器边界

        public GameForm()
        {
            InitializeComponent();
            chessToDisPlay = P.GetChesses()[current];
            chessToDisPlay.Location = new Point(this.chessContainer.Location.X+this.chessContainer.Width / 2, this.chessContainer.Location.Y+this.chessContainer.Height / 2);
            this.Controls.Add(chessToDisPlay);
            chessToDisPlay.BringToFront();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            this.Width = 944;
            this.Height = 656;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(chessToDisPlay);
            
            current = (current + P.GetChesses().Count -1) % P.GetChesses().Count;
            chessToDisPlay = P.GetChesses()[current];
            chessToDisPlay.Location = new Point(this.chessContainer.Location.X + this.chessContainer.Width / 2, this.chessContainer.Location.Y + this.chessContainer.Height / 2);
            this.Controls.Add(chessToDisPlay);
            chessToDisPlay.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(chessToDisPlay);
            this.
            current = (current + 1) % P.GetChesses().Count;
            chessToDisPlay = P.GetChesses()[current];
            chessToDisPlay.Location = new Point(this.chessContainer.Location.X + this.chessContainer.Width / 2, this.chessContainer.Location.Y + this.chessContainer.Height / 2);
            this.Controls.Add(chessToDisPlay);
            chessToDisPlay.BringToFront();
            
        }


        private void chessPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.chessPanel.CreateGraphics();
            Pen pen = Pens.Black;

            for (int count = 0; count < 19; count++)
            {
                g.DrawLine(pen, new Point((this.chessPanel.Width / 20) * (count + 1), 0), new Point((this.chessPanel.Width / 20) * (count + 1), this.chessPanel.Height));
                g.DrawLine(pen, new Point(0, (this.chessPanel.Height / 20) * (count + 1)), new Point(this.chessPanel.Width, (this.chessPanel.Height / 20) * (count + 1)));
            }

        }

        private void chessPanel_Enter(object sender, EventArgs e)
        {
            Down = true;
        }

        private void GameForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (Down)
            {
                if (P.GetPane().isPlaceAble(P.GetPane().AdjustChess(chessToDisPlay)))
                {
                    P.PlayChess(chessToDisPlay);
                    this.Controls.Remove(chessToDisPlay);
                    chessToDisPlay.Location = this.chessPanel.PointToClient(chessToDisPlay.Location);
                    this.chessPanel.Controls.Add(chessToDisPlay);

                    button2_Click(sender,e);
                }
                chessToDisPlay.Location = new Point(this.chessContainer.Location.X + this.chessContainer.Width / 2, this.chessContainer.Location.Y + this.chessContainer.Height / 2);
            }
        }
    }
} 
