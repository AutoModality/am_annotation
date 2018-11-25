namespace AM_Annotator
{
    partial class mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.annotatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.loadBTN = new System.Windows.Forms.Button();
            this.removeBTN = new System.Windows.Forms.Button();
            this.folderLB = new System.Windows.Forms.ListBox();
            this.imageLB = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lastAnnotationEndYL = new System.Windows.Forms.Label();
            this.lastAnnotationEndXL = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lastAnnotationHeightL = new System.Windows.Forms.Label();
            this.lastAnnotationWidthL = new System.Windows.Forms.Label();
            this.lastAnnotationYL = new System.Windows.Forms.Label();
            this.lastAnnotationXL = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cursorPositionYL = new System.Windows.Forms.Label();
            this.cursorPositionXL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.imgRemoveBTN = new System.Windows.Forms.Button();
            this.mainPB = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.viewAllAnnotationsBTN = new System.Windows.Forms.Button();
            this.deleteAnnotationBTN = new System.Windows.Forms.Button();
            this.currentImgAnnotationsLB = new System.Windows.Forms.ListBox();
            this.saveWorkspaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPB)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.saveWorkspaceToolStripMenuItem,
            this.newProjectToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.fileToolStripMenuItem.Text = "New Workspace";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.newProjectToolStripMenuItem.Text = "Load Workspace";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(40, 22);
            this.toolStripDropDownButton2.Text = "Edit";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1172, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.annotatorToolStripMenuItem,
            this.dataCollectionToolStripMenuItem});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(62, 22);
            this.toolStripDropDownButton3.Text = "Projects";
            // 
            // annotatorToolStripMenuItem
            // 
            this.annotatorToolStripMenuItem.Name = "annotatorToolStripMenuItem";
            this.annotatorToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.annotatorToolStripMenuItem.Text = "Annotator";
            // 
            // dataCollectionToolStripMenuItem
            // 
            this.dataCollectionToolStripMenuItem.Name = "dataCollectionToolStripMenuItem";
            this.dataCollectionToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.dataCollectionToolStripMenuItem.Text = "Data Collection";
            this.dataCollectionToolStripMenuItem.Click += new System.EventHandler(this.dataCollectionToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.loadBTN);
            this.groupBox2.Controls.Add(this.removeBTN);
            this.groupBox2.Controls.Add(this.folderLB);
            this.groupBox2.Location = new System.Drawing.Point(12, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 542);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Folders";
            // 
            // loadBTN
            // 
            this.loadBTN.BackColor = System.Drawing.Color.Transparent;
            this.loadBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loadBTN.BackgroundImage")));
            this.loadBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loadBTN.Location = new System.Drawing.Point(6, 480);
            this.loadBTN.Name = "loadBTN";
            this.loadBTN.Size = new System.Drawing.Size(40, 40);
            this.loadBTN.TabIndex = 1;
            this.loadBTN.UseVisualStyleBackColor = false;
            this.loadBTN.Click += new System.EventHandler(this.loadBTN_Click);
            // 
            // removeBTN
            // 
            this.removeBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeBTN.BackgroundImage")));
            this.removeBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.removeBTN.Location = new System.Drawing.Point(157, 480);
            this.removeBTN.Name = "removeBTN";
            this.removeBTN.Size = new System.Drawing.Size(40, 40);
            this.removeBTN.TabIndex = 4;
            this.removeBTN.UseVisualStyleBackColor = true;
            this.removeBTN.Click += new System.EventHandler(this.removeBTN_Click);
            // 
            // folderLB
            // 
            this.folderLB.FormattingEnabled = true;
            this.folderLB.Location = new System.Drawing.Point(6, 19);
            this.folderLB.Name = "folderLB";
            this.folderLB.ScrollAlwaysVisible = true;
            this.folderLB.Size = new System.Drawing.Size(190, 459);
            this.folderLB.TabIndex = 2;
            this.folderLB.SelectedIndexChanged += new System.EventHandler(this.folderLB_SelectedIndexChanged);
            // 
            // imageLB
            // 
            this.imageLB.FormattingEnabled = true;
            this.imageLB.Location = new System.Drawing.Point(6, 19);
            this.imageLB.Name = "imageLB";
            this.imageLB.ScrollAlwaysVisible = true;
            this.imageLB.Size = new System.Drawing.Size(257, 459);
            this.imageLB.TabIndex = 3;
            this.imageLB.SelectedIndexChanged += new System.EventHandler(this.imageLB_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lastAnnotationEndYL);
            this.groupBox5.Controls.Add(this.lastAnnotationEndXL);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.lastAnnotationHeightL);
            this.groupBox5.Controls.Add(this.lastAnnotationWidthL);
            this.groupBox5.Controls.Add(this.lastAnnotationYL);
            this.groupBox5.Controls.Add(this.lastAnnotationXL);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(678, 520);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(259, 58);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Last Annotation:";
            // 
            // lastAnnotationEndYL
            // 
            this.lastAnnotationEndYL.AutoSize = true;
            this.lastAnnotationEndYL.Location = new System.Drawing.Point(142, 41);
            this.lastAnnotationEndYL.Name = "lastAnnotationEndYL";
            this.lastAnnotationEndYL.Size = new System.Drawing.Size(13, 13);
            this.lastAnnotationEndYL.TabIndex = 12;
            this.lastAnnotationEndYL.Text = "0";
            // 
            // lastAnnotationEndXL
            // 
            this.lastAnnotationEndXL.AutoSize = true;
            this.lastAnnotationEndXL.Location = new System.Drawing.Point(142, 19);
            this.lastAnnotationEndXL.Name = "lastAnnotationEndXL";
            this.lastAnnotationEndXL.Size = new System.Drawing.Size(13, 13);
            this.lastAnnotationEndXL.TabIndex = 13;
            this.lastAnnotationEndXL.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(96, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "End X:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(96, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "End Y:";
            // 
            // lastAnnotationHeightL
            // 
            this.lastAnnotationHeightL.AutoSize = true;
            this.lastAnnotationHeightL.Location = new System.Drawing.Point(219, 40);
            this.lastAnnotationHeightL.Name = "lastAnnotationHeightL";
            this.lastAnnotationHeightL.Size = new System.Drawing.Size(13, 13);
            this.lastAnnotationHeightL.TabIndex = 9;
            this.lastAnnotationHeightL.Text = "0";
            // 
            // lastAnnotationWidthL
            // 
            this.lastAnnotationWidthL.AutoSize = true;
            this.lastAnnotationWidthL.Location = new System.Drawing.Point(219, 19);
            this.lastAnnotationWidthL.Name = "lastAnnotationWidthL";
            this.lastAnnotationWidthL.Size = new System.Drawing.Size(13, 13);
            this.lastAnnotationWidthL.TabIndex = 9;
            this.lastAnnotationWidthL.Text = "0";
            // 
            // lastAnnotationYL
            // 
            this.lastAnnotationYL.AutoSize = true;
            this.lastAnnotationYL.Location = new System.Drawing.Point(51, 40);
            this.lastAnnotationYL.Name = "lastAnnotationYL";
            this.lastAnnotationYL.Size = new System.Drawing.Size(13, 13);
            this.lastAnnotationYL.TabIndex = 9;
            this.lastAnnotationYL.Text = "0";
            // 
            // lastAnnotationXL
            // 
            this.lastAnnotationXL.AutoSize = true;
            this.lastAnnotationXL.Location = new System.Drawing.Point(51, 18);
            this.lastAnnotationXL.Name = "lastAnnotationXL";
            this.lastAnnotationXL.Size = new System.Drawing.Size(13, 13);
            this.lastAnnotationXL.TabIndex = 9;
            this.lastAnnotationXL.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Height:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Width:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Start X:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Start Y:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cursorPositionYL);
            this.groupBox4.Controls.Add(this.cursorPositionXL);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(502, 519);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(170, 58);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cursor Position:";
            // 
            // cursorPositionYL
            // 
            this.cursorPositionYL.AutoSize = true;
            this.cursorPositionYL.Location = new System.Drawing.Point(30, 39);
            this.cursorPositionYL.Name = "cursorPositionYL";
            this.cursorPositionYL.Size = new System.Drawing.Size(13, 13);
            this.cursorPositionYL.TabIndex = 9;
            this.cursorPositionYL.Text = "0";
            // 
            // cursorPositionXL
            // 
            this.cursorPositionXL.AutoSize = true;
            this.cursorPositionXL.Location = new System.Drawing.Point(30, 20);
            this.cursorPositionXL.Name = "cursorPositionXL";
            this.cursorPositionXL.Size = new System.Drawing.Size(13, 13);
            this.cursorPositionXL.TabIndex = 9;
            this.cursorPositionXL.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Y:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.imageLB);
            this.groupBox3.Controls.Add(this.imgRemoveBTN);
            this.groupBox3.Location = new System.Drawing.Point(227, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 542);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Images";
            // 
            // imgRemoveBTN
            // 
            this.imgRemoveBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgRemoveBTN.BackgroundImage")));
            this.imgRemoveBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgRemoveBTN.Location = new System.Drawing.Point(226, 480);
            this.imgRemoveBTN.Name = "imgRemoveBTN";
            this.imgRemoveBTN.Size = new System.Drawing.Size(40, 40);
            this.imgRemoveBTN.TabIndex = 6;
            this.imgRemoveBTN.UseVisualStyleBackColor = true;
            this.imgRemoveBTN.Click += new System.EventHandler(this.imgRemoveBTN_Click);
            // 
            // mainPB
            // 
            this.mainPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainPB.Location = new System.Drawing.Point(502, 34);
            this.mainPB.Name = "mainPB";
            this.mainPB.Size = new System.Drawing.Size(640, 480);
            this.mainPB.TabIndex = 11;
            this.mainPB.TabStop = false;
            this.mainPB.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPB_Paint);
            this.mainPB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPB_MouseDown);
            this.mainPB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPB_MouseMove);
            this.mainPB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPB_MouseUp);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.viewAllAnnotationsBTN);
            this.groupBox6.Controls.Add(this.deleteAnnotationBTN);
            this.groupBox6.Controls.Add(this.currentImgAnnotationsLB);
            this.groupBox6.Location = new System.Drawing.Point(502, 584);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(556, 141);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Annotations";
            // 
            // viewAllAnnotationsBTN
            // 
            this.viewAllAnnotationsBTN.Location = new System.Drawing.Point(414, 76);
            this.viewAllAnnotationsBTN.Name = "viewAllAnnotationsBTN";
            this.viewAllAnnotationsBTN.Size = new System.Drawing.Size(75, 23);
            this.viewAllAnnotationsBTN.TabIndex = 2;
            this.viewAllAnnotationsBTN.Text = "View All";
            this.viewAllAnnotationsBTN.UseVisualStyleBackColor = true;
            this.viewAllAnnotationsBTN.Click += new System.EventHandler(this.viewAllAnnotationsBTN_Click);
            // 
            // deleteAnnotationBTN
            // 
            this.deleteAnnotationBTN.Location = new System.Drawing.Point(414, 105);
            this.deleteAnnotationBTN.Name = "deleteAnnotationBTN";
            this.deleteAnnotationBTN.Size = new System.Drawing.Size(75, 23);
            this.deleteAnnotationBTN.TabIndex = 1;
            this.deleteAnnotationBTN.Text = "Delete Annotation";
            this.deleteAnnotationBTN.UseVisualStyleBackColor = true;
            this.deleteAnnotationBTN.Click += new System.EventHandler(this.deleteAnnotationBTN_Click);
            // 
            // currentImgAnnotationsLB
            // 
            this.currentImgAnnotationsLB.FormattingEnabled = true;
            this.currentImgAnnotationsLB.Location = new System.Drawing.Point(7, 20);
            this.currentImgAnnotationsLB.Name = "currentImgAnnotationsLB";
            this.currentImgAnnotationsLB.Size = new System.Drawing.Size(401, 108);
            this.currentImgAnnotationsLB.TabIndex = 0;
            // 
            // saveWorkspaceToolStripMenuItem
            // 
            this.saveWorkspaceToolStripMenuItem.Name = "saveWorkspaceToolStripMenuItem";
            this.saveWorkspaceToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.saveWorkspaceToolStripMenuItem.Text = "Save Workspace";
            this.saveWorkspaceToolStripMenuItem.Click += new System.EventHandler(this.saveWorkspaceToolStripMenuItem_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 759);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.mainPB);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainWindow";
            this.Text = "Annotator";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPB)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button loadBTN;
        private System.Windows.Forms.Button removeBTN;
        private System.Windows.Forms.ListBox folderLB;
        private System.Windows.Forms.ListBox imageLB;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lastAnnotationEndYL;
        private System.Windows.Forms.Label lastAnnotationEndXL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lastAnnotationHeightL;
        private System.Windows.Forms.Label lastAnnotationWidthL;
        private System.Windows.Forms.Label lastAnnotationYL;
        private System.Windows.Forms.Label lastAnnotationXL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label cursorPositionYL;
        private System.Windows.Forms.Label cursorPositionXL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button imgRemoveBTN;
        private System.Windows.Forms.PictureBox mainPB;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button viewAllAnnotationsBTN;
        private System.Windows.Forms.Button deleteAnnotationBTN;
        private System.Windows.Forms.ListBox currentImgAnnotationsLB;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem annotatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataCollectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveWorkspaceToolStripMenuItem;
    }
}

