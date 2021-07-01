﻿
namespace AngleFighter
{
    partial class RoomIPForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enter = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.IP_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.Transparent;
            this.enter.BackgroundImage = global::AngleFighter.Properties.Resources.EnterBtn;
            this.enter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enter.FlatAppearance.BorderSize = 0;
            this.enter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.enter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enter.Location = new System.Drawing.Point(360, 288);
            this.enter.Margin = new System.Windows.Forms.Padding(2);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(219, 79);
            this.enter.TabIndex = 0;
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BackgroundImage = global::AngleFighter.Properties.Resources.BackBtn;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(80, 508);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(159, 53);
            this.backBtn.TabIndex = 1;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // IP_txt
            // 
            this.IP_txt.Font = new System.Drawing.Font("张海山锐谐体2.0-授权联系：Samtype@QQ.com", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IP_txt.Location = new System.Drawing.Point(422, 167);
            this.IP_txt.Name = "IP_txt";
            this.IP_txt.Size = new System.Drawing.Size(251, 34);
            this.IP_txt.TabIndex = 2;
            this.IP_txt.Text = "000.000.000.000";
            this.IP_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RoomIPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AngleFighter.Properties.Resources.RoomNumberBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 619);
            this.Controls.Add(this.IP_txt);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.enter);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RoomIPForm";
            this.Text = "RoomIPForm";
            this.Load += new System.EventHandler(this.RoomIPForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox IP_txt;
    }
}