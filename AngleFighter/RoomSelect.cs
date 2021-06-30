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
    public partial class RoomSelect : Form
    {
        public Host host;
        public Client client;
        public Client[] clients = new Client[3];
        public RoomSelect()
        {
            InitializeComponent();
        }

        private void RoomSelect_Load(object sender, EventArgs e)
        {
            this.Width = 1416;
            this.Height = 984;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        }

        private void CreateRoomBtn_Click(object sender, EventArgs e)
        {
            Hide();
            RoomForm1 rm = new RoomForm1();

            rm.ShowDialog();
            this.Close();
        }

        private void JoinRoomBtn_Click(object sender, EventArgs e)
        {
            Hide();
            RoomIPForm iproom = new RoomIPForm();

            iproom.ShowDialog();
            this.Close();
        }

        private void HistoryOfGameBtn_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Hide();
            BeginForm bg = new BeginForm();

            bg.ShowDialog();
            this.Close();
        }

        private void setBtn_Click(object sender, EventArgs e)
        {
            SetForm srm = new SetForm();

            srm.ShowDialog();
        }

        private void CreateRoomBtn_MouseDown(object sender, MouseEventArgs e)
        {
            CreateRoomBtn.BackgroundImage = global::AngleFighter.Properties.Resources.CreatRoomBtn2;
        }

        private void JoinRoomBtn_MouseDown(object sender, MouseEventArgs e)
        {
            JoinRoomBtn.BackgroundImage = global::AngleFighter.Properties.Resources.JoinRoomBtn2;
        }

        private void BackBtn_MouseDown(object sender, MouseEventArgs e)
        {
            BackBtn.BackgroundImage = global::AngleFighter.Properties.Resources.BackBtn2;
        }
    }
}
