
namespace AngleFighter
{
    partial class RoomForm2
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
            this.setBtn = new System.Windows.Forms.Button();
            this.HostName_txt = new System.Windows.Forms.Label();
            this.Client1_Name_txt = new System.Windows.Forms.Label();
            this.Client2_Name_txt = new System.Windows.Forms.Label();
            this.Client3_Name_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BackgroundImage = global::AngleFighter.Properties.Resources.RoomBackBtn;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(524, 480);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(218, 86);
            this.backBtn.TabIndex = 0;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
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
            // HostName_txt
            // 
            this.HostName_txt.AutoSize = true;
            this.HostName_txt.Location = new System.Drawing.Point(140, 88);
            this.HostName_txt.Name = "HostName_txt";
            this.HostName_txt.Size = new System.Drawing.Size(0, 12);
            this.HostName_txt.TabIndex = 3;
            this.HostName_txt.Click += new System.EventHandler(this.HostName_txt_Click);
            // 
            // Client1_Name_txt
            // 
            this.Client1_Name_txt.AutoSize = true;
            this.Client1_Name_txt.Location = new System.Drawing.Point(146, 230);
            this.Client1_Name_txt.Name = "Client1_Name_txt";
            this.Client1_Name_txt.Size = new System.Drawing.Size(0, 12);
            this.Client1_Name_txt.TabIndex = 4;
            // 
            // Client2_Name_txt
            // 
            this.Client2_Name_txt.AutoSize = true;
            this.Client2_Name_txt.Location = new System.Drawing.Point(146, 369);
            this.Client2_Name_txt.Name = "Client2_Name_txt";
            this.Client2_Name_txt.Size = new System.Drawing.Size(0, 12);
            this.Client2_Name_txt.TabIndex = 5;
            // 
            // Client3_Name_txt
            // 
            this.Client3_Name_txt.AutoSize = true;
            this.Client3_Name_txt.Location = new System.Drawing.Point(146, 500);
            this.Client3_Name_txt.Name = "Client3_Name_txt";
            this.Client3_Name_txt.Size = new System.Drawing.Size(0, 12);
            this.Client3_Name_txt.TabIndex = 6;
            // 
            // RoomForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AngleFighter.Properties.Resources.Room;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 619);
            this.Controls.Add(this.Client3_Name_txt);
            this.Controls.Add(this.Client2_Name_txt);
            this.Controls.Add(this.Client1_Name_txt);
            this.Controls.Add(this.HostName_txt);
            this.Controls.Add(this.setBtn);
            this.Controls.Add(this.backBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RoomForm2";
            this.Text = "RoomForm2";
            this.Load += new System.EventHandler(this.RoomForm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button backBtn;
        public System.Windows.Forms.Button setBtn;
        public System.Windows.Forms.Label HostName_txt;
        public System.Windows.Forms.Label Client1_Name_txt;
        public System.Windows.Forms.Label Client2_Name_txt;
        public System.Windows.Forms.Label Client3_Name_txt;
    }
}