﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        }

        private void BeginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomSelect rooms = new RoomSelect();
            rooms.ShowDialog();
            this.Close();

        }



        private void Begin(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        }

        private void setBtn_Click(object sender, EventArgs e)
        {
            //BeginBtn.Location = new System.Drawing.Point(800,400);
            
            SetForm srm = new SetForm();

            srm.ShowDialog();
            
        }

        private void BeginBtn_MouseDown(object sender, MouseEventArgs e)
        {
            BeginBtn.BackgroundImage = global::AngleFighter.Properties.Resources.BeginBtn2;
        }
    }
}
