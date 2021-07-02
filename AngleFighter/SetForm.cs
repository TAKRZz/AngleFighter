using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;


namespace AngleFighter
{
    public partial class SetForm : Form
    {
        [DllImport("winmm.dll")]
        internal static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);
        [DllImport("winmm.dll")]
        internal static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);
        public SetForm()
        {
            InitializeComponent();
        }

        private void SetForm_Load(object sender, EventArgs e)
        {
            this.Width = 632;
            this.Height = 894;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lTrackBar1_LValueChanged(object sender, DemoControls.LEventArgs e)
        {
            uint currV = ushort.MaxValue / 2;
            waveOutGetVolume(IntPtr.Zero, out currV);
            ushort calcV = (ushort)(currV & 0x0000ffff);
            BeginForm.beginForm.axWindowsMediaPlayer1.settings.volume = lTrackBar1.L_Value;
            uint newVol = (((uint)BeginForm.beginForm.axWindowsMediaPlayer1.settings.volume & 0x0000ffff) | ((uint)BeginForm.beginForm.axWindowsMediaPlayer1.settings.volume << 16));
            waveOutSetVolume(IntPtr.Zero, newVol);

        }
    }
}
