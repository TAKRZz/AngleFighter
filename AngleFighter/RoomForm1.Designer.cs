
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
            this.bgBtn.Location = new System.Drawing.Point(591, 730);
            this.bgBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bgBtn.Name = "bgBtn";
            this.bgBtn.Size = new System.Drawing.Size(330, 133);
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
            this.button1.Location = new System.Drawing.Point(1017, 730);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(330, 133);
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
            this.setBtn.Location = new System.Drawing.Point(1279, 11);
            this.setBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.setBtn.Name = "setBtn";
            this.setBtn.Size = new System.Drawing.Size(110, 110);
            this.setBtn.TabIndex = 2;
            this.setBtn.UseVisualStyleBackColor = false;
            this.setBtn.Click += new System.EventHandler(this.setBtn_Click);
            // 
            // RoomForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AngleFighter.Properties.Resources.Room;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1400, 947);
            this.Controls.Add(this.setBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bgBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RoomForm1";
            this.Text = "RoomForm1";
            this.Load += new System.EventHandler(this.RoomForm1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bgBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button setBtn;
    }
}