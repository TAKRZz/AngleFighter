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
        public Client client;
        public Client[] clients = new Client[3];
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
    }
}
