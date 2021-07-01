﻿using System;
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
            this.Hide();
            host = new Host(this.Name_txt.Text);
            host.roomForm1.host = host;
            host.roomForm1.gameForm = host.gameForm;
            host.creRoom();
            
        }

        private void JoinRoomBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomIPForm roomIPForm = new RoomIPForm(this.Name_txt.Text);
            roomIPForm.ShowDialog();
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

        private void Name_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
