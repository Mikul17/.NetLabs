namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            Only_active = new CheckBox();
            clearButton = new Button();
            searchButton = new Button();
            deviceTypeBox = new GroupBox();
            VR_radio = new RadioButton();
            Console_radio = new RadioButton();
            Mobile_radio = new RadioButton();
            PC_radio = new RadioButton();
            fraze_label = new Label();
            frazeBox = new TextBox();
            dateBox = new GroupBox();
            Month_radio = new RadioButton();
            Week_radio = new RadioButton();
            Yestarday_radio = new RadioButton();
            Today_radio = new RadioButton();
            givewaytype_label = new Label();
            giveawayBox = new ComboBox();
            platform_label = new Label();
            platformBox = new ComboBox();
            Deals_list = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            deviceTypeBox.SuspendLayout();
            dateBox.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.DarkGray;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(87, 96, 100);
            splitContainer1.Panel1.Controls.Add(Only_active);
            splitContainer1.Panel1.Controls.Add(clearButton);
            splitContainer1.Panel1.Controls.Add(searchButton);
            splitContainer1.Panel1.Controls.Add(deviceTypeBox);
            splitContainer1.Panel1.Controls.Add(fraze_label);
            splitContainer1.Panel1.Controls.Add(frazeBox);
            splitContainer1.Panel1.Controls.Add(dateBox);
            splitContainer1.Panel1.Controls.Add(givewaytype_label);
            splitContainer1.Panel1.Controls.Add(giveawayBox);
            splitContainer1.Panel1.Controls.Add(platform_label);
            splitContainer1.Panel1.Controls.Add(platformBox);
            splitContainer1.Panel1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(Deals_list);
            splitContainer1.Size = new Size(1134, 711);
            splitContainer1.SplitterDistance = 267;
            splitContainer1.TabIndex = 1;
            // 
            // Only_active
            // 
            Only_active.AutoSize = true;
            Only_active.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Only_active.Location = new Point(12, 425);
            Only_active.Name = "Only_active";
            Only_active.Size = new Size(139, 24);
            Only_active.TabIndex = 16;
            Only_active.TabStop = false;
            Only_active.Text = "Show only active";
            Only_active.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(12, 469);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 15;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(99, 469);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 14;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_click;
            // 
            // deviceTypeBox
            // 
            deviceTypeBox.BackColor = Color.FromArgb(87, 96, 100);
            deviceTypeBox.Controls.Add(VR_radio);
            deviceTypeBox.Controls.Add(Console_radio);
            deviceTypeBox.Controls.Add(Mobile_radio);
            deviceTypeBox.Controls.Add(PC_radio);
            deviceTypeBox.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            deviceTypeBox.Location = new Point(12, 59);
            deviceTypeBox.Name = "deviceTypeBox";
            deviceTypeBox.RightToLeft = RightToLeft.No;
            deviceTypeBox.Size = new Size(162, 124);
            deviceTypeBox.TabIndex = 12;
            deviceTypeBox.TabStop = false;
            deviceTypeBox.Text = "Device type";
            // 
            // VR_radio
            // 
            VR_radio.AutoSize = true;
            VR_radio.Location = new Point(6, 97);
            VR_radio.Name = "VR_radio";
            VR_radio.Size = new Size(39, 19);
            VR_radio.TabIndex = 1;
            VR_radio.TabStop = true;
            VR_radio.Text = "VR";
            VR_radio.UseVisualStyleBackColor = true;
            VR_radio.CheckedChanged += device_CheckedChanged;
            // 
            // Console_radio
            // 
            Console_radio.AutoSize = true;
            Console_radio.Location = new Point(6, 72);
            Console_radio.Name = "Console_radio";
            Console_radio.Size = new Size(67, 19);
            Console_radio.TabIndex = 2;
            Console_radio.TabStop = true;
            Console_radio.Text = "Console";
            Console_radio.UseVisualStyleBackColor = true;
            Console_radio.CheckedChanged += device_CheckedChanged;
            // 
            // Mobile_radio
            // 
            Mobile_radio.AutoSize = true;
            Mobile_radio.Location = new Point(6, 47);
            Mobile_radio.Name = "Mobile_radio";
            Mobile_radio.Size = new Size(62, 19);
            Mobile_radio.TabIndex = 1;
            Mobile_radio.TabStop = true;
            Mobile_radio.Text = "Mobile";
            Mobile_radio.UseVisualStyleBackColor = true;
            Mobile_radio.CheckedChanged += device_CheckedChanged;
            // 
            // PC_radio
            // 
            PC_radio.AutoSize = true;
            PC_radio.Location = new Point(6, 22);
            PC_radio.Name = "PC_radio";
            PC_radio.Size = new Size(39, 19);
            PC_radio.TabIndex = 0;
            PC_radio.TabStop = true;
            PC_radio.Text = "PC";
            PC_radio.UseVisualStyleBackColor = true;
            PC_radio.CheckedChanged += device_CheckedChanged;
            // 
            // fraze_label
            // 
            fraze_label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            fraze_label.AutoSize = true;
            fraze_label.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            fraze_label.Location = new Point(12, 12);
            fraze_label.Name = "fraze_label";
            fraze_label.Size = new Size(33, 15);
            fraze_label.TabIndex = 13;
            fraze_label.Text = "Fraze";
            fraze_label.Click += fraze_label_Click;
            // 
            // frazeBox
            // 
            frazeBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            frazeBox.BackColor = Color.LightGray;
            frazeBox.Location = new Point(12, 30);
            frazeBox.Name = "frazeBox";
            frazeBox.Size = new Size(221, 23);
            frazeBox.TabIndex = 12;
            // 
            // dateBox
            // 
            dateBox.BackColor = Color.FromArgb(87, 96, 100);
            dateBox.Controls.Add(Month_radio);
            dateBox.Controls.Add(Week_radio);
            dateBox.Controls.Add(Yestarday_radio);
            dateBox.Controls.Add(Today_radio);
            dateBox.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dateBox.Location = new Point(12, 286);
            dateBox.Name = "dateBox";
            dateBox.Size = new Size(162, 133);
            dateBox.TabIndex = 11;
            dateBox.TabStop = false;
            dateBox.Text = "Publication date";
            // 
            // Month_radio
            // 
            Month_radio.AutoSize = true;
            Month_radio.Location = new Point(6, 97);
            Month_radio.Name = "Month_radio";
            Month_radio.Size = new Size(84, 19);
            Month_radio.TabIndex = 3;
            Month_radio.TabStop = true;
            Month_radio.Text = "This month";
            Month_radio.UseVisualStyleBackColor = true;
            // 
            // Week_radio
            // 
            Week_radio.AutoSize = true;
            Week_radio.Location = new Point(6, 72);
            Week_radio.Name = "Week_radio";
            Week_radio.Size = new Size(76, 19);
            Week_radio.TabIndex = 2;
            Week_radio.TabStop = true;
            Week_radio.Text = "This week";
            Week_radio.UseVisualStyleBackColor = true;
            // 
            // Yestarday_radio
            // 
            Yestarday_radio.AutoSize = true;
            Yestarday_radio.Location = new Point(6, 47);
            Yestarday_radio.Name = "Yestarday_radio";
            Yestarday_radio.Size = new Size(75, 19);
            Yestarday_radio.TabIndex = 1;
            Yestarday_radio.TabStop = true;
            Yestarday_radio.Text = "Yestarday";
            Yestarday_radio.UseVisualStyleBackColor = true;
            Yestarday_radio.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // Today_radio
            // 
            Today_radio.AutoSize = true;
            Today_radio.Location = new Point(6, 22);
            Today_radio.Name = "Today_radio";
            Today_radio.Size = new Size(56, 19);
            Today_radio.TabIndex = 0;
            Today_radio.TabStop = true;
            Today_radio.Text = "Today";
            Today_radio.UseVisualStyleBackColor = true;
            Today_radio.CheckedChanged += device_CheckedChanged;
            // 
            // givewaytype_label
            // 
            givewaytype_label.AutoSize = true;
            givewaytype_label.Location = new Point(12, 239);
            givewaytype_label.Name = "givewaytype_label";
            givewaytype_label.Size = new Size(77, 15);
            givewaytype_label.TabIndex = 10;
            givewaytype_label.Text = "Giveway type";
            givewaytype_label.Click += givewaytype_label_Click;
            // 
            // giveawayBox
            // 
            giveawayBox.BackColor = Color.LightGray;
            giveawayBox.FormattingEnabled = true;
            giveawayBox.Location = new Point(12, 257);
            giveawayBox.Name = "giveawayBox";
            giveawayBox.Size = new Size(121, 23);
            giveawayBox.TabIndex = 9;
            giveawayBox.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // platform_label
            // 
            platform_label.AutoSize = true;
            platform_label.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            platform_label.Location = new Point(12, 195);
            platform_label.Name = "platform_label";
            platform_label.Size = new Size(52, 15);
            platform_label.TabIndex = 8;
            platform_label.Text = "Platform";
            // 
            // platformBox
            // 
            platformBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            platformBox.BackColor = Color.LightGray;
            platformBox.FormattingEnabled = true;
            platformBox.Location = new Point(12, 213);
            platformBox.Name = "platformBox";
            platformBox.Size = new Size(186, 23);
            platformBox.TabIndex = 7;
            platformBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // Deals_list
            // 
            Deals_list.AutoScroll = true;
            Deals_list.AutoSize = true;
            Deals_list.BackColor = Color.FromArgb(57, 62, 65);
            Deals_list.Dock = DockStyle.Fill;
            Deals_list.Location = new Point(0, 0);
            Deals_list.Name = "Deals_list";
            Deals_list.Size = new Size(863, 711);
            Deals_list.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1134, 711);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            deviceTypeBox.ResumeLayout(false);
            deviceTypeBox.PerformLayout();
            dateBox.ResumeLayout(false);
            dateBox.PerformLayout();
            ResumeLayout(false);
        }

        private void VR_radio_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PC_radio_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private SplitContainer splitContainer1;
        private ComboBox platformBox;
        private Label platform_label;
        private Label givewaytype_label;
        private ComboBox giveawayBox;
        private Label fraze_label;
        private TextBox frazeBox;
        private GroupBox dateBox;
        private RadioButton Week_radio;
        private RadioButton Yestarday_radio;
        private RadioButton Today_radio;
        private GroupBox deviceTypeBox;
        private Button clearButton;
        private Button searchButton;
        private RadioButton Month_radio;
        private RadioButton VR_radio;
        private RadioButton Console_radio;
        private RadioButton Mobile_radio;
        private RadioButton PC_radio;
        private FlowLayoutPanel Deals_list;
        private CheckBox Only_active;
    }
}
