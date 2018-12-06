namespace AM_Annotator
{
    partial class labelForm
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
            this.setLabelBTN = new System.Windows.Forms.Button();
            this.idLabelTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // setLabelBTN
            // 
            this.setLabelBTN.Location = new System.Drawing.Point(168, 38);
            this.setLabelBTN.Name = "setLabelBTN";
            this.setLabelBTN.Size = new System.Drawing.Size(75, 23);
            this.setLabelBTN.TabIndex = 0;
            this.setLabelBTN.Text = "Set";
            this.setLabelBTN.UseVisualStyleBackColor = true;
            this.setLabelBTN.Click += new System.EventHandler(this.setLabelBTN_Click);
            // 
            // idLabelTB
            // 
            this.idLabelTB.Location = new System.Drawing.Point(62, 40);
            this.idLabelTB.Name = "idLabelTB";
            this.idLabelTB.Size = new System.Drawing.Size(100, 20);
            this.idLabelTB.TabIndex = 1;
            this.idLabelTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.idLabelTB_KeyDown);
            this.idLabelTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idLabelTB_KeyPress);
            // 
            // labelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 95);
            this.Controls.Add(this.idLabelTB);
            this.Controls.Add(this.setLabelBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "labelForm";
            this.Text = "Insert Label";
            this.Load += new System.EventHandler(this.labelForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.labelForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.labelForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setLabelBTN;
        private System.Windows.Forms.TextBox idLabelTB;
    }
}