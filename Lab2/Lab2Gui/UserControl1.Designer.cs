namespace Lab2Gui
{
    partial class UserControl1
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            title = new Label();
            splitContainer1 = new SplitContainer();
            instruction_text = new TextBox();
            description_text = new TextBox();
            event_button = new Button();
            platforms_list = new Label();
            devices_list = new Label();
            end_date = new Label();
            published_date = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(233, 79, 55);
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(279, 226);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // title
            // 
            title.AutoSize = true;
            title.ForeColor = Color.White;
            title.Location = new Point(14, 10);
            title.Name = "title";
            title.Size = new Size(29, 15);
            title.TabIndex = 0;
            title.Text = "Title";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.RightToLeft = RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(233, 79, 55);
            splitContainer1.Panel2.Controls.Add(instruction_text);
            splitContainer1.Panel2.Controls.Add(description_text);
            splitContainer1.Panel2.Controls.Add(event_button);
            splitContainer1.Panel2.Controls.Add(platforms_list);
            splitContainer1.Panel2.Controls.Add(devices_list);
            splitContainer1.Panel2.Controls.Add(end_date);
            splitContainer1.Panel2.Controls.Add(published_date);
            splitContainer1.Panel2.Controls.Add(title);
            splitContainer1.Size = new Size(826, 226);
            splitContainer1.SplitterDistance = 279;
            splitContainer1.TabIndex = 1;
            // 
            // instruction_text
            // 
            instruction_text.BackColor = Color.FromArgb(233, 79, 55);
            instruction_text.ForeColor = Color.White;
            instruction_text.Location = new Point(14, 95);
            instruction_text.Multiline = true;
            instruction_text.Name = "instruction_text";
            instruction_text.PlaceholderText = "Instruction how to obtain deal";
            instruction_text.ReadOnly = true;
            instruction_text.ScrollBars = ScrollBars.Vertical;
            instruction_text.Size = new Size(246, 79);
            instruction_text.TabIndex = 10;
            // 
            // description_text
            // 
            description_text.BackColor = Color.FromArgb(233, 79, 55);
            description_text.ForeColor = Color.White;
            description_text.Location = new Point(277, 29);
            description_text.Multiline = true;
            description_text.Name = "description_text";
            description_text.PlaceholderText = "Description of deal";
            description_text.ReadOnly = true;
            description_text.Size = new Size(250, 145);
            description_text.TabIndex = 9;
            // 
            // event_button
            // 
            event_button.Location = new Point(438, 180);
            event_button.Name = "event_button";
            event_button.Size = new Size(89, 32);
            event_button.TabIndex = 8;
            event_button.Text = "Redeem";
            event_button.UseVisualStyleBackColor = true;
            event_button.Click += event_button_Click;
            // 
            // platforms_list
            // 
            platforms_list.AutoSize = true;
            platforms_list.ForeColor = Color.White;
            platforms_list.Location = new Point(14, 47);
            platforms_list.Name = "platforms_list";
            platforms_list.Size = new Size(56, 15);
            platforms_list.TabIndex = 5;
            platforms_list.Text = "Platform:";
            // 
            // devices_list
            // 
            devices_list.AutoSize = true;
            devices_list.ForeColor = Color.White;
            devices_list.Location = new Point(14, 32);
            devices_list.Name = "devices_list";
            devices_list.Size = new Size(50, 15);
            devices_list.TabIndex = 4;
            devices_list.Text = "Devices:";
            // 
            // end_date
            // 
            end_date.AutoSize = true;
            end_date.ForeColor = Color.White;
            end_date.Location = new Point(14, 77);
            end_date.Name = "end_date";
            end_date.Size = new Size(53, 15);
            end_date.TabIndex = 3;
            end_date.Text = "End date";
            // 
            // published_date
            // 
            published_date.AutoSize = true;
            published_date.ForeColor = Color.White;
            published_date.Location = new Point(14, 62);
            published_date.Name = "published_date";
            published_date.Size = new Size(85, 15);
            published_date.TabIndex = 2;
            published_date.Text = "Published date";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(splitContainer1);
            Name = "UserControl1";
            Size = new Size(829, 229);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label title;
        private SplitContainer splitContainer1;
        private Label platforms_list;
        private Label devices_list;
        private Label end_date;
        private Label published_date;
        private Button event_button;
        private TextBox instruction_text;
        private TextBox description_text;
    }
}
