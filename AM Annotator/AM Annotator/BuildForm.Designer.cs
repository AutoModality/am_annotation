namespace AM_Annotator
{
    partial class BuildForm
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
            this.buildingProgressBar = new System.Windows.Forms.ProgressBar();
            this.terminal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buildingProgressBar
            // 
            this.buildingProgressBar.Location = new System.Drawing.Point(12, 12);
            this.buildingProgressBar.Name = "buildingProgressBar";
            this.buildingProgressBar.Size = new System.Drawing.Size(567, 42);
            this.buildingProgressBar.Step = 1;
            this.buildingProgressBar.TabIndex = 1;
            this.buildingProgressBar.Click += new System.EventHandler(this.buildingProgressBar_Click);
            // 
            // terminal
            // 
            this.terminal.Location = new System.Drawing.Point(13, 61);
            this.terminal.Multiline = true;
            this.terminal.Name = "terminal";
            this.terminal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.terminal.Size = new System.Drawing.Size(566, 166);
            this.terminal.TabIndex = 2;
            // 
            // BuildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 239);
            this.Controls.Add(this.terminal);
            this.Controls.Add(this.buildingProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuildForm";
            this.Text = "BuildForm";
            this.Load += new System.EventHandler(this.BuildForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar buildingProgressBar;
        private System.Windows.Forms.TextBox terminal;
    }
}