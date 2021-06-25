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
    public partial class RoomForm2 : Form
    {
        public RoomForm2()
        {
            InitializeComponent();
        }

        private void RoomForm2_Load(object sender, EventArgs e)
        {
            this.Width = 944;
            this.Height = 656;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        }
        public RoomSelect roomSelect;

        private void backBtn_Click(object sender, EventArgs e)
        {
            Hide();

            roomSelect.Show();
            this.Close();
        }

        private void setBtn_Click(object sender, EventArgs e)
        {
            SetForm srm = new SetForm();

            srm.ShowDialog();
        }

        private void HostName_txt_Click(object sender, EventArgs e)
        {

        }
    }
}
