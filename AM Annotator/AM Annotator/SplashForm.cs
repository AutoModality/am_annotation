using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AM_Annotator
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 4, Screen.PrimaryScreen.Bounds.Height / 4);
            this.BringToFront();
            this.ShowInTaskbar = false;

            closeTimer.Start();
        }
        private void closeTimer_Tick_1(object sender, EventArgs e)
        {
            closeTimer.Stop();
            this.Close();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }
    }
}
