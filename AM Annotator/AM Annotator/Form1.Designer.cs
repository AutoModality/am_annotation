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
            this.newWorkspaceBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWorkspaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadLastWorkspaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.projectToolBarBTN = new System.Windows.Forms.ToolStripDropDownButton();
            this.annotatorProjectBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.dataCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectOrganizerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.buildAllBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.buildBTN = new System.Windows.Forms.ToolStripMenuItem();
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
            this.autoClassNUD = new System.Windows.Forms.NumericUpDown();
            this.autoClassCB = new System.Windows.Forms.CheckBox();
            this.deleteAllBTN = new System.Windows.Forms.Button();
            this.viewAllAnnotationsBTN = new System.Windows.Forms.Button();
            this.deleteAnnotationBTN = new System.Windows.Forms.Button();
            this.currentImgAnnotationsLB = new System.Windows.Forms.ListBox();
            this.openProjectBTN = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.loadImageProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.assistantMethodCB = new System.Windows.Forms.ComboBox();
            this.outputDirTB = new System.Windows.Forms.TextBox();
            this.setOutputDirBTN = new System.Windows.Forms.Button();
            this.statusLabelTSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPB)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoClassNUD)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWorkspaceBTN,
            this.saveWorkspaceToolStripMenuItem,
            this.newProjectToolStripMenuItem,
            this.loadLastWorkspaceToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(74, 36);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // newWorkspaceBTN
            // 
            this.newWorkspaceBTN.Name = "newWorkspaceBTN";
            this.newWorkspaceBTN.Size = new System.Drawing.Size(335, 38);
            this.newWorkspaceBTN.Text = "New Workspace";
            this.newWorkspaceBTN.Click += new System.EventHandler(this.newWorkspaceBTN_Click);
            // 
            // saveWorkspaceToolStripMenuItem
            // 
            this.saveWorkspaceToolStripMenuItem.Name = "saveWorkspaceToolStripMenuItem";
            this.saveWorkspaceToolStripMenuItem.Size = new System.Drawing.Size(335, 38);
            this.saveWorkspaceToolStripMenuItem.Text = "Save Workspace";
            this.saveWorkspaceToolStripMenuItem.Click += new System.EventHandler(this.saveWorkspaceToolStripMenuItem_Click);
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(335, 38);
            this.newProjectToolStripMenuItem.Text = "Load Workspace";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
            // 
            // loadLastWorkspaceToolStripMenuItem
            // 
            this.loadLastWorkspaceToolStripMenuItem.Name = "loadLastWorkspaceToolStripMenuItem";
            this.loadLastWorkspaceToolStripMenuItem.Size = new System.Drawing.Size(335, 38);
            this.loadLastWorkspaceToolStripMenuItem.Text = "Load Last Workspace";
            this.loadLastWorkspaceToolStripMenuItem.Click += new System.EventHandler(this.loadLastWorkspaceToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(335, 38);
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
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(77, 36);
            this.toolStripDropDownButton2.Text = "Edit";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(238, 38);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.projectToolBarBTN,
            this.toolStripDropDownButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(2344, 39);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // projectToolBarBTN
            // 
            this.projectToolBarBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.projectToolBarBTN.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.annotatorProjectBTN,
            this.dataCollectionToolStripMenuItem,
            this.projectOrganizerToolStripMenuItem});
            this.projectToolBarBTN.Image = ((System.Drawing.Image)(resources.GetObject("projectToolBarBTN.Image")));
            this.projectToolBarBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.projectToolBarBTN.Name = "projectToolBarBTN";
            this.projectToolBarBTN.Size = new System.Drawing.Size(120, 36);
            this.projectToolBarBTN.Text = "Projects";
            // 
            // annotatorProjectBTN
            // 
            this.annotatorProjectBTN.Name = "annotatorProjectBTN";
            this.annotatorProjectBTN.Size = new System.Drawing.Size(324, 38);
            this.annotatorProjectBTN.Text = "Annotator";
            // 
            // dataCollectionToolStripMenuItem
            // 
            this.dataCollectionToolStripMenuItem.Name = "dataCollectionToolStripMenuItem";
            this.dataCollectionToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.dataCollectionToolStripMenuItem.Text = "Data Collection";
            this.dataCollectionToolStripMenuItem.Click += new System.EventHandler(this.dataCollectionToolStripMenuItem_Click);
            // 
            // projectOrganizerToolStripMenuItem
            // 
            this.projectOrganizerToolStripMenuItem.Name = "projectOrganizerToolStripMenuItem";
            this.projectOrganizerToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.projectOrganizerToolStripMenuItem.Text = "Project Organizer";
            this.projectOrganizerToolStripMenuItem.Click += new System.EventHandler(this.projectOrganizerToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton4
            // 
            this.toolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildAllBTN,
            this.buildBTN});
            this.toolStripDropDownButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton4.Image")));
            this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            this.toolStripDropDownButton4.Size = new System.Drawing.Size(91, 36);
            this.toolStripDropDownButton4.Text = "Build";
            // 
            // buildAllBTN
            // 
            this.buildAllBTN.Name = "buildAllBTN";
            this.buildAllBTN.Size = new System.Drawing.Size(202, 38);
            this.buildAllBTN.Text = "Build All";
            this.buildAllBTN.Click += new System.EventHandler(this.buildAllBTN_Click);
            // 
            // buildBTN
            // 
            this.buildBTN.Name = "buildBTN";
            this.buildBTN.Size = new System.Drawing.Size(202, 38);
            this.buildBTN.Text = "Build";
            this.buildBTN.Click += new System.EventHandler(this.buildBTN_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.loadBTN);
            this.groupBox2.Controls.Add(this.removeBTN);
            this.groupBox2.Controls.Add(this.folderLB);
            this.groupBox2.Location = new System.Drawing.Point(24, 67);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(438, 1042);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Folders";
            // 
            // loadBTN
            // 
            this.loadBTN.BackColor = System.Drawing.Color.Transparent;
            this.loadBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loadBTN.BackgroundImage")));
            this.loadBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loadBTN.Location = new System.Drawing.Point(12, 933);
            this.loadBTN.Margin = new System.Windows.Forms.Padding(6);
            this.loadBTN.Name = "loadBTN";
            this.loadBTN.Size = new System.Drawing.Size(80, 77);
            this.loadBTN.TabIndex = 1;
            this.loadBTN.UseVisualStyleBackColor = false;
            this.loadBTN.Click += new System.EventHandler(this.loadBTN_Click);
            // 
            // removeBTN
            // 
            this.removeBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeBTN.BackgroundImage")));
            this.removeBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.removeBTN.Location = new System.Drawing.Point(346, 933);
            this.removeBTN.Margin = new System.Windows.Forms.Padding(6);
            this.removeBTN.Name = "removeBTN";
            this.removeBTN.Size = new System.Drawing.Size(80, 77);
            this.removeBTN.TabIndex = 4;
            this.removeBTN.UseVisualStyleBackColor = true;
            this.removeBTN.Click += new System.EventHandler(this.removeBTN_Click);
            // 
            // folderLB
            // 
            this.folderLB.ItemHeight = 25;
            this.folderLB.Location = new System.Drawing.Point(12, 37);
            this.folderLB.Margin = new System.Windows.Forms.Padding(6);
            this.folderLB.Name = "folderLB";
            this.folderLB.Size = new System.Drawing.Size(410, 879);
            this.folderLB.TabIndex = 2;
            this.folderLB.SelectedIndexChanged += new System.EventHandler(this.folderLB_SelectedIndexChanged);
            // 
            // imageLB
            // 
            this.imageLB.FormattingEnabled = true;
            this.imageLB.ItemHeight = 25;
            this.imageLB.Location = new System.Drawing.Point(12, 37);
            this.imageLB.Margin = new System.Windows.Forms.Padding(6);
            this.imageLB.Name = "imageLB";
            this.imageLB.ScrollAlwaysVisible = true;
            this.imageLB.Size = new System.Drawing.Size(510, 879);
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
            this.groupBox5.Location = new System.Drawing.Point(1386, 1000);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox5.Size = new System.Drawing.Size(518, 112);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Last Annotation:";
            // 
            // lastAnnotationEndYL
            // 
            this.lastAnnotationEndYL.AutoSize = true;
            this.lastAnnotationEndYL.Location = new System.Drawing.Point(284, 79);
            this.lastAnnotationEndYL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lastAnnotationEndYL.Name = "lastAnnotationEndYL";
            this.lastAnnotationEndYL.Size = new System.Drawing.Size(24, 25);
            this.lastAnnotationEndYL.TabIndex = 12;
            this.lastAnnotationEndYL.Text = "0";
            // 
            // lastAnnotationEndXL
            // 
            this.lastAnnotationEndXL.AutoSize = true;
            this.lastAnnotationEndXL.Location = new System.Drawing.Point(284, 37);
            this.lastAnnotationEndXL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lastAnnotationEndXL.Name = "lastAnnotationEndXL";
            this.lastAnnotationEndXL.Size = new System.Drawing.Size(24, 25);
            this.lastAnnotationEndXL.TabIndex = 13;
            this.lastAnnotationEndXL.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(192, 37);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 25);
            this.label11.TabIndex = 10;
            this.label11.Text = "End X:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(192, 79);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 25);
            this.label12.TabIndex = 11;
            this.label12.Text = "End Y:";
            // 
            // lastAnnotationHeightL
            // 
            this.lastAnnotationHeightL.AutoSize = true;
            this.lastAnnotationHeightL.Location = new System.Drawing.Point(438, 77);
            this.lastAnnotationHeightL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lastAnnotationHeightL.Name = "lastAnnotationHeightL";
            this.lastAnnotationHeightL.Size = new System.Drawing.Size(24, 25);
            this.lastAnnotationHeightL.TabIndex = 9;
            this.lastAnnotationHeightL.Text = "0";
            // 
            // lastAnnotationWidthL
            // 
            this.lastAnnotationWidthL.AutoSize = true;
            this.lastAnnotationWidthL.Location = new System.Drawing.Point(438, 37);
            this.lastAnnotationWidthL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lastAnnotationWidthL.Name = "lastAnnotationWidthL";
            this.lastAnnotationWidthL.Size = new System.Drawing.Size(24, 25);
            this.lastAnnotationWidthL.TabIndex = 9;
            this.lastAnnotationWidthL.Text = "0";
            // 
            // lastAnnotationYL
            // 
            this.lastAnnotationYL.AutoSize = true;
            this.lastAnnotationYL.Location = new System.Drawing.Point(102, 77);
            this.lastAnnotationYL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lastAnnotationYL.Name = "lastAnnotationYL";
            this.lastAnnotationYL.Size = new System.Drawing.Size(24, 25);
            this.lastAnnotationYL.TabIndex = 9;
            this.lastAnnotationYL.Text = "0";
            // 
            // lastAnnotationXL
            // 
            this.lastAnnotationXL.AutoSize = true;
            this.lastAnnotationXL.Location = new System.Drawing.Point(102, 35);
            this.lastAnnotationXL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lastAnnotationXL.Name = "lastAnnotationXL";
            this.lastAnnotationXL.Size = new System.Drawing.Size(24, 25);
            this.lastAnnotationXL.TabIndex = 9;
            this.lastAnnotationXL.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(350, 77);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Height:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Width:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Start X:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Start Y:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cursorPositionYL);
            this.groupBox4.Controls.Add(this.cursorPositionXL);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(1034, 998);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox4.Size = new System.Drawing.Size(340, 112);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cursor Position:";
            // 
            // cursorPositionYL
            // 
            this.cursorPositionYL.AutoSize = true;
            this.cursorPositionYL.Location = new System.Drawing.Point(60, 75);
            this.cursorPositionYL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cursorPositionYL.Name = "cursorPositionYL";
            this.cursorPositionYL.Size = new System.Drawing.Size(24, 25);
            this.cursorPositionYL.TabIndex = 9;
            this.cursorPositionYL.Text = "0";
            // 
            // cursorPositionXL
            // 
            this.cursorPositionXL.AutoSize = true;
            this.cursorPositionXL.Location = new System.Drawing.Point(60, 38);
            this.cursorPositionXL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cursorPositionXL.Name = "cursorPositionXL";
            this.cursorPositionXL.Size = new System.Drawing.Size(24, 25);
            this.cursorPositionXL.TabIndex = 9;
            this.cursorPositionXL.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Y:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.imageLB);
            this.groupBox3.Controls.Add(this.imgRemoveBTN);
            this.groupBox3.Location = new System.Drawing.Point(474, 67);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(538, 1042);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Images";
            // 
            // imgRemoveBTN
            // 
            this.imgRemoveBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgRemoveBTN.BackgroundImage")));
            this.imgRemoveBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgRemoveBTN.Location = new System.Drawing.Point(446, 933);
            this.imgRemoveBTN.Margin = new System.Windows.Forms.Padding(6);
            this.imgRemoveBTN.Name = "imgRemoveBTN";
            this.imgRemoveBTN.Size = new System.Drawing.Size(80, 77);
            this.imgRemoveBTN.TabIndex = 6;
            this.imgRemoveBTN.UseVisualStyleBackColor = true;
            this.imgRemoveBTN.Click += new System.EventHandler(this.imgRemoveBTN_Click);
            // 
            // mainPB
            // 
            this.mainPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainPB.Location = new System.Drawing.Point(1030, 65);
            this.mainPB.Margin = new System.Windows.Forms.Padding(6);
            this.mainPB.Name = "mainPB";
            this.mainPB.Size = new System.Drawing.Size(1276, 919);
            this.mainPB.TabIndex = 11;
            this.mainPB.TabStop = false;
            this.mainPB.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPB_Paint);
            this.mainPB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPB_MouseDown);
            this.mainPB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPB_MouseMove);
            this.mainPB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPB_MouseUp);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.autoClassNUD);
            this.groupBox6.Controls.Add(this.autoClassCB);
            this.groupBox6.Controls.Add(this.deleteAllBTN);
            this.groupBox6.Controls.Add(this.viewAllAnnotationsBTN);
            this.groupBox6.Controls.Add(this.deleteAnnotationBTN);
            this.groupBox6.Controls.Add(this.currentImgAnnotationsLB);
            this.groupBox6.Location = new System.Drawing.Point(1036, 1123);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox6.Size = new System.Drawing.Size(1270, 271);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Annotations";
            // 
            // autoClassNUD
            // 
            this.autoClassNUD.Enabled = false;
            this.autoClassNUD.Location = new System.Drawing.Point(1015, 87);
            this.autoClassNUD.Name = "autoClassNUD";
            this.autoClassNUD.Size = new System.Drawing.Size(211, 31);
            this.autoClassNUD.TabIndex = 5;
            // 
            // autoClassCB
            // 
            this.autoClassCB.AutoSize = true;
            this.autoClassCB.Location = new System.Drawing.Point(1015, 40);
            this.autoClassCB.Name = "autoClassCB";
            this.autoClassCB.Size = new System.Drawing.Size(221, 29);
            this.autoClassCB.TabIndex = 4;
            this.autoClassCB.Text = "Enable Auto Class";
            this.autoClassCB.UseVisualStyleBackColor = true;
            this.autoClassCB.CheckedChanged += new System.EventHandler(this.autoClassCB_CheckedChanged);
            // 
            // deleteAllBTN
            // 
            this.deleteAllBTN.Location = new System.Drawing.Point(828, 146);
            this.deleteAllBTN.Margin = new System.Windows.Forms.Padding(6);
            this.deleteAllBTN.Name = "deleteAllBTN";
            this.deleteAllBTN.Size = new System.Drawing.Size(150, 44);
            this.deleteAllBTN.TabIndex = 3;
            this.deleteAllBTN.Text = "Delete All";
            this.deleteAllBTN.UseVisualStyleBackColor = true;
            this.deleteAllBTN.Click += new System.EventHandler(this.deleteAllBTN_Click);
            // 
            // viewAllAnnotationsBTN
            // 
            this.viewAllAnnotationsBTN.Location = new System.Drawing.Point(828, 87);
            this.viewAllAnnotationsBTN.Margin = new System.Windows.Forms.Padding(6);
            this.viewAllAnnotationsBTN.Name = "viewAllAnnotationsBTN";
            this.viewAllAnnotationsBTN.Size = new System.Drawing.Size(150, 44);
            this.viewAllAnnotationsBTN.TabIndex = 2;
            this.viewAllAnnotationsBTN.Text = "View All";
            this.viewAllAnnotationsBTN.UseVisualStyleBackColor = true;
            this.viewAllAnnotationsBTN.Click += new System.EventHandler(this.viewAllAnnotationsBTN_Click);
            // 
            // deleteAnnotationBTN
            // 
            this.deleteAnnotationBTN.Location = new System.Drawing.Point(828, 202);
            this.deleteAnnotationBTN.Margin = new System.Windows.Forms.Padding(6);
            this.deleteAnnotationBTN.Name = "deleteAnnotationBTN";
            this.deleteAnnotationBTN.Size = new System.Drawing.Size(150, 44);
            this.deleteAnnotationBTN.TabIndex = 1;
            this.deleteAnnotationBTN.Text = "Delete";
            this.deleteAnnotationBTN.UseVisualStyleBackColor = true;
            this.deleteAnnotationBTN.Click += new System.EventHandler(this.deleteAnnotationBTN_Click);
            // 
            // currentImgAnnotationsLB
            // 
            this.currentImgAnnotationsLB.FormattingEnabled = true;
            this.currentImgAnnotationsLB.ItemHeight = 25;
            this.currentImgAnnotationsLB.Location = new System.Drawing.Point(14, 38);
            this.currentImgAnnotationsLB.Margin = new System.Windows.Forms.Padding(6);
            this.currentImgAnnotationsLB.Name = "currentImgAnnotationsLB";
            this.currentImgAnnotationsLB.Size = new System.Drawing.Size(798, 204);
            this.currentImgAnnotationsLB.TabIndex = 0;
            // 
            // openProjectBTN
            // 
            this.openProjectBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openProjectBTN.Location = new System.Drawing.Point(24, 1123);
            this.openProjectBTN.Margin = new System.Windows.Forms.Padding(6);
            this.openProjectBTN.Name = "openProjectBTN";
            this.openProjectBTN.Size = new System.Drawing.Size(438, 106);
            this.openProjectBTN.TabIndex = 17;
            this.openProjectBTN.Text = "Open Annotation Location";
            this.openProjectBTN.UseVisualStyleBackColor = true;
            this.openProjectBTN.Click += new System.EventHandler(this.projectBTN_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageProgressBar,
            this.statusLabelTSSL});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1414);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusStrip1.Size = new System.Drawing.Size(2344, 37);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // loadImageProgressBar
            // 
            this.loadImageProgressBar.Name = "loadImageProgressBar";
            this.loadImageProgressBar.Size = new System.Drawing.Size(400, 31);
            this.loadImageProgressBar.Step = 1;
            // 
            // assistantMethodCB
            // 
            this.assistantMethodCB.FormattingEnabled = true;
            this.assistantMethodCB.ItemHeight = 25;
            this.assistantMethodCB.Items.AddRange(new object[] {
            "Select Assistant",
            "Tracker",
            "Feature Descriptors",
            "Sequence"});
            this.assistantMethodCB.Location = new System.Drawing.Point(1916, 1019);
            this.assistantMethodCB.Margin = new System.Windows.Forms.Padding(6);
            this.assistantMethodCB.Name = "assistantMethodCB";
            this.assistantMethodCB.Size = new System.Drawing.Size(390, 33);
            this.assistantMethodCB.TabIndex = 19;
            this.assistantMethodCB.SelectedIndexChanged += new System.EventHandler(this.assistantMethodCB_SelectedIndexChanged);
            // 
            // outputDirTB
            // 
            this.outputDirTB.Location = new System.Drawing.Point(24, 1334);
            this.outputDirTB.Name = "outputDirTB";
            this.outputDirTB.Size = new System.Drawing.Size(753, 31);
            this.outputDirTB.TabIndex = 20;
            // 
            // setOutputDirBTN
            // 
            this.setOutputDirBTN.Location = new System.Drawing.Point(791, 1329);
            this.setOutputDirBTN.Name = "setOutputDirBTN";
            this.setOutputDirBTN.Size = new System.Drawing.Size(221, 40);
            this.setOutputDirBTN.TabIndex = 21;
            this.setOutputDirBTN.Text = "Set Output Directory";
            this.setOutputDirBTN.UseVisualStyleBackColor = true;
            this.setOutputDirBTN.Click += new System.EventHandler(this.setOutputDirBTN_Click);
            // 
            // statusLabelTSSL
            // 
            this.statusLabelTSSL.Name = "statusLabelTSSL";
            this.statusLabelTSSL.Size = new System.Drawing.Size(0, 32);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2344, 1451);
            this.Controls.Add(this.setOutputDirBTN);
            this.Controls.Add(this.outputDirTB);
            this.Controls.Add(this.assistantMethodCB);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.openProjectBTN);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.mainPB);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainWindow";
            this.Text = "Annotator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainWindow_FormClosing);
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.Resize += new System.EventHandler(this.mainWindow_Resize);
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
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoClassNUD)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem newWorkspaceBTN;
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
        private System.Windows.Forms.ToolStripDropDownButton projectToolBarBTN;
        private System.Windows.Forms.ToolStripMenuItem annotatorProjectBTN;
        private System.Windows.Forms.ToolStripMenuItem dataCollectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveWorkspaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
        private System.Windows.Forms.ToolStripMenuItem buildAllBTN;
        private System.Windows.Forms.ToolStripMenuItem buildBTN;
        private System.Windows.Forms.Button openProjectBTN;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar loadImageProgressBar;
        private System.Windows.Forms.ToolStripMenuItem loadLastWorkspaceToolStripMenuItem;
        private System.Windows.Forms.Button deleteAllBTN;
        private System.Windows.Forms.ComboBox assistantMethodCB;
        private System.Windows.Forms.ToolStripMenuItem projectOrganizerToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown autoClassNUD;
        private System.Windows.Forms.CheckBox autoClassCB;
        private System.Windows.Forms.TextBox outputDirTB;
        private System.Windows.Forms.Button setOutputDirBTN;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelTSSL;
    }
}

