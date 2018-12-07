namespace AM_Annotator
{
    partial class ProjectOrganizerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectOrganizerForm));
            this.imgFolderLB = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.removeImgFolderBTN = new System.Windows.Forms.Button();
            this.addImgFolderBTN = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.removeAnnotationFolderBTN = new System.Windows.Forms.Button();
            this.addAnnotationFolderBTN = new System.Windows.Forms.Button();
            this.annotationFolderLB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.trainPercentageNUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.imgOutputSetBTN = new System.Windows.Forms.Button();
            this.outputDirectoryTB = new System.Windows.Forms.TextBox();
            this.executionPB = new System.Windows.Forms.ProgressBar();
            this.runBTN = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.annotatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectOrganizerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminal = new System.Windows.Forms.TextBox();
            this.saveSettingBTN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainPercentageNUD)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgFolderLB
            // 
            this.imgFolderLB.FormattingEnabled = true;
            this.imgFolderLB.HorizontalScrollbar = true;
            this.imgFolderLB.Location = new System.Drawing.Point(6, 20);
            this.imgFolderLB.Name = "imgFolderLB";
            this.imgFolderLB.Size = new System.Drawing.Size(345, 108);
            this.imgFolderLB.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.removeImgFolderBTN);
            this.groupBox1.Controls.Add(this.addImgFolderBTN);
            this.groupBox1.Controls.Add(this.imgFolderLB);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 175);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set Image Folders";
            // 
            // removeImgFolderBTN
            // 
            this.removeImgFolderBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeImgFolderBTN.BackgroundImage")));
            this.removeImgFolderBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.removeImgFolderBTN.Location = new System.Drawing.Point(48, 134);
            this.removeImgFolderBTN.Name = "removeImgFolderBTN";
            this.removeImgFolderBTN.Size = new System.Drawing.Size(35, 35);
            this.removeImgFolderBTN.TabIndex = 2;
            this.removeImgFolderBTN.UseVisualStyleBackColor = true;
            this.removeImgFolderBTN.Click += new System.EventHandler(this.removeImgFolderBTN_Click);
            // 
            // addImgFolderBTN
            // 
            this.addImgFolderBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addImgFolderBTN.BackgroundImage")));
            this.addImgFolderBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addImgFolderBTN.Location = new System.Drawing.Point(7, 134);
            this.addImgFolderBTN.Name = "addImgFolderBTN";
            this.addImgFolderBTN.Size = new System.Drawing.Size(35, 35);
            this.addImgFolderBTN.TabIndex = 1;
            this.addImgFolderBTN.UseVisualStyleBackColor = true;
            this.addImgFolderBTN.Click += new System.EventHandler(this.addImgFolderBTN_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.removeAnnotationFolderBTN);
            this.groupBox2.Controls.Add(this.addAnnotationFolderBTN);
            this.groupBox2.Controls.Add(this.annotationFolderLB);
            this.groupBox2.Location = new System.Drawing.Point(389, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 175);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Set Annotation Folders";
            // 
            // removeAnnotationFolderBTN
            // 
            this.removeAnnotationFolderBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeAnnotationFolderBTN.BackgroundImage")));
            this.removeAnnotationFolderBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.removeAnnotationFolderBTN.Location = new System.Drawing.Point(48, 134);
            this.removeAnnotationFolderBTN.Name = "removeAnnotationFolderBTN";
            this.removeAnnotationFolderBTN.Size = new System.Drawing.Size(35, 35);
            this.removeAnnotationFolderBTN.TabIndex = 2;
            this.removeAnnotationFolderBTN.UseVisualStyleBackColor = true;
            this.removeAnnotationFolderBTN.Click += new System.EventHandler(this.removeAnnotationFolderBTN_Click);
            // 
            // addAnnotationFolderBTN
            // 
            this.addAnnotationFolderBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addAnnotationFolderBTN.BackgroundImage")));
            this.addAnnotationFolderBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addAnnotationFolderBTN.Location = new System.Drawing.Point(7, 134);
            this.addAnnotationFolderBTN.Name = "addAnnotationFolderBTN";
            this.addAnnotationFolderBTN.Size = new System.Drawing.Size(35, 35);
            this.addAnnotationFolderBTN.TabIndex = 1;
            this.addAnnotationFolderBTN.UseVisualStyleBackColor = true;
            this.addAnnotationFolderBTN.Click += new System.EventHandler(this.addAnnotationFolderBTN_Click);
            // 
            // annotationFolderLB
            // 
            this.annotationFolderLB.FormattingEnabled = true;
            this.annotationFolderLB.HorizontalScrollbar = true;
            this.annotationFolderLB.Location = new System.Drawing.Point(6, 20);
            this.annotationFolderLB.Name = "annotationFolderLB";
            this.annotationFolderLB.Size = new System.Drawing.Size(345, 108);
            this.annotationFolderLB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Output Directory:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.trainPercentageNUD);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.imgOutputSetBTN);
            this.groupBox3.Controls.Add(this.outputDirectoryTB);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(13, 226);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(733, 99);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Outputs";
            // 
            // trainPercentageNUD
            // 
            this.trainPercentageNUD.DecimalPlaces = 1;
            this.trainPercentageNUD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.trainPercentageNUD.Location = new System.Drawing.Point(153, 65);
            this.trainPercentageNUD.Name = "trainPercentageNUD";
            this.trainPercentageNUD.Size = new System.Drawing.Size(120, 20);
            this.trainPercentageNUD.TabIndex = 8;
            this.trainPercentageNUD.ValueChanged += new System.EventHandler(this.trainPercentageNUD_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Train Percentage:";
            // 
            // imgOutputSetBTN
            // 
            this.imgOutputSetBTN.Location = new System.Drawing.Point(634, 23);
            this.imgOutputSetBTN.Name = "imgOutputSetBTN";
            this.imgOutputSetBTN.Size = new System.Drawing.Size(93, 23);
            this.imgOutputSetBTN.TabIndex = 6;
            this.imgOutputSetBTN.Text = "Set";
            this.imgOutputSetBTN.UseVisualStyleBackColor = true;
            this.imgOutputSetBTN.Click += new System.EventHandler(this.imgOutputSetBTN_Click);
            // 
            // outputDirectoryTB
            // 
            this.outputDirectoryTB.Enabled = false;
            this.outputDirectoryTB.Location = new System.Drawing.Point(153, 26);
            this.outputDirectoryTB.Name = "outputDirectoryTB";
            this.outputDirectoryTB.Size = new System.Drawing.Size(475, 20);
            this.outputDirectoryTB.TabIndex = 5;
            // 
            // executionPB
            // 
            this.executionPB.Location = new System.Drawing.Point(12, 500);
            this.executionPB.Name = "executionPB";
            this.executionPB.Size = new System.Drawing.Size(734, 50);
            this.executionPB.Step = 1;
            this.executionPB.TabIndex = 6;
            // 
            // runBTN
            // 
            this.runBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("runBTN.BackgroundImage")));
            this.runBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.runBTN.Location = new System.Drawing.Point(13, 343);
            this.runBTN.Name = "runBTN";
            this.runBTN.Size = new System.Drawing.Size(60, 60);
            this.runBTN.TabIndex = 7;
            this.runBTN.UseVisualStyleBackColor = true;
            this.runBTN.Click += new System.EventHandler(this.runBTN_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(756, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.annotatorToolStripMenuItem,
            this.dataCollectionToolStripMenuItem,
            this.projectOrganizerToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(62, 22);
            this.toolStripDropDownButton1.Text = "Projects";
            // 
            // annotatorToolStripMenuItem
            // 
            this.annotatorToolStripMenuItem.Name = "annotatorToolStripMenuItem";
            this.annotatorToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.annotatorToolStripMenuItem.Text = "Annotator";
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
            // 
            // terminal
            // 
            this.terminal.Enabled = false;
            this.terminal.Location = new System.Drawing.Point(79, 343);
            this.terminal.Multiline = true;
            this.terminal.Name = "terminal";
            this.terminal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.terminal.Size = new System.Drawing.Size(665, 151);
            this.terminal.TabIndex = 9;
            // 
            // saveSettingBTN
            // 
            this.saveSettingBTN.Image = ((System.Drawing.Image)(resources.GetObject("saveSettingBTN.Image")));
            this.saveSettingBTN.Location = new System.Drawing.Point(12, 409);
            this.saveSettingBTN.Name = "saveSettingBTN";
            this.saveSettingBTN.Size = new System.Drawing.Size(60, 60);
            this.saveSettingBTN.TabIndex = 10;
            this.saveSettingBTN.UseVisualStyleBackColor = true;
            this.saveSettingBTN.Click += new System.EventHandler(this.saveSettingBTN_Click);
            // 
            // ProjectOrganizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 561);
            this.Controls.Add(this.saveSettingBTN);
            this.Controls.Add(this.terminal);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.runBTN);
            this.Controls.Add(this.executionPB);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectOrganizerForm";
            this.Text = "Project Organizer";
            this.Load += new System.EventHandler(this.ProjectOrganizerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainPercentageNUD)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox imgFolderLB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button removeImgFolderBTN;
        private System.Windows.Forms.Button addImgFolderBTN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button removeAnnotationFolderBTN;
        private System.Windows.Forms.Button addAnnotationFolderBTN;
        private System.Windows.Forms.ListBox annotationFolderLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button imgOutputSetBTN;
        private System.Windows.Forms.TextBox outputDirectoryTB;
        private System.Windows.Forms.ProgressBar executionPB;
        private System.Windows.Forms.Button runBTN;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem annotatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataCollectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectOrganizerToolStripMenuItem;
        private System.Windows.Forms.TextBox terminal;
        private System.Windows.Forms.Button saveSettingBTN;
        private System.Windows.Forms.NumericUpDown trainPercentageNUD;
        private System.Windows.Forms.Label label2;
    }
}