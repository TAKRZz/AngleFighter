
namespace AngleFighter
{
    partial class RoomForm1
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
            this.begin_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.setBtn = new System.Windows.Forms.Button();
            this.Host_IP_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // begin_btn
            // 
            this.begin_btn.BackColor = System.Drawing.Color.Transparent;
            this.begin_btn.BackgroundImage = global::AngleFighter.Properties.Resources.RoomBeginBtn;
            this.begin_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.begin_btn.FlatAppearance.BorderSize = 0;
            this.begin_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.begin_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.begin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.begin_btn.Location = new System.Drawing.Point(385, 475);
            this.begin_btn.Margin = new System.Windows.Forms.Padding(2);
            this.begin_btn.Name = "begin_btn";
            this.begin_btn.Size = new System.Drawing.Size(231, 98);
            this.begin_btn.TabIndex = 0;
            this.begin_btn.UseVisualStyleBackColor = false;
            this.begin_btn.Click += new System.EventHandler(this.bgBtn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.exit_btn.BackgroundImage = global::AngleFighter.Properties.Resources.RoomBackBtn;
            this.exit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exit_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Location = new System.Drawing.Point(651, 475);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(2);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(231, 98);
            this.exit_btn.TabIndex = 1;
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.BackBtn_Click);
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
            this.setBtn.Location = new System.Drawing.Point(855, 8);
            this.setBtn.Margin = new System.Windows.Forms.Padding(2);
            this.setBtn.Name = "setBtn";
            this.setBtn.Size = new System.Drawing.Size(66, 66);
            this.setBtn.TabIndex = 2;
            this.setBtn.UseVisualStyleBackColor = false;
            this.setBtn.Click += new System.EventHandler(this.setBtn_Click);
            // 
            // Host_IP_txt
            // 
            this.Host_IP_txt.AutoSize = true;
            this.Host_IP_txt.Font = new System.Drawing.Font("张海山锐谐体2.0-授权联系：Samtype@QQ.com", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Host_IP_txt.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Host_IP_txt.Location = new System.Drawing.Point(122, 92);
            this.Host_IP_txt.Name = "Host_IP_txt";
            this.Host_IP_txt.Size = new System.Drawing.Size(198, 25);
            this.Host_IP_txt.TabIndex = 4;
            this.Host_IP_txt.Text = "111.111.111.111";
            this.Host_IP_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Host_IP_txt.Click += new System.EventHandler(this.Host_IP_txt_Click);
            // 
            // RoomForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AngleFighter.Properties.Resources.Room;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 619);
            this.Controls.Add(this.Host_IP_txt);
            this.Controls.Add(this.setBtn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.begin_btn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RoomForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomForm1";
            this.Load += new System.EventHandler(this.RoomForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button begin_btn;
        public System.Windows.Forms.Button exit_btn;
        public System.Windows.Forms.Button setBtn;
        public System.Windows.Forms.Label Host_IP_txt;
    }
}