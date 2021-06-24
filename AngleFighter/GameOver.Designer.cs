
namespace AngleFighter
{
    partial class GameOver
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
            this.BackToHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackToHome
            // 
            this.BackToHome.BackColor = System.Drawing.Color.Transparent;
            this.BackToHome.BackgroundImage = global::AngleFighter.Properties.Resources.BackToHome;
            this.BackToHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackToHome.FlatAppearance.BorderSize = 0;
            this.BackToHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BackToHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BackToHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToHome.Location = new System.Drawing.Point(188, 316);
            this.BackToHome.Name = "BackToHome";
            this.BackToHome.Size = new System.Drawing.Size(300, 95);
            this.BackToHome.TabIndex = 0;
            this.BackToHome.UseVisualStyleBackColor = false;
            this.BackToHome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BackToHome_MouseDown);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AngleFighter.Properties.Resources.GameOverBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 454);
            this.Controls.Add(this.BackToHome);
            this.DoubleBuffered = true;
            this.Name = "GameOver";
            this.Text = "GameOver";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackToHome;
    }
}