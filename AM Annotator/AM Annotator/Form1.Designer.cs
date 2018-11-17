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
            System.Windows.Forms.TabPage settingsTab;
            this.mainPB = new System.Windows.Forms.PictureBox();
            this.loadBTN = new System.Windows.Forms.Button();
            this.folderLB = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.annotationTab = new System.Windows.Forms.TabPage();
            this.imageLB = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeBTN = new System.Windows.Forms.Button();
            settingsTab = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.mainPB)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.annotationTab.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPB
            // 
            this.mainPB.Location = new System.Drawing.Point(477, 6);
            this.mainPB.Name = "mainPB";
            this.mainPB.Size = new System.Drawing.Size(640, 480);
            this.mainPB.TabIndex = 0;
            this.mainPB.TabStop = false;
            // 
            // loadBTN
            // 
            this.loadBTN.BackColor = System.Drawing.Color.Transparent;
            this.loadBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loadBTN.BackgroundImage")));
            this.loadBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loadBTN.Location = new System.Drawing.Point(6, 497);
            this.loadBTN.Name = "loadBTN";
            this.loadBTN.Size = new System.Drawing.Size(59, 55);
            this.loadBTN.TabIndex = 1;
            this.loadBTN.UseVisualStyleBackColor = false;
            this.loadBTN.Click += new System.EventHandler(this.loadBTN_Click);
            // 
            // folderLB
            // 
            this.folderLB.FormattingEnabled = true;
            this.folderLB.Location = new System.Drawing.Point(6, 6);
            this.folderLB.Name = "folderLB";
            this.folderLB.ScrollAlwaysVisible = true;
            this.folderLB.Size = new System.Drawing.Size(190, 485);
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
            this.tabControl1.Size = new System.Drawing.Size(1131, 582);
            this.tabControl1.TabIndex = 3;
            // 
            // annotationTab
            // 
            this.annotationTab.Controls.Add(this.removeBTN);
            this.annotationTab.Controls.Add(this.imageLB);
            this.annotationTab.Controls.Add(this.loadBTN);
            this.annotationTab.Controls.Add(this.mainPB);
            this.annotationTab.Controls.Add(this.folderLB);
            this.annotationTab.Location = new System.Drawing.Point(4, 22);
            this.annotationTab.Name = "annotationTab";
            this.annotationTab.Padding = new System.Windows.Forms.Padding(3);
            this.annotationTab.Size = new System.Drawing.Size(1123, 556);
            this.annotationTab.TabIndex = 0;
            this.annotationTab.Text = "Annotation";
            this.annotationTab.UseVisualStyleBackColor = true;
            // 
            // imageLB
            // 
            this.imageLB.FormattingEnabled = true;
            this.imageLB.Location = new System.Drawing.Point(203, 7);
            this.imageLB.Name = "imageLB";
            this.imageLB.ScrollAlwaysVisible = true;
            this.imageLB.Size = new System.Drawing.Size(268, 303);
            this.imageLB.TabIndex = 3;
            this.imageLB.SelectedIndexChanged += new System.EventHandler(this.imageLB_SelectedIndexChanged);
            // 
            // settingsTab
            // 
            settingsTab.Location = new System.Drawing.Point(4, 22);
            settingsTab.Name = "settingsTab";
            settingsTab.Padding = new System.Windows.Forms.Padding(3);
            settingsTab.Size = new System.Drawing.Size(1123, 543);
            settingsTab.TabIndex = 1;
            settingsTab.Text = "Settings";
            settingsTab.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1155, 25);
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
            // removeBTN
            // 
            this.removeBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeBTN.BackgroundImage")));
            this.removeBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.removeBTN.Location = new System.Drawing.Point(72, 497);
            this.removeBTN.Name = "removeBTN";
            this.removeBTN.Size = new System.Drawing.Size(59, 55);
            this.removeBTN.TabIndex = 4;
            this.removeBTN.UseVisualStyleBackColor = true;
            this.removeBTN.Click += new System.EventHandler(this.removeBTN_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 611);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainWindow";
            this.Text = "AM Annotator";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainPB)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.annotationTab.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
    }
}

