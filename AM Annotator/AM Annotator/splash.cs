using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Timers;

namespace AM_Annotator
{
    public partial class splash : Form
    {
        private static System.Timers.Timer splash_timer;
        public splash()
        {
            InitializeComponent();
        }

        private void splash_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 4, Screen.PrimaryScreen.Bounds.Height / 4) ;

            splash_timer = new System.Timers.Timer();
            splash_timer.Interval = 5000;
            splash_timer.Elapsed += timerCallBack;
            splash_timer.AutoReset = true;
            splash_timer.Enabled = true;

        }

        private void timerCallBack(Object srouce, System.Timers.ElapsedEventArgs e)
        {

            //This is a hack. we need to find out why this is crashing
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    this.Close();
                }
                );
            }
            catch (Exception ex)
            {

            }
            
        }

        private void splash_FormClosed(object sender, FormClosedEventArgs e)
        {

            var t = new Thread(() => Application.Run(new mainWindow()));
            t.Start();
            //Form annotationForm = new mainWindow();
            //annotationForm.Show();
        }
    }
}
