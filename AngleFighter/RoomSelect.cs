using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngleFighter
{
    public partial class RoomSelect : Form
    {
        public RoomSelect()
        {
            InitializeComponent();
        }


        private void RoomSelect_Load(object sender, EventArgs e)
        {
            this.Width = 944;
            this.Height = 656;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        }

        private void CreateRoomBtn_Click(object sender, EventArgs e)
        {

            Hide();
            Host host = new Host();
            host.name = "Host";
            if (playerName_txt.Text != null)
            {
                host.name = playerName_txt.Text;
            }
            RoomForm1 roomForm1 = new RoomForm1();
            roomForm1.host = host;
            roomForm1.IPAddress_txt.Text = host.IP;
            roomForm1.Host_name_txt.Text = host.name;
            host.roomForm1 = roomForm1;
            roomForm1.bgBtn.Enabled = false;
            host.creRoom();
            roomForm1.roomSelect = this;
            roomForm1.ShowDialog();
        }



        private void JoinRoomBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Client client = new Client();
            client.name = "Player";

            if (playerName_txt.Text != null) 
            client.name = this.playerName_txt.Text;

            RoomIPForm iproom = new RoomIPForm();
            iproom.client = client;
            iproom.roomSelect = this;
            iproom.ShowDialog();

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

        private void playerName_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
