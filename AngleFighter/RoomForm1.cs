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
    public partial class RoomForm1 : Form
    {
        public RoomForm1()
        {
            InitializeComponent();
        }

        private void RoomForm1_Load(object sender, EventArgs e)
        {
            this.Width = 1416;
            this.Height = 984;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        }

        private void bgBtn_Click(object sender, EventArgs e)
        {
            Hide();
            GameForm rm = new GameForm();

            rm.ShowDialog();
            this.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Hide();
            RoomSelect rm = new RoomSelect();

            rm.ShowDialog();
            this.Close();
        }

        private void setBtn_Click(object sender, EventArgs e)
        {
            SetForm srm = new SetForm();

            srm.ShowDialog();
        }
    }
}
