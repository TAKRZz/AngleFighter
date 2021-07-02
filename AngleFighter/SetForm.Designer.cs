
namespace AngleFighter
{
    partial class SetForm
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
            this.backBtn = new System.Windows.Forms.Button();
            this.lTrackBar1 = new DemoControls.LTrackBar();
            this.lTrackBar2 = new DemoControls.LTrackBar();
            this.lTrackBar3 = new DemoControls.LTrackBar();
            this.SuspendLayout();
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
            this.backBtn.Location = new System.Drawing.Point(802, 1402);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(408, 140);
            this.backBtn.TabIndex = 0;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // lTrackBar1
            // 
            this.lTrackBar1.L_BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(196)))));
            this.lTrackBar1.L_BarSize = 60;
            this.lTrackBar1.L_IsRound = true;
            this.lTrackBar1.L_Maximum = 100;
            this.lTrackBar1.L_Minimum = 0;
            this.lTrackBar1.L_Orientation = DemoControls.Orientation.Horizontal_LR;
            this.lTrackBar1.L_SliderColor = System.Drawing.Color.LightPink;
            this.lTrackBar1.L_Value = 50;
            this.lTrackBar1.Location = new System.Drawing.Point(380, 459);
            this.lTrackBar1.Name = "lTrackBar1";
            this.lTrackBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lTrackBar1.Size = new System.Drawing.Size(707, 60);
            this.lTrackBar1.TabIndex = 1;
            this.lTrackBar1.Text = "lTrackBar1";
            this.lTrackBar1.LValueChanged += new DemoControls.LTrackBar.LValueChangedEventHandler(this.lTrackBar1_LValueChanged);
            // 
            // lTrackBar2
            // 
            this.lTrackBar2.L_BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(228)))), ((int)(((byte)(141)))));
            this.lTrackBar2.L_BarSize = 60;
            this.lTrackBar2.L_IsRound = true;
            this.lTrackBar2.L_Maximum = 100;
            this.lTrackBar2.L_Minimum = 0;
            this.lTrackBar2.L_Orientation = DemoControls.Orientation.Horizontal_LR;
            this.lTrackBar2.L_SliderColor = System.Drawing.Color.Khaki;
            this.lTrackBar2.L_Value = 0;
            this.lTrackBar2.Location = new System.Drawing.Point(389, 775);
            this.lTrackBar2.Name = "lTrackBar2";
            this.lTrackBar2.Size = new System.Drawing.Size(716, 60);
            this.lTrackBar2.TabIndex = 2;
            this.lTrackBar2.Text = "lTrackBar2";
            // 
            // lTrackBar3
            // 
            this.lTrackBar3.L_BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(192)))), ((int)(((byte)(217)))));
            this.lTrackBar3.L_BarSize = 60;
            this.lTrackBar3.L_IsRound = true;
            this.lTrackBar3.L_Maximum = 100;
            this.lTrackBar3.L_Minimum = 0;
            this.lTrackBar3.L_Orientation = DemoControls.Orientation.Horizontal_LR;
            this.lTrackBar3.L_SliderColor = System.Drawing.Color.DarkTurquoise;
            this.lTrackBar3.L_Value = 0;
            this.lTrackBar3.Location = new System.Drawing.Point(380, 1131);
            this.lTrackBar3.Name = "lTrackBar3";
            this.lTrackBar3.Size = new System.Drawing.Size(725, 60);
            this.lTrackBar3.TabIndex = 3;
            this.lTrackBar3.Text = "lTrackBar3";
            // 
            // SetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AngleFighter.Properties.Resources.SetBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1232, 1710);
            this.Controls.Add(this.lTrackBar3);
            this.Controls.Add(this.lTrackBar2);
            this.Controls.Add(this.lTrackBar1);
            this.Controls.Add(this.backBtn);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SetForm";
            this.Text = "SetForm";
            this.Load += new System.EventHandler(this.SetForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private DemoControls.LTrackBar lTrackBar1;
        private DemoControls.LTrackBar lTrackBar2;
        private DemoControls.LTrackBar lTrackBar3;
    }
}