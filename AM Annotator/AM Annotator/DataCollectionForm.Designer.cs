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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.Project = new System.Windows.Forms.ToolStripDropDownButton();
            this.annotatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectOrganizerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.refreshBTN = new System.Windows.Forms.Button();
            this.devicesLB = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.searchedImageLV = new System.Windows.Forms.ListView();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.searchBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.outputImageTB = new System.Windows.Forms.TextBox();
            this.setOutputImageBTN = new System.Windows.Forms.Button();
            this.numberOfImagesNUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cameraPB)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfImagesNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraPB
            // 
            this.cameraPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cameraPB.Location = new System.Drawing.Point(346, 15);
            this.cameraPB.Name = "cameraPB";
            this.cameraPB.Size = new System.Drawing.Size(640, 480);
            this.cameraPB.TabIndex = 0;
            this.cameraPB.TabStop = false;
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
            this.toolStrip1.Size = new System.Drawing.Size(1033, 25);
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
            this.dataCollectionToolStripMenuItem,
            this.projectOrganizerToolStripMenuItem});
            this.Project.Image = ((System.Drawing.Image)(resources.GetObject("Project.Image")));
            this.Project.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Project.Name = "Project";
            this.Project.Size = new System.Drawing.Size(62, 22);
            this.Project.Text = "Projects";
            // 
            // annotatorToolStripMenuItem
            // 
            this.annotatorToolStripMenuItem.Name = "annotatorToolStripMenuItem";
            this.annotatorToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.annotatorToolStripMenuItem.Text = "Annotator";
            this.annotatorToolStripMenuItem.Click += new System.EventHandler(this.annotatorToolStripMenuItem_Click);
            // 
            // dataCollectionToolStripMenuItem
            // 
            this.dataCollectionToolStripMenuItem.Name = "dataCollectionToolStripMenuItem";
            this.dataCollectionToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.dataCollectionToolStripMenuItem.Text = "Data Collection";
            // 
            // projectOrganizerToolStripMenuItem
            // 
            this.projectOrganizerToolStripMenuItem.Name = "projectOrganizerToolStripMenuItem";
            this.projectOrganizerToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.projectOrganizerToolStripMenuItem.Text = "Project Organizer";
            this.projectOrganizerToolStripMenuItem.Click += new System.EventHandler(this.projectOrganizerToolStripMenuItem_Click);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1009, 542);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.refreshBTN);
            this.tabPage1.Controls.Add(this.devicesLB);
            this.tabPage1.Controls.Add(this.cameraPB);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1001, 516);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Live";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // refreshBTN
            // 
            this.refreshBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshBTN.BackgroundImage")));
            this.refreshBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refreshBTN.Location = new System.Drawing.Point(306, 15);
            this.refreshBTN.Name = "refreshBTN";
            this.refreshBTN.Size = new System.Drawing.Size(34, 34);
            this.refreshBTN.TabIndex = 0;
            this.refreshBTN.UseVisualStyleBackColor = true;
            // 
            // devicesLB
            // 
            this.devicesLB.FormattingEnabled = true;
            this.devicesLB.Location = new System.Drawing.Point(7, 15);
            this.devicesLB.Name = "devicesLB";
            this.devicesLB.Size = new System.Drawing.Size(293, 95);
            this.devicesLB.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.numberOfImagesNUD);
            this.tabPage2.Controls.Add(this.setOutputImageBTN);
            this.tabPage2.Controls.Add(this.outputImageTB);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.searchBTN);
            this.tabPage2.Controls.Add(this.searchTB);
            this.tabPage2.Controls.Add(this.searchedImageLV);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1001, 516);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Google Image";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // searchedImageLV
            // 
            this.searchedImageLV.Location = new System.Drawing.Point(387, 6);
            this.searchedImageLV.Name = "searchedImageLV";
            this.searchedImageLV.Size = new System.Drawing.Size(608, 451);
            this.searchedImageLV.TabIndex = 0;
            this.searchedImageLV.UseCompatibleStateImageBehavior = false;
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTB.Location = new System.Drawing.Point(6, 470);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(950, 31);
            this.searchTB.TabIndex = 1;
            // 
            // searchBTN
            // 
            this.searchBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchBTN.BackgroundImage")));
            this.searchBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchBTN.Location = new System.Drawing.Point(962, 468);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(33, 33);
            this.searchBTN.TabIndex = 2;
            this.searchBTN.UseVisualStyleBackColor = true;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Image Locations: ";
            // 
            // outputImageTB
            // 
            this.outputImageTB.Enabled = false;
            this.outputImageTB.Location = new System.Drawing.Point(104, 27);
            this.outputImageTB.Name = "outputImageTB";
            this.outputImageTB.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.outputImageTB.Size = new System.Drawing.Size(277, 20);
            this.outputImageTB.TabIndex = 4;
            // 
            // setOutputImageBTN
            // 
            this.setOutputImageBTN.Location = new System.Drawing.Point(104, 54);
            this.setOutputImageBTN.Name = "setOutputImageBTN";
            this.setOutputImageBTN.Size = new System.Drawing.Size(277, 23);
            this.setOutputImageBTN.TabIndex = 5;
            this.setOutputImageBTN.Text = "Set";
            this.setOutputImageBTN.UseVisualStyleBackColor = true;
            // 
            // numberOfImagesNUD
            // 
            this.numberOfImagesNUD.Location = new System.Drawing.Point(104, 120);
            this.numberOfImagesNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numberOfImagesNUD.Name = "numberOfImagesNUD";
            this.numberOfImagesNUD.Size = new System.Drawing.Size(277, 20);
            this.numberOfImagesNUD.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Number of Images:";
            // 
            // DataCollectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 582);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataCollectionForm";
            this.Text = "Data Collection";
            this.Load += new System.EventHandler(this.DataCollectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cameraPB)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfImagesNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cameraPB;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripDropDownButton Project;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem annotatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataCollectionToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox devicesLB;
        private System.Windows.Forms.Button refreshBTN;
        private System.Windows.Forms.ToolStripMenuItem projectOrganizerToolStripMenuItem;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.ListView searchedImageLV;
        private System.Windows.Forms.TextBox outputImageTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button setOutputImageBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numberOfImagesNUD;
    }
}