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
    public partial class BeginForm : Form
    {
        public BeginForm()
        {
            InitializeComponent();
        }

        private void BeginForm_Load(object sender, EventArgs e)
        {
            this.Width = 944;
            this.Height = 656;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        }

        private void BeginBtn_Click(object sender, EventArgs e)
        {
            // BeginBtn.BackgroudImage = "BeginBtn.png";
            //BeginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            //BeginBtn.Location = new System.Drawing.Point(800,400);
            Hide();
            RoomSelect rooms = new RoomSelect();

            rooms.ShowDialog();
            this.Close();

        }

        

        private void Begin(object sender, EventArgs e)
        {
            //this.Width = 944;
            //this.Height = 656;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        }

        private void setBtn_Click(object sender, EventArgs e)
        {
            //BeginBtn.Location = new System.Drawing.Point(800,400);
            
            SetForm srm = new SetForm();

            srm.ShowDialog();
            
        }
    }
}
