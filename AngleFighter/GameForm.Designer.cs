
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
            this.Surrender = new System.Windows.Forms.Button();
            this.Confirm = new System.Windows.Forms.Button();
            this.Round = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AngleFighter.Properties.Resources.GameBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1400, 947);
            this.Controls.Add(this.Round);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Surrender);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Surrender;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button Round;
    }
}