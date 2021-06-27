
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
            this.HostName_txt = new System.Windows.Forms.Label();
            this.Client1Name_txt = new System.Windows.Forms.Label();
            this.Client2Name_txt = new System.Windows.Forms.Label();
            this.Client3Name_txt = new System.Windows.Forms.Label();
            this.Timer_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HostName_txt
            // 
            this.HostName_txt.AutoSize = true;
            this.HostName_txt.Location = new System.Drawing.Point(657, 100);
            this.HostName_txt.Name = "HostName_txt";
            this.HostName_txt.Size = new System.Drawing.Size(29, 12);
            this.HostName_txt.TabIndex = 0;
            this.HostName_txt.Text = "Host";
            // 
            // Client1Name_txt
            // 
            this.Client1Name_txt.AutoSize = true;
            this.Client1Name_txt.Location = new System.Drawing.Point(31, 116);
            this.Client1Name_txt.Name = "Client1Name_txt";
            this.Client1Name_txt.Size = new System.Drawing.Size(47, 12);
            this.Client1Name_txt.TabIndex = 1;
            this.Client1Name_txt.Text = "Client1";
            // 
            // Client2Name_txt
            // 
            this.Client2Name_txt.AutoSize = true;
            this.Client2Name_txt.Location = new System.Drawing.Point(31, 264);
            this.Client2Name_txt.Name = "Client2Name_txt";
            this.Client2Name_txt.Size = new System.Drawing.Size(11, 12);
            this.Client2Name_txt.TabIndex = 2;
            this.Client2Name_txt.Text = "2";
            // 
            // Client3Name_txt
            // 
            this.Client3Name_txt.AutoSize = true;
            this.Client3Name_txt.Location = new System.Drawing.Point(31, 418);
            this.Client3Name_txt.Name = "Client3Name_txt";
            this.Client3Name_txt.Size = new System.Drawing.Size(11, 12);
            this.Client3Name_txt.TabIndex = 3;
            this.Client3Name_txt.Text = "3";
            // 
            // Timer_txt
            // 
            this.Timer_txt.AutoSize = true;
            this.Timer_txt.Location = new System.Drawing.Point(821, 27);
            this.Timer_txt.Name = "Timer_txt";
            this.Timer_txt.Size = new System.Drawing.Size(35, 12);
            this.Timer_txt.TabIndex = 4;
            this.Timer_txt.Text = "Timer";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AngleFighter.Properties.Resources.GameBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 619);
            this.Controls.Add(this.Timer_txt);
            this.Controls.Add(this.Client3Name_txt);
            this.Controls.Add(this.Client2Name_txt);
            this.Controls.Add(this.Client1Name_txt);
            this.Controls.Add(this.HostName_txt);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label HostName_txt;
        public System.Windows.Forms.Label Client1Name_txt;
        public System.Windows.Forms.Label Client2Name_txt;
        public System.Windows.Forms.Label Client3Name_txt;
        public System.Windows.Forms.Label Timer_txt;
    }
}