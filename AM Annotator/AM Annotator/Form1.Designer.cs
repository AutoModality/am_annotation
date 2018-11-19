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
            System.Windows.Forms.TabPage settingsTab;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.mainPB = new System.Windows.Forms.PictureBox();
            this.loadBTN = new System.Windows.Forms.Button();
            this.folderLB = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.annotationTab = new System.Windows.Forms.TabPage();
            this.removeBTN = new System.Windows.Forms.Button();
            this.imageLB = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cascadeFormatCB = new System.Windows.Forms.CheckBox();
            this.yoloFormatCB = new System.Windows.Forms.CheckBox();
            this.pascalVOCFormatCB = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outputDirectoryTB = new System.Windows.Forms.TextBox();
            this.setBTN = new System.Windows.Forms.Button();
            this.trainPercentageNUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cursorPositionXL = new System.Windows.Forms.Label();
            this.cursorPositionYL = new System.Windows.Forms.Label();
            this.lastAnnotationXL = new System.Windows.Forms.Label();
            this.lastAnnotationYL = new System.Windows.Forms.Label();
            this.lastAnnotationWidthL = new System.Windows.Forms.Label();
            this.lastAnnotationHeightL = new System.Windows.Forms.Label();
            this.imgRemoveBTN = new System.Windows.Forms.Button();
            this.lastAnnotationEndYL = new System.Windows.Forms.Label();
            this.lastAnnotationEndXL = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            settingsTab = new System.Windows.Forms.TabPage();
            settingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPB)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.annotationTab.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainPercentageNUD)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsTab
            // 
            settingsTab.Controls.Add(this.groupBox1);
            settingsTab.Location = new System.Drawing.Point(4, 22);
            settingsTab.Name = "settingsTab";
            settingsTab.Padding = new System.Windows.Forms.Padding(3);
            settingsTab.Size = new System.Drawing.Size(1130, 556);
            settingsTab.TabIndex = 1;
            settingsTab.Text = "Settings";
            settingsTab.UseVisualStyleBackColor = true;
            // 
            // mainPB
            // 
            this.mainPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainPB.Location = new System.Drawing.Point(477, 6);
            this.mainPB.Name = "mainPB";
            this.mainPB.Size = new System.Drawing.Size(640, 480);
            this.mainPB.TabIndex = 0;
            this.mainPB.TabStop = false;
            this.mainPB.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPB_Paint);
            this.mainPB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPB_MouseDown);
            this.mainPB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPB_MouseMove);
            this.mainPB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPB_MouseUp);
            // 
            // loadBTN
            // 
            this.loadBTN.BackColor = System.Drawing.Color.Transparent;
            this.loadBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loadBTN.BackgroundImage")));
            this.loadBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loadBTN.Location = new System.Drawing.Point(6, 481);
            this.loadBTN.Name = "loadBTN";
            this.loadBTN.Size = new System.Drawing.Size(29, 25);
            this.loadBTN.TabIndex = 1;
            this.loadBTN.UseVisualStyleBackColor = false;
            this.loadBTN.Click += new System.EventHandler(this.loadBTN_Click);
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
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.annotationTab);
            this.tabControl1.Controls.Add(settingsTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1138, 602);
            this.tabControl1.TabIndex = 3;
            // 
            // annotationTab
            // 
            this.annotationTab.Controls.Add(this.groupBox5);
            this.annotationTab.Controls.Add(this.groupBox4);
            this.annotationTab.Controls.Add(this.groupBox3);
            this.annotationTab.Controls.Add(this.groupBox2);
            this.annotationTab.Controls.Add(this.mainPB);
            this.annotationTab.Location = new System.Drawing.Point(4, 22);
            this.annotationTab.Name = "annotationTab";
            this.annotationTab.Padding = new System.Windows.Forms.Padding(3);
            this.annotationTab.Size = new System.Drawing.Size(1130, 576);
            this.annotationTab.TabIndex = 0;
            this.annotationTab.Text = "Annotation";
            this.annotationTab.UseVisualStyleBackColor = true;
            // 
            // removeBTN
            // 
            this.removeBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeBTN.BackgroundImage")));
            this.removeBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.removeBTN.Location = new System.Drawing.Point(157, 480);
            this.removeBTN.Name = "removeBTN";
            this.removeBTN.Size = new System.Drawing.Size(29, 25);
            this.removeBTN.TabIndex = 4;
            this.removeBTN.UseVisualStyleBackColor = true;
            this.removeBTN.Click += new System.EventHandler(this.removeBTN_Click);
            // 
            // imageLB
            // 
            this.imageLB.FormattingEnabled = true;
            this.imageLB.Location = new System.Drawing.Point(6, 19);
            this.imageLB.Name = "imageLB";
            this.imageLB.ScrollAlwaysVisible = true;
            this.imageLB.Size = new System.Drawing.Size(238, 459);
            this.imageLB.TabIndex = 3;
            this.imageLB.SelectedIndexChanged += new System.EventHandler(this.imageLB_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1162, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fileToolStripMenuItem.Text = "New Project";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newProjectToolStripMenuItem.Text = "Load Project";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.trainPercentageNUD);
            this.groupBox1.Controls.Add(this.setBTN);
            this.groupBox1.Controls.Add(this.outputDirectoryTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pascalVOCFormatCB);
            this.groupBox1.Controls.Add(this.yoloFormatCB);
            this.groupBox1.Controls.Add(this.cascadeFormatCB);
            this.groupBox1.Location = new System.Drawing.Point(16, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // cascadeFormatCB
            // 
            this.cascadeFormatCB.AutoSize = true;
            this.cascadeFormatCB.Checked = true;
            this.cascadeFormatCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cascadeFormatCB.Location = new System.Drawing.Point(7, 20);
            this.cascadeFormatCB.Name = "cascadeFormatCB";
            this.cascadeFormatCB.Size = new System.Drawing.Size(146, 17);
            this.cascadeFormatCB.TabIndex = 0;
            this.cascadeFormatCB.Text = "OpenCV Cascade Format";
            this.cascadeFormatCB.UseVisualStyleBackColor = true;
            // 
            // yoloFormatCB
            // 
            this.yoloFormatCB.AutoSize = true;
            this.yoloFormatCB.Checked = true;
            this.yoloFormatCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.yoloFormatCB.Location = new System.Drawing.Point(7, 44);
            this.yoloFormatCB.Name = "yoloFormatCB";
            this.yoloFormatCB.Size = new System.Drawing.Size(144, 17);
            this.yoloFormatCB.TabIndex = 1;
            this.yoloFormatCB.Text = "Yolo and Darknet Format";
            this.yoloFormatCB.UseVisualStyleBackColor = true;
            // 
            // pascalVOCFormatCB
            // 
            this.pascalVOCFormatCB.AutoSize = true;
            this.pascalVOCFormatCB.Checked = true;
            this.pascalVOCFormatCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pascalVOCFormatCB.Location = new System.Drawing.Point(7, 67);
            this.pascalVOCFormatCB.Name = "pascalVOCFormatCB";
            this.pascalVOCFormatCB.Size = new System.Drawing.Size(118, 17);
            this.pascalVOCFormatCB.TabIndex = 2;
            this.pascalVOCFormatCB.Text = "Pascal VOC Format";
            this.pascalVOCFormatCB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Output Directory:";
            // 
            // outputDirectoryTB
            // 
            this.outputDirectoryTB.Location = new System.Drawing.Point(91, 208);
            this.outputDirectoryTB.Name = "outputDirectoryTB";
            this.outputDirectoryTB.Size = new System.Drawing.Size(306, 20);
            this.outputDirectoryTB.TabIndex = 4;
            // 
            // setBTN
            // 
            this.setBTN.Location = new System.Drawing.Point(403, 205);
            this.setBTN.Name = "setBTN";
            this.setBTN.Size = new System.Drawing.Size(56, 23);
            this.setBTN.TabIndex = 5;
            this.setBTN.Text = "Set";
            this.setBTN.UseVisualStyleBackColor = true;
            this.setBTN.Click += new System.EventHandler(this.setBTN_Click);
            // 
            // trainPercentageNUD
            // 
            this.trainPercentageNUD.Location = new System.Drawing.Point(105, 173);
            this.trainPercentageNUD.Maximum = new decimal(new int[] {
            95,
            0,
            0,
            0});
            this.trainPercentageNUD.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.trainPercentageNUD.Name = "trainPercentageNUD";
            this.trainPercentageNUD.Size = new System.Drawing.Size(120, 20);
            this.trainPercentageNUD.TabIndex = 6;
            this.trainPercentageNUD.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Train Percentage:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.loadBTN);
            this.groupBox2.Controls.Add(this.removeBTN);
            this.groupBox2.Controls.Add(this.folderLB);
            this.groupBox2.Location = new System.Drawing.Point(6, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 542);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Folders";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.imageLB);
            this.groupBox3.Controls.Add(this.imgRemoveBTN);
            this.groupBox3.Location = new System.Drawing.Point(221, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 542);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Images";
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cursorPositionYL);
            this.groupBox4.Controls.Add(this.cursorPositionXL);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(477, 491);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(170, 58);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cursor Position:";
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
            this.groupBox5.Location = new System.Drawing.Point(653, 492);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(259, 58);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Last Annotation:";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Width:";
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
            // cursorPositionXL
            // 
            this.cursorPositionXL.AutoSize = true;
            this.cursorPositionXL.Location = new System.Drawing.Point(30, 20);
            this.cursorPositionXL.Name = "cursorPositionXL";
            this.cursorPositionXL.Size = new System.Drawing.Size(13, 13);
            this.cursorPositionXL.TabIndex = 9;
            this.cursorPositionXL.Text = "0";
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
            // lastAnnotationXL
            // 
            this.lastAnnotationXL.AutoSize = true;
            this.lastAnnotationXL.Location = new System.Drawing.Point(51, 18);
            this.lastAnnotationXL.Name = "lastAnnotationXL";
            this.lastAnnotationXL.Size = new System.Drawing.Size(13, 13);
            this.lastAnnotationXL.TabIndex = 9;
            this.lastAnnotationXL.Text = "0";
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
            // lastAnnotationWidthL
            // 
            this.lastAnnotationWidthL.AutoSize = true;
            this.lastAnnotationWidthL.Location = new System.Drawing.Point(219, 19);
            this.lastAnnotationWidthL.Name = "lastAnnotationWidthL";
            this.lastAnnotationWidthL.Size = new System.Drawing.Size(13, 13);
            this.lastAnnotationWidthL.TabIndex = 9;
            this.lastAnnotationWidthL.Text = "0";
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
            // imgRemoveBTN
            // 
            this.imgRemoveBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgRemoveBTN.BackgroundImage")));
            this.imgRemoveBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgRemoveBTN.Location = new System.Drawing.Point(205, 480);
            this.imgRemoveBTN.Name = "imgRemoveBTN";
            this.imgRemoveBTN.Size = new System.Drawing.Size(29, 25);
            this.imgRemoveBTN.TabIndex = 6;
            this.imgRemoveBTN.UseVisualStyleBackColor = true;
            this.imgRemoveBTN.Click += new System.EventHandler(this.imgRemoveBTN_Click);
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
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 631);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainWindow";
            this.Text = "AM Annotator";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            settingsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPB)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.annotationTab.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainPercentageNUD)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPB;
        private System.Windows.Forms.Button loadBTN;
        private System.Windows.Forms.ListBox folderLB;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage annotationTab;
        private System.Windows.Forms.ListBox imageLB;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button removeBTN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button setBTN;
        private System.Windows.Forms.TextBox outputDirectoryTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox pascalVOCFormatCB;
        private System.Windows.Forms.CheckBox yoloFormatCB;
        private System.Windows.Forms.CheckBox cascadeFormatCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown trainPercentageNUD;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lastAnnotationHeightL;
        private System.Windows.Forms.Label lastAnnotationWidthL;
        private System.Windows.Forms.Label lastAnnotationYL;
        private System.Windows.Forms.Label lastAnnotationXL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label cursorPositionYL;
        private System.Windows.Forms.Label cursorPositionXL;
        private System.Windows.Forms.Button imgRemoveBTN;
        private System.Windows.Forms.Label lastAnnotationEndYL;
        private System.Windows.Forms.Label lastAnnotationEndXL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

