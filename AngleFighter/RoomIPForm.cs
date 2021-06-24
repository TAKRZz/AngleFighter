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
    public partial class RoomIPForm : Form
    {
        public RoomIPForm()
        {
            InitializeComponent();
        }

        private void RoomIPForm_Load(object sender, EventArgs e)
        {
            this.Width = 1416;
            this.Height = 984;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            Hide();
            RoomForm2 rm = new RoomForm2();

            rm.ShowDialog();
            this.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Hide();
            RoomSelect rm = new RoomSelect();

            rm.ShowDialog();
            this.Close();
        }
    }
}
