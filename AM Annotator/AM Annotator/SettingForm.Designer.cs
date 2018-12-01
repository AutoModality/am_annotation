namespace AM_Annotator
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.preferencesTabPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.trainPercentageNUD = new System.Windows.Forms.NumericUpDown();
            this.setBTN = new System.Windows.Forms.Button();
            this.outputDirectoryTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pascalVOCFormatCB = new System.Windows.Forms.CheckBox();
            this.yoloFormatCB = new System.Windows.Forms.CheckBox();
            this.cascadeFormatCB = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.preferencesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainPercentageNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.preferencesTabPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(30, 100);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(656, 365);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // preferencesTabPage
            // 
            this.preferencesTabPage.Controls.Add(this.label2);
            this.preferencesTabPage.Controls.Add(this.trainPercentageNUD);
            this.preferencesTabPage.Controls.Add(this.setBTN);
            this.preferencesTabPage.Controls.Add(this.outputDirectoryTB);
            this.preferencesTabPage.Controls.Add(this.label1);
            this.preferencesTabPage.Controls.Add(this.pascalVOCFormatCB);
            this.preferencesTabPage.Controls.Add(this.yoloFormatCB);
            this.preferencesTabPage.Controls.Add(this.cascadeFormatCB);
            this.preferencesTabPage.Location = new System.Drawing.Point(104, 4);
            this.preferencesTabPage.Name = "preferencesTabPage";
            this.preferencesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.preferencesTabPage.Size = new System.Drawing.Size(548, 357);
            this.preferencesTabPage.TabIndex = 0;
            this.preferencesTabPage.Text = "Annotation Output";
            this.preferencesTabPage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Train Percentage:";
            // 
            // trainPercentageNUD
            // 
            this.trainPercentageNUD.Location = new System.Drawing.Point(104, 289);
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
            this.trainPercentageNUD.TabIndex = 14;
            this.trainPercentageNUD.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.trainPercentageNUD.ValueChanged += new System.EventHandler(this.trainPercentageNUD_ValueChanged);
            // 
            // setBTN
            // 
            this.setBTN.Location = new System.Drawing.Point(402, 321);
            this.setBTN.Name = "setBTN";
            this.setBTN.Size = new System.Drawing.Size(56, 23);
            this.setBTN.TabIndex = 13;
            this.setBTN.Text = "Set";
            this.setBTN.UseVisualStyleBackColor = true;
            this.setBTN.Click += new System.EventHandler(this.setBTN_Click);
            // 
            // outputDirectoryTB
            // 
            this.outputDirectoryTB.Location = new System.Drawing.Point(90, 324);
            this.outputDirectoryTB.Name = "outputDirectoryTB";
            this.outputDirectoryTB.ReadOnly = true;
            this.outputDirectoryTB.Size = new System.Drawing.Size(306, 20);
            this.outputDirectoryTB.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Output Directory:";
            // 
            // pascalVOCFormatCB
            // 
            this.pascalVOCFormatCB.AutoSize = true;
            this.pascalVOCFormatCB.Checked = true;
            this.pascalVOCFormatCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pascalVOCFormatCB.Location = new System.Drawing.Point(6, 65);
            this.pascalVOCFormatCB.Name = "pascalVOCFormatCB";
            this.pascalVOCFormatCB.Size = new System.Drawing.Size(118, 17);
            this.pascalVOCFormatCB.TabIndex = 10;
            this.pascalVOCFormatCB.Text = "Pascal VOC Format";
            this.pascalVOCFormatCB.UseVisualStyleBackColor = true;
            // 
            // yoloFormatCB
            // 
            this.yoloFormatCB.AutoSize = true;
            this.yoloFormatCB.Checked = true;
            this.yoloFormatCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.yoloFormatCB.Location = new System.Drawing.Point(6, 42);
            this.yoloFormatCB.Name = "yoloFormatCB";
            this.yoloFormatCB.Size = new System.Drawing.Size(144, 17);
            this.yoloFormatCB.TabIndex = 9;
            this.yoloFormatCB.Text = "Yolo and Darknet Format";
            this.yoloFormatCB.UseVisualStyleBackColor = true;
            this.yoloFormatCB.CheckedChanged += new System.EventHandler(this.yoloFormatCB_CheckedChanged);
            // 
            // cascadeFormatCB
            // 
            this.cascadeFormatCB.AutoSize = true;
            this.cascadeFormatCB.Checked = true;
            this.cascadeFormatCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cascadeFormatCB.Location = new System.Drawing.Point(6, 18);
            this.cascadeFormatCB.Name = "cascadeFormatCB";
            this.cascadeFormatCB.Size = new System.Drawing.Size(146, 17);
            this.cascadeFormatCB.TabIndex = 8;
            this.cascadeFormatCB.Text = "OpenCV Cascade Format";
            this.cascadeFormatCB.UseVisualStyleBackColor = true;
            this.cascadeFormatCB.CheckedChanged += new System.EventHandler(this.cascadeFormatCB_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(104, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(548, 357);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Data Collection";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 389);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingForm";
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.preferencesTabPage.ResumeLayout(false);
            this.preferencesTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainPercentageNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage preferencesTabPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown trainPercentageNUD;
        private System.Windows.Forms.Button setBTN;
        private System.Windows.Forms.TextBox outputDirectoryTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox pascalVOCFormatCB;
        private System.Windows.Forms.CheckBox yoloFormatCB;
        private System.Windows.Forms.CheckBox cascadeFormatCB;
        private System.Windows.Forms.TabPage tabPage2;
    }
}