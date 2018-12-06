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
    public partial class labelForm : Form
    {
        public static int LabelClass { get; set; }

        public labelForm()
        {
            InitializeComponent();
        }

        /*When Set Button is pressed is pressed*/
        private void setLabelBTN_Click(object sender, EventArgs e)
        {
            LabelClass = Convert.ToInt32(idLabelTB.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /*when key is pressed. Make sure it is only numbers*/
        private void idLabelTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13 || char.IsLetter(e.KeyChar)) && idLabelTB.Text != "")
            {
                setLabelBTN.PerformClick();
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void labelForm_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            this.TopMost = true;
            idLabelTB.Select();
        }

        private void labelForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void labelForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void idLabelTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
           
        }
    }
}
