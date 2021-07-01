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
    public partial class RoomIPForm : Form
    {
        Client client;
        public RoomIPForm()
        {
            InitializeComponent();
        }
        public RoomIPForm(string name)
        {
            this.name = name;
            InitializeComponent();
        }

        private string name;

        private void RoomIPForm_Load(object sender, EventArgs e)
        {
            this.Width = 944;
            this.Height = 656;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            Hide();

            client = new Client(name, this.IP_txt.Text);

            client.start();
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
