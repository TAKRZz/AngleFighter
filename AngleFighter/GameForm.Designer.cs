
namespace AngleFighter
{
    partial class GameForm
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
            this.chessPanel = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.chessContainer = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Surrender = new System.Windows.Forms.Button();
            this.Confirm = new System.Windows.Forms.Button();
            this.Round = new System.Windows.Forms.Button();
            this.chessPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.chessContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // chessPanel
            // 
            this.chessPanel.AllowDrop = true;
            this.chessPanel.BackgroundImage = global::AngleFighter.Properties.Resources.chessPanel;
            this.chessPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chessPanel.Controls.Add(this.pictureBox4);
            this.chessPanel.Location = new System.Drawing.Point(209, 155);
            this.chessPanel.Name = "chessPanel";
            this.chessPanel.Size = new System.Drawing.Size(640, 640);
            this.chessPanel.TabIndex = 0;
            this.chessPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.chessPanel_Paint);
            this.chessPanel.MouseEnter += new System.EventHandler(this.chessPanel_MouseEnter);
            this.chessPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chessPanel_MouseUp);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(-136, 117);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(81, 78);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // chessContainer
            // 
            this.chessContainer.AllowDrop = true;
            this.chessContainer.BackgroundImage = global::AngleFighter.Properties.Resources.chessContainer;
            this.chessContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chessContainer.Controls.Add(this.button2);
            this.chessContainer.Controls.Add(this.button1);
            this.chessContainer.Location = new System.Drawing.Point(911, 326);
            this.chessContainer.Name = "chessContainer";
            this.chessContainer.Size = new System.Drawing.Size(453, 399);
            this.chessContainer.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::AngleFighter.Properties.Resources.Right;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(385, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 61);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::AngleFighter.Properties.Resources.Left;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(311, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 61);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::AngleFighter.Properties.Resources._1Blue;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(911, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 140);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::AngleFighter.Properties.Resources._2Yellow;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(24, 254);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::AngleFighter.Properties.Resources._3Green;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(24, 433);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::AngleFighter.Properties.Resources._4Red;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(24, 612);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 100);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // Surrender
            // 
            this.Surrender.BackColor = System.Drawing.Color.Transparent;
            this.Surrender.BackgroundImage = global::AngleFighter.Properties.Resources.Surrender;
            this.Surrender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Surrender.Cursor = System.Windows.Forms.Cursors.Default;
            this.Surrender.FlatAppearance.BorderSize = 0;
            this.Surrender.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Surrender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Surrender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Surrender.Location = new System.Drawing.Point(1021, 769);
            this.Surrender.Name = "Surrender";
            this.Surrender.Size = new System.Drawing.Size(211, 82);
            this.Surrender.TabIndex = 0;
            this.Surrender.UseVisualStyleBackColor = false;
            this.Surrender.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Surrender_MouseDown);
            this.Surrender.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Surrender_MouseUp);
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.Color.Transparent;
            this.Confirm.BackgroundImage = global::AngleFighter.Properties.Resources.Confirm;
            this.Confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Confirm.FlatAppearance.BorderSize = 0;
            this.Confirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Confirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirm.Location = new System.Drawing.Point(276, 835);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(174, 78);
            this.Confirm.TabIndex = 1;
            this.Confirm.UseVisualStyleBackColor = false;
            this.Confirm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Confirm_MouseDown);
            this.Confirm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Confirm_MouseUp);
            // 
            // Round
            // 
            this.Round.BackColor = System.Drawing.Color.Transparent;
            this.Round.BackgroundImage = global::AngleFighter.Properties.Resources.Round;
            this.Round.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Round.FlatAppearance.BorderSize = 0;
            this.Round.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Round.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Round.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Round.Location = new System.Drawing.Point(590, 835);
            this.Round.Name = "Round";
            this.Round.Size = new System.Drawing.Size(174, 78);
            this.Round.TabIndex = 2;
            this.Round.UseVisualStyleBackColor = false;
            this.Round.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Round_MouseDown);
            this.Round.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Round_MouseUp);
            // 
            // GameForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AngleFighter.Properties.Resources.GameBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1400, 947);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chessContainer);
            this.Controls.Add(this.chessPanel);
            this.Controls.Add(this.Round);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Surrender);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.chessPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.chessContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel chessContainer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Panel chessPanel;

        private System.Windows.Forms.Button Surrender;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button Round;
    }
}