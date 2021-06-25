
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
            this.bgBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.setBtn = new System.Windows.Forms.Button();
            this.IPAddress_txt = new System.Windows.Forms.Label();
            this.Host_name_txt = new System.Windows.Forms.Label();
            this.Client1_name_txt = new System.Windows.Forms.Label();
            this.Client2_name_txt = new System.Windows.Forms.Label();
            this.Client3_name_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bgBtn
            // 
            this.bgBtn.BackColor = System.Drawing.Color.Transparent;
            this.bgBtn.BackgroundImage = global::AngleFighter.Properties.Resources.RoomBeginBtn;
            this.bgBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bgBtn.FlatAppearance.BorderSize = 0;
            this.bgBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bgBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bgBtn.Location = new System.Drawing.Point(385, 475);
            this.bgBtn.Margin = new System.Windows.Forms.Padding(2);
            this.bgBtn.Name = "bgBtn";
            this.bgBtn.Size = new System.Drawing.Size(231, 98);
            this.bgBtn.TabIndex = 0;
            this.bgBtn.UseVisualStyleBackColor = false;
            this.bgBtn.Click += new System.EventHandler(this.bgBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::AngleFighter.Properties.Resources.RoomBackBtn;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(651, 475);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 98);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BackBtn_Click);
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
            // IPAddress_txt
            // 
            this.IPAddress_txt.AutoSize = true;
            this.IPAddress_txt.Location = new System.Drawing.Point(38, 9);
            this.IPAddress_txt.Name = "IPAddress_txt";
            this.IPAddress_txt.Size = new System.Drawing.Size(0, 12);
            this.IPAddress_txt.TabIndex = 3;
            // 
            // Host_name_txt
            // 
            this.Host_name_txt.AutoSize = true;
            this.Host_name_txt.Location = new System.Drawing.Point(154, 92);
            this.Host_name_txt.Name = "Host_name_txt";
            this.Host_name_txt.Size = new System.Drawing.Size(0, 12);
            this.Host_name_txt.TabIndex = 4;
            // 
            // Client1_name_txt
            // 
            this.Client1_name_txt.AutoSize = true;
            this.Client1_name_txt.Location = new System.Drawing.Point(154, 226);
            this.Client1_name_txt.Name = "Client1_name_txt";
            this.Client1_name_txt.Size = new System.Drawing.Size(0, 12);
            this.Client1_name_txt.TabIndex = 5;
            // 
            // Client2_name_txt
            // 
            this.Client2_name_txt.AutoSize = true;
            this.Client2_name_txt.Location = new System.Drawing.Point(154, 360);
            this.Client2_name_txt.Name = "Client2_name_txt";
            this.Client2_name_txt.Size = new System.Drawing.Size(0, 12);
            this.Client2_name_txt.TabIndex = 6;
            // 
            // Client3_name_txt
            // 
            this.Client3_name_txt.AutoSize = true;
            this.Client3_name_txt.Location = new System.Drawing.Point(156, 495);
            this.Client3_name_txt.Name = "Client3_name_txt";
            this.Client3_name_txt.Size = new System.Drawing.Size(0, 12);
            this.Client3_name_txt.TabIndex = 7;
            // 
            // RoomForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AngleFighter.Properties.Resources.Room;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 619);
            this.Controls.Add(this.Client3_name_txt);
            this.Controls.Add(this.Client2_name_txt);
            this.Controls.Add(this.Client1_name_txt);
            this.Controls.Add(this.Host_name_txt);
            this.Controls.Add(this.IPAddress_txt);
            this.Controls.Add(this.setBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bgBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RoomForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomForm1";
            this.Load += new System.EventHandler(this.RoomForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button bgBtn;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button setBtn;
        public System.Windows.Forms.Label IPAddress_txt;
        public System.Windows.Forms.Label Host_name_txt;
        public System.Windows.Forms.Label Client1_name_txt;
        public System.Windows.Forms.Label Client2_name_txt;
        public System.Windows.Forms.Label Client3_name_txt;
    }
}