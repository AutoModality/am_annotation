using AM_Annotator.Properties;
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
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Azure);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", 12.0f, FontStyle.Regular, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {

        }

        private void cascadeFormatCB_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.OpencvAnnotation = cascadeFormatCB.Checked;
        }

        private void yoloFormatCB_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DarknetAnnotation = yoloFormatCB.Checked;
        }

        private void trainPercentageNUD_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.TrainPercentage = Convert.ToInt32(trainPercentageNUD.Value);
        }

        private void setBTN_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openDir = new FolderBrowserDialog();
            if (openDir.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(openDir.SelectedPath))
            {
                outputDirectoryTB.Text = openDir.SelectedPath;
                Properties.Settings.Default.ProjectLocation = openDir.SelectedPath;
            }
            
        }

        private void aliasTB_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            //tip.ToolTipTitle = "Alias Directory";
            //tip.Show("Path to the images in the training machine", this, 10);
            tip.SetToolTip(aliasTB, "Path to the images in the training machine. e.g. /home/ubuntu/image_set/images");
        }

        private void SettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.OutputAlias = aliasTB.Text;
        }
    }
}
