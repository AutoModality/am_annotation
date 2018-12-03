namespace AM_Annotator
{
    partial class DataCollectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataCollectionForm));
            this.cameraPB = new System.Windows.Forms.PictureBox();
            this.visionDevicesCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.Project = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.annotatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.cameraPB)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cameraPB
            // 
            this.cameraPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cameraPB.Location = new System.Drawing.Point(526, 32);
            this.cameraPB.Name = "cameraPB";
            this.cameraPB.Size = new System.Drawing.Size(640, 480);
            this.cameraPB.TabIndex = 0;
            this.cameraPB.TabStop = false;
            // 
            // visionDevicesCB
            // 
            this.visionDevicesCB.FormattingEnabled = true;
            this.visionDevicesCB.Location = new System.Drawing.Point(88, 32);
            this.visionDevicesCB.Name = "visionDevicesCB";
            this.visionDevicesCB.Size = new System.Drawing.Size(432, 21);
            this.visionDevicesCB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vision Inputs:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.Project,
            this.toolStripDropDownButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1183, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(40, 22);
            this.toolStripDropDownButton2.Text = "Edit";
            // 
            // Project
            // 
            this.Project.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Project.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.annotatorToolStripMenuItem,
            this.dataCollectionToolStripMenuItem});
            this.Project.Image = ((System.Drawing.Image)(resources.GetObject("Project.Image")));
            this.Project.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Project.Name = "Project";
            this.Project.Size = new System.Drawing.Size(57, 22);
            this.Project.Text = "Project";
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(47, 22);
            this.toolStripDropDownButton3.Text = "Build";
            // 
            // annotatorToolStripMenuItem
            // 
            this.annotatorToolStripMenuItem.Name = "annotatorToolStripMenuItem";
            this.annotatorToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.annotatorToolStripMenuItem.Text = "Annotator";
            this.annotatorToolStripMenuItem.Click += new System.EventHandler(this.annotatorToolStripMenuItem_Click);
            // 
            // dataCollectionToolStripMenuItem
            // 
            this.dataCollectionToolStripMenuItem.Name = "dataCollectionToolStripMenuItem";
            this.dataCollectionToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.dataCollectionToolStripMenuItem.Text = "Data Collection";
            // 
            // DataCollectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 562);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.visionDevicesCB);
            this.Controls.Add(this.cameraPB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataCollectionForm";
            this.Text = "Data Collection";
            this.Load += new System.EventHandler(this.DataCollectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cameraPB)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cameraPB;
        private System.Windows.Forms.ComboBox visionDevicesCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripDropDownButton Project;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem annotatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataCollectionToolStripMenuItem;
    }
}