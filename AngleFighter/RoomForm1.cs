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
        public GameForm gameForm;
        public Host host;
        public RoomForm1()
        {
            InitializeComponent();
        }

        private void RoomForm1_Load(object sender, EventArgs e)
        {
            this.begin_btn.Enabled = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        }

        private void bgBtn_Click(object sender, EventArgs e)
        {
            Hide();
            host.StartGame();

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

        private void Host_IP_txt_Click(object sender, EventArgs e)
        {

        }
    }
}
