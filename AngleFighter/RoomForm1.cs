using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngleFighter
{
    public partial class RoomForm1 : Form
    {
        public string IP { get; }

        public RoomForm1()
        {
            InitializeComponent();
        }

        public Host host;

        public GameForm gameForm;

        public RoomSelect roomSelect;

        private void RoomForm1_Load(object sender, EventArgs e)
        {

            this.bgBtn.Enabled = false; 

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;

        }

        public void bgBtn_Click(object sender, EventArgs e)
        {

            Hide();

            gameForm = new GameForm();
            host.gameForm = gameForm;
            gameForm.player = host;
            host.gameForm = gameForm;

            gameForm.roomForm1 = this;
            gameForm.HostName_txt.Text = this.Host_name_txt.Text;
            gameForm.Client1Name_txt.Text = this.Client1_name_txt.Text;
            gameForm.Client2Name_txt.Text = this.Client2_name_txt.Text;
            gameForm.Client3Name_txt.Text = this.Client3_name_txt.Text;
            gameForm.Timer_txt.Text = "60 S";
            

            host.sendStartGame();

            gameForm.ShowDialog();

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Hide();

            roomSelect.Show();

            this.Close();
        }

        private void setBtn_Click(object sender, EventArgs e)
        {
            SetForm srm = new SetForm();
            
            srm.ShowDialog();
        }
    }
}
