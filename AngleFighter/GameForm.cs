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
        private Chess chessToDisPlay;//容器中要展示的panel
        private bool Down = false;//用于检测控件是否进去容器边界

        public GameForm()
        {
            InitializeComponent();
            DrawLinesForPanle();
            chessToDisPlay = P.GetChesses()[current];
            chessToDisPlay.Location = new Point(this.chessContainer.Width / 2, this.chessContainer.Height / 2);
            this.chessContainer.Controls.Add(chessToDisPlay);
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
            GraphicsPath gp = new GraphicsPath();

            for(int count = 0; count < 19; count++)
            {
                gp.AddLine(new Point((this.chessPanel.Width / 20) * (count + 1), 0), new Point((this.chessPanel.Width / 20) * (count + 1), this.chessPanel.Height));
                gp.AddLine(new Point(0, (this.chessPanel.Height / 20) * (count + 1)), new Point(this.chessPanel.Width, (this.chessPanel.Height / 20) * (count + 1)));
            }
            gp.CloseAllFigures();
            g.DrawPath(pen,gp);

        }

        private void chessPanel_DragDrop(object sender, DragEventArgs e)
        {
            Chess chess = (Chess)e.Data.GetData(typeof(Chess));
            ((Panel)sender).Controls.Add(chess);
            if (Down&&chess.m_clicked)
            {
                if (P.GetPane().isPlaceAble(P.GetPane().AdjustChess(chess)))
                {
                    P.PlayChess(chess);
                    ((Panel)sender).Controls.Add(chess);
                    Down = false;
                }
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.chessContainer.Controls.Remove(chessToDisPlay);
            current = (current + P.GetChesses().Count -1) % P.GetChesses().Count;
            chessToDisPlay = P.GetChesses()[current];
            chessToDisPlay.Location = new Point(this.chessContainer.Width / 2, this.chessContainer.Height / 2);
            this.chessContainer.Controls.Add(chessToDisPlay);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.chessContainer.Controls.Remove(chessToDisPlay);
            current = (current + 1) % P.GetChesses().Count;
            chessToDisPlay = P.GetChesses()[current];
            chessToDisPlay.Location = new Point(this.chessContainer.Width / 2, this.chessContainer.Height / 2);
            this.chessContainer.Controls.Add(chessToDisPlay);
            
        }

        private void chessPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
            Down = true;
        }

        private void chessContainer_DragLeave(object sender, EventArgs e)
        {

        }
    }
} 
