namespace Lab4GUI
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
            tableLayoutPanel1 = new TableLayoutPanel();
            negativeBox = new PictureBox();
            mirrorBox = new PictureBox();
            grayScaleBox = new PictureBox();
            redToBlueBox = new PictureBox();
            transformImagesButton = new Button();
            origial = new PictureBox();
            loadImageButton = new Button();
            imageLoader = new OpenFileDialog();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)negativeBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mirrorBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grayScaleBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)redToBlueBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)origial).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(negativeBox, 0, 0);
            tableLayoutPanel1.Controls.Add(mirrorBox, 1, 0);
            tableLayoutPanel1.Controls.Add(grayScaleBox, 0, 1);
            tableLayoutPanel1.Controls.Add(redToBlueBox, 1, 1);
            tableLayoutPanel1.Location = new Point(767, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(571, 620);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // negativeBox
            // 
            negativeBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            negativeBox.Location = new Point(3, 3);
            negativeBox.Name = "negativeBox";
            negativeBox.Size = new Size(279, 304);
            negativeBox.SizeMode = PictureBoxSizeMode.StretchImage;
            negativeBox.TabIndex = 0;
            negativeBox.TabStop = false;
            // 
            // mirrorBox
            // 
            mirrorBox.Dock = DockStyle.Fill;
            mirrorBox.Location = new Point(288, 3);
            mirrorBox.Name = "mirrorBox";
            mirrorBox.Size = new Size(280, 304);
            mirrorBox.SizeMode = PictureBoxSizeMode.StretchImage;
            mirrorBox.TabIndex = 1;
            mirrorBox.TabStop = false;
            // 
            // grayScaleBox
            // 
            grayScaleBox.Dock = DockStyle.Fill;
            grayScaleBox.Location = new Point(3, 313);
            grayScaleBox.Name = "grayScaleBox";
            grayScaleBox.Size = new Size(279, 304);
            grayScaleBox.SizeMode = PictureBoxSizeMode.StretchImage;
            grayScaleBox.TabIndex = 2;
            grayScaleBox.TabStop = false;
            // 
            // redToBlueBox
            // 
            redToBlueBox.Dock = DockStyle.Fill;
            redToBlueBox.Location = new Point(288, 313);
            redToBlueBox.Name = "redToBlueBox";
            redToBlueBox.Size = new Size(280, 304);
            redToBlueBox.SizeMode = PictureBoxSizeMode.StretchImage;
            redToBlueBox.TabIndex = 3;
            redToBlueBox.TabStop = false;
            // 
            // transformImagesButton
            // 
            transformImagesButton.Enabled = false;
            transformImagesButton.Location = new Point(613, 300);
            transformImagesButton.Name = "transformImagesButton";
            transformImagesButton.Size = new Size(112, 28);
            transformImagesButton.TabIndex = 2;
            transformImagesButton.Text = "Transform image";
            transformImagesButton.UseVisualStyleBackColor = true;
            transformImagesButton.Click += transformImagesButton_Click;
            // 
            // origial
            // 
            origial.Location = new Point(36, 12);
            origial.Name = "origial";
            origial.Size = new Size(549, 620);
            origial.SizeMode = PictureBoxSizeMode.StretchImage;
            origial.TabIndex = 3;
            origial.TabStop = false;
            // 
            // loadImageButton
            // 
            loadImageButton.Location = new Point(613, 244);
            loadImageButton.Name = "loadImageButton";
            loadImageButton.Size = new Size(112, 36);
            loadImageButton.TabIndex = 1;
            loadImageButton.Text = "Load image";
            loadImageButton.UseVisualStyleBackColor = true;
            loadImageButton.Click += button1_Click;
            // 
            // imageLoader
            // 
            imageLoader.FileName = "";
            imageLoader.Filter = "Images (*.png)|*.png|Images (*.jpg) | *.jpg";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 644);
            Controls.Add(origial);
            Controls.Add(transformImagesButton);
            Controls.Add(loadImageButton);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)negativeBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)mirrorBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)grayScaleBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)redToBlueBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)origial).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button transformImagesButton;
        private PictureBox origial;
        private Button loadImageButton;
        private OpenFileDialog imageLoader;
        private PictureBox negativeBox;
        private PictureBox mirrorBox;
        private PictureBox grayScaleBox;
        private PictureBox redToBlueBox;
    }
}
