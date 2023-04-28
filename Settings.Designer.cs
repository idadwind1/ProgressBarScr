namespace ProgressBarSrc
{
    partial class Settings
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MaxHeight = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MinHeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.MaxWidth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.MinWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MaxIncre = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.MinIncre = new System.Windows.Forms.NumericUpDown();
            this.MaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.MinSpeed = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Background = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ProBarCnt = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ApplyChanges = new System.Windows.Forms.Button();
            this.Discard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinWidth)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxIncre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinIncre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinSpeed)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProBarCnt)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Controls.Add(this.tabPage4);
            this.TabControl.Controls.Add(this.tabPage5);
            this.TabControl.Location = new System.Drawing.Point(16, 15);
            this.TabControl.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(261, 176);
            this.TabControl.TabIndex = 0;
            this.TabControl.Tag = "";
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.ValueChanged);
            this.TabControl.MouseHover += new System.EventHandler(this.ControlEnter);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.MaxHeight);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.MinHeight);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.MaxWidth);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.MinWidth);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(253, 147);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Size";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MaxHeight
            // 
            this.MaxHeight.Location = new System.Drawing.Point(128, 109);
            this.MaxHeight.Margin = new System.Windows.Forms.Padding(4);
            this.MaxHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MaxHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxHeight.Name = "MaxHeight";
            this.MaxHeight.Size = new System.Drawing.Size(115, 25);
            this.MaxHeight.TabIndex = 6;
            this.MaxHeight.Tag = "";
            this.MaxHeight.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.MaxHeight.MouseHover += new System.EventHandler(this.ControlEnter);
            this.MaxHeight.Enter += new System.EventHandler(this.ControlEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Maximum Width: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Maximum Width: ";
            // 
            // MinHeight
            // 
            this.MinHeight.Location = new System.Drawing.Point(128, 75);
            this.MinHeight.Margin = new System.Windows.Forms.Padding(4);
            this.MinHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MinHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MinHeight.Name = "MinHeight";
            this.MinHeight.Size = new System.Drawing.Size(115, 25);
            this.MinHeight.TabIndex = 5;
            this.MinHeight.Tag = "";
            this.MinHeight.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MinHeight.MouseHover += new System.EventHandler(this.ControlEnter);
            this.MinHeight.Enter += new System.EventHandler(this.ControlEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Minimum Width: ";
            // 
            // MaxWidth
            // 
            this.MaxWidth.Location = new System.Drawing.Point(128, 41);
            this.MaxWidth.Margin = new System.Windows.Forms.Padding(4);
            this.MaxWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MaxWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxWidth.Name = "MaxWidth";
            this.MaxWidth.Size = new System.Drawing.Size(115, 25);
            this.MaxWidth.TabIndex = 3;
            this.MaxWidth.Tag = "";
            this.MaxWidth.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.MaxWidth.MouseHover += new System.EventHandler(this.ControlEnter);
            this.MaxWidth.Enter += new System.EventHandler(this.ControlEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Maximum Width: ";
            // 
            // MinWidth
            // 
            this.MinWidth.Location = new System.Drawing.Point(128, 8);
            this.MinWidth.Margin = new System.Windows.Forms.Padding(4);
            this.MinWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MinWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MinWidth.Name = "MinWidth";
            this.MinWidth.Size = new System.Drawing.Size(115, 25);
            this.MinWidth.TabIndex = 1;
            this.MinWidth.Tag = "";
            this.MinWidth.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.MinWidth.MouseHover += new System.EventHandler(this.ControlEnter);
            this.MinWidth.Enter += new System.EventHandler(this.ControlEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minimum Width: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.MaxIncre);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.MinIncre);
            this.tabPage2.Controls.Add(this.MaxSpeed);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.MinSpeed);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(253, 147);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Speed";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MaxIncre
            // 
            this.MaxIncre.Location = new System.Drawing.Point(161, 107);
            this.MaxIncre.Margin = new System.Windows.Forms.Padding(4);
            this.MaxIncre.Name = "MaxIncre";
            this.MaxIncre.Size = new System.Drawing.Size(82, 25);
            this.MaxIncre.TabIndex = 8;
            this.MaxIncre.Tag = "";
            this.MaxIncre.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MaxIncre.MouseHover += new System.EventHandler(this.ControlEnter);
            this.MaxIncre.Enter += new System.EventHandler(this.ControlEnter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 109);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "Maximum Increment: ";
            // 
            // MinIncre
            // 
            this.MinIncre.Location = new System.Drawing.Point(161, 74);
            this.MinIncre.Margin = new System.Windows.Forms.Padding(4);
            this.MinIncre.Name = "MinIncre";
            this.MinIncre.Size = new System.Drawing.Size(82, 25);
            this.MinIncre.TabIndex = 6;
            this.MinIncre.Tag = "";
            this.MinIncre.MouseHover += new System.EventHandler(this.ControlEnter);
            this.MinIncre.Enter += new System.EventHandler(this.ControlEnter);
            // 
            // MaxSpeed
            // 
            this.MaxSpeed.Location = new System.Drawing.Point(128, 41);
            this.MaxSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.MaxSpeed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MaxSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxSpeed.Name = "MaxSpeed";
            this.MaxSpeed.Size = new System.Drawing.Size(115, 25);
            this.MaxSpeed.TabIndex = 4;
            this.MaxSpeed.Tag = "";
            this.MaxSpeed.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.MaxSpeed.MouseHover += new System.EventHandler(this.ControlEnter);
            this.MaxSpeed.Enter += new System.EventHandler(this.ControlEnter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 44);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Maximum Speed: ";
            // 
            // MinSpeed
            // 
            this.MinSpeed.Location = new System.Drawing.Point(128, 8);
            this.MinSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.MinSpeed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MinSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MinSpeed.Name = "MinSpeed";
            this.MinSpeed.Size = new System.Drawing.Size(115, 25);
            this.MinSpeed.TabIndex = 2;
            this.MinSpeed.Tag = "";
            this.MinSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MinSpeed.MouseHover += new System.EventHandler(this.ControlEnter);
            this.MinSpeed.Enter += new System.EventHandler(this.ControlEnter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Minimum Speed: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 76);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "Minimum Increment: ";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Background);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(253, 147);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Color";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Background
            // 
            this.Background.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Background.FormattingEnabled = true;
            this.Background.Items.AddRange(new object[] {
            "Dark",
            "Light"});
            this.Background.Location = new System.Drawing.Point(11, 30);
            this.Background.Margin = new System.Windows.Forms.Padding(4);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(231, 23);
            this.Background.TabIndex = 0;
            this.Background.Tag = "";
            this.Background.Enter += new System.EventHandler(this.ControlEnter);
            this.Background.MouseHover += new System.EventHandler(this.ControlEnter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Background color: ";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ProBarCnt);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(253, 147);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Count";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ProBarCnt
            // 
            this.ProBarCnt.Location = new System.Drawing.Point(166, 8);
            this.ProBarCnt.Margin = new System.Windows.Forms.Padding(4);
            this.ProBarCnt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ProBarCnt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ProBarCnt.Name = "ProBarCnt";
            this.ProBarCnt.Size = new System.Drawing.Size(80, 25);
            this.ProBarCnt.TabIndex = 4;
            this.ProBarCnt.Tag = "";
            this.ProBarCnt.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.ProBarCnt.MouseHover += new System.EventHandler(this.ControlEnter);
            this.ProBarCnt.Enter += new System.EventHandler(this.ControlEnter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 10);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 15);
            this.label12.TabIndex = 5;
            this.label12.Text = "Progress bar count: ";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label20);
            this.tabPage5.Controls.Add(this.Start);
            this.tabPage5.Controls.Add(this.Reset);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(253, 147);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "More";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(9, 83);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(238, 42);
            this.label20.TabIndex = 10;
            this.label20.Text = "Press any key or click mouse to exit demo view";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(6, 46);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(241, 34);
            this.Start.TabIndex = 9;
            this.Start.Text = "Start demo view";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            this.Start.Enter += new System.EventHandler(this.ControlEnter);
            this.Start.MouseHover += new System.EventHandler(this.ControlEnter);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(6, 6);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(241, 34);
            this.Reset.TabIndex = 8;
            this.Reset.Text = "Reset to default";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            this.Reset.Enter += new System.EventHandler(this.ControlEnter);
            this.Reset.MouseHover += new System.EventHandler(this.ControlEnter);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(281, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 286);
            this.label6.TabIndex = 1;
            this.label6.Text = "The size of the progress bar will be minimum (50,10) and maximum (300,40). Your s" +
    "creen resolution is (0,0)\r\n";
            this.label6.MouseHover += new System.EventHandler(this.ControlEnter);
            // 
            // ApplyChanges
            // 
            this.ApplyChanges.Enabled = false;
            this.ApplyChanges.Location = new System.Drawing.Point(9, 269);
            this.ApplyChanges.Margin = new System.Windows.Forms.Padding(4);
            this.ApplyChanges.Name = "ApplyChanges";
            this.ApplyChanges.Size = new System.Drawing.Size(177, 28);
            this.ApplyChanges.TabIndex = 2;
            this.ApplyChanges.Tag = "";
            this.ApplyChanges.Text = "Confirm and apply";
            this.ApplyChanges.UseVisualStyleBackColor = true;
            this.ApplyChanges.Click += new System.EventHandler(this.ApplyChanges_Click);
            this.ApplyChanges.Enter += new System.EventHandler(this.ControlEnter);
            this.ApplyChanges.MouseHover += new System.EventHandler(this.ControlEnter);
            // 
            // Discard
            // 
            this.Discard.Location = new System.Drawing.Point(194, 269);
            this.Discard.Margin = new System.Windows.Forms.Padding(4);
            this.Discard.Name = "Discard";
            this.Discard.Size = new System.Drawing.Size(83, 28);
            this.Discard.TabIndex = 3;
            this.Discard.Tag = "";
            this.Discard.Text = "Cancel";
            this.Discard.UseVisualStyleBackColor = true;
            this.Discard.Click += new System.EventHandler(this.button2_Click);
            this.Discard.Enter += new System.EventHandler(this.ControlEnter);
            this.Discard.MouseHover += new System.EventHandler(this.ControlEnter);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(424, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 270);
            this.panel1.TabIndex = 5;
            this.panel1.Tag = "Demo";
            this.panel1.MouseHover += new System.EventHandler(this.ControlEnter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(424, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 15);
            this.label13.TabIndex = 6;
            this.label13.Text = "Demo:";
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(16, 191);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(261, 74);
            this.label19.TabIndex = 7;
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 310);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Discard);
            this.Controls.Add(this.ApplyChanges);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinWidth)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxIncre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinIncre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinSpeed)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProBarCnt)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown MinWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown MaxWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown MinHeight;
        private System.Windows.Forms.NumericUpDown MaxHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown MinSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown MaxSpeed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Background;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ApplyChanges;
        private System.Windows.Forms.Button Discard;
        private System.Windows.Forms.NumericUpDown MinIncre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown MaxIncre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.NumericUpDown ProBarCnt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label20;
    }
}