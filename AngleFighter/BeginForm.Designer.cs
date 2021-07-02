
namespace AngleFighter
{
    partial class BeginForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BeginForm));
            this.BeginBtn = new System.Windows.Forms.Button();
            this.setBtn = new System.Windows.Forms.Button();
<<<<<<< Updated upstream
            this.BgmPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.BgmPlayer)).BeginInit();
=======
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
>>>>>>> Stashed changes
            this.SuspendLayout();
            // 
            // BeginBtn
            // 
            this.BeginBtn.BackColor = System.Drawing.Color.Transparent;
            this.BeginBtn.BackgroundImage = global::AngleFighter.Properties.Resources.BeginBtn;
            this.BeginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BeginBtn.FlatAppearance.BorderSize = 0;
            this.BeginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BeginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BeginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
<<<<<<< Updated upstream
            this.BeginBtn.Location = new System.Drawing.Point(266, 431);
            this.BeginBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BeginBtn.Name = "BeginBtn";
            this.BeginBtn.Size = new System.Drawing.Size(428, 143);
=======
            this.BeginBtn.Location = new System.Drawing.Point(844, 1330);
            this.BeginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BeginBtn.Name = "BeginBtn";
            this.BeginBtn.Size = new System.Drawing.Size(1270, 450);
>>>>>>> Stashed changes
            this.BeginBtn.TabIndex = 0;
            this.BeginBtn.UseVisualStyleBackColor = false;
            this.BeginBtn.Click += new System.EventHandler(this.BeginBtn_Click);
            // 
            // setBtn
            // 
            this.setBtn.BackColor = System.Drawing.Color.Transparent;
            this.setBtn.BackgroundImage = global::AngleFighter.Properties.Resources.SetBtn;
            this.setBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.setBtn.FlatAppearance.BorderSize = 0;
            this.setBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.setBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.setBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setBtn.ForeColor = System.Drawing.Color.Transparent;
<<<<<<< Updated upstream
            this.setBtn.Location = new System.Drawing.Point(858, 15);
            this.setBtn.Margin = new System.Windows.Forms.Padding(2);
            this.setBtn.Name = "setBtn";
            this.setBtn.Size = new System.Drawing.Size(66, 66);
=======
            this.setBtn.Location = new System.Drawing.Point(2538, 22);
            this.setBtn.Margin = new System.Windows.Forms.Padding(4);
            this.setBtn.Name = "setBtn";
            this.setBtn.Size = new System.Drawing.Size(240, 240);
>>>>>>> Stashed changes
            this.setBtn.TabIndex = 1;
            this.setBtn.UseVisualStyleBackColor = false;
            this.setBtn.Click += new System.EventHandler(this.setBtn_Click);
            // 
<<<<<<< Updated upstream
            // BgmPlayer
            // 
            this.BgmPlayer.Enabled = true;
            this.BgmPlayer.Location = new System.Drawing.Point(2, 594);
            this.BgmPlayer.Name = "BgmPlayer";
            this.BgmPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("BgmPlayer.OcxState")));
            this.BgmPlayer.Size = new System.Drawing.Size(75, 23);
            this.BgmPlayer.TabIndex = 2;
            this.BgmPlayer.Visible = false;
            // 
            // BeginForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
=======
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(2348, 94);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(38, 32);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            this.axWindowsMediaPlayer1.Visible = false;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter_1);
            // 
            // BeginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
>>>>>>> Stashed changes
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::AngleFighter.Properties.Resources.BeginBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
<<<<<<< Updated upstream
            this.ClientSize = new System.Drawing.Size(929, 619);
            this.Controls.Add(this.BgmPlayer);
=======
            this.ClientSize = new System.Drawing.Size(2800, 1894);
            this.Controls.Add(this.axWindowsMediaPlayer1);
>>>>>>> Stashed changes
            this.Controls.Add(this.setBtn);
            this.Controls.Add(this.BeginBtn);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "BeginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AngleFighter";
            this.Load += new System.EventHandler(this.Begin);
<<<<<<< Updated upstream
            ((System.ComponentModel.ISupportInitialize)(this.BgmPlayer)).EndInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
>>>>>>> Stashed changes
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BeginBtn;
        private System.Windows.Forms.Button setBtn;
<<<<<<< Updated upstream
        private AxWMPLib.AxWindowsMediaPlayer BgmPlayer;
=======
        public AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
>>>>>>> Stashed changes
    }
}

