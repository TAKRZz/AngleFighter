
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
            this.BgmPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.BgmPlayer)).BeginInit();
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
            this.BeginBtn.Location = new System.Drawing.Point(266, 431);
            this.BeginBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BeginBtn.Name = "BeginBtn";
            this.BeginBtn.Size = new System.Drawing.Size(428, 143);
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
            this.setBtn.Location = new System.Drawing.Point(858, 15);
            this.setBtn.Margin = new System.Windows.Forms.Padding(2);
            this.setBtn.Name = "setBtn";
            this.setBtn.Size = new System.Drawing.Size(66, 66);
            this.setBtn.TabIndex = 1;
            this.setBtn.UseVisualStyleBackColor = false;
            this.setBtn.Click += new System.EventHandler(this.setBtn_Click);
            // 
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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::AngleFighter.Properties.Resources.BeginBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 619);
            this.Controls.Add(this.BgmPlayer);
            this.Controls.Add(this.setBtn);
            this.Controls.Add(this.BeginBtn);
            this.DoubleBuffered = true;
            this.Name = "BeginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AngleFighter";
            this.Load += new System.EventHandler(this.Begin);
            ((System.ComponentModel.ISupportInitialize)(this.BgmPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BeginBtn;
        private System.Windows.Forms.Button setBtn;
        private AxWMPLib.AxWindowsMediaPlayer BgmPlayer;
    }
}

