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
                //横线
                g.DrawLine(pen, new Point((Grid.length) * (count + 1), 0), new Point((Grid.length) * (count + 1), this.chessPanel.Height));
                //竖线
                g.DrawLine(pen, new Point(0, (Grid.length) * (count + 1)), new Point(this.chessPanel.Width, (Grid.length) * (count + 1)));
            }

        }

        private void chessPanel_MouseEnter(object sender, EventArgs e)
        {
            Down = true;
        }

        private void chessPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (Down)
            {
                AdjustChess(chessToDisPlay);
                
            }
        }

        private void AdjustChess(Chess chess)
        {
            //将棋子贴在最近的格子
            int x = chess.Location.X - this.chessPanel.Location.X;
            int y = chess.Location.Y - this.chessPanel.Location.Y;
            if (x % Grid.length < Grid.length / 2)
            {
                chess.Location = new Point(this.chessPanel.Location.X + ((x / Grid.length) * Grid.length), chess.Location.Y);
            }
            else
            {
                chess.Location = new Point(this.chessPanel.Location.X + ((x / Grid.length +1) * Grid.length), chess.Location.Y);
            }
            if (y % Grid.length < Grid.length / 2)
            {
                chess.Location = new Point(chess.Location.X,this.chessPanel.Location.Y + ((y / Grid.length) * Grid.length));
            }
            else
            {
                chess.Location = new Point(chess.Location.X, this.chessPanel.Location.Y + ((y / Grid.length +1) * Grid.length));
            }
      
        }

        private void Confirm_MouseDown(object sender, MouseEventArgs e)
        {
            Confirm.BackgroundImage = global::AngleFighter.Properties.Resources.Confirm2;
        }

        private void Round_MouseDown(object sender, MouseEventArgs e)
        {
            Round.BackgroundImage = global::AngleFighter.Properties.Resources.Round2;
        }

        private void Surrender_MouseDown(object sender, MouseEventArgs e)
        {
            Surrender.BackgroundImage = global::AngleFighter.Properties.Resources.Surrender2;
        }
    }
} 
