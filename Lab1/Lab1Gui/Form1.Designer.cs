namespace Lab1Gui
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
            RunButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ItemsNum = new TextBox();
            SeedVal = new TextBox();
            CapacityVal = new TextBox();
            Display = new TextBox();
            ResultBox = new TextBox();
            label4 = new Label();
            Instance = new Label();
            SuspendLayout();
            // 
            // RunButton
            // 
            RunButton.Location = new Point(15, 186);
            RunButton.Name = "RunButton";
            RunButton.Size = new Size(75, 23);
            RunButton.TabIndex = 0;
            RunButton.Text = "Run";
            RunButton.UseVisualStyleBackColor = true;
            RunButton.Click += RunButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 1;
            label1.Text = "Number of items";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 69);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 2;
            label2.Text = "Seed";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 127);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 3;
            label3.Text = "Capacity";
            // 
            // ItemsNum
            // 
            ItemsNum.Location = new Point(15, 36);
            ItemsNum.Name = "ItemsNum";
            ItemsNum.Size = new Size(100, 23);
            ItemsNum.TabIndex = 4;
            // 
            // SeedVal
            // 
            SeedVal.Location = new Point(15, 87);
            SeedVal.Name = "SeedVal";
            SeedVal.Size = new Size(100, 23);
            SeedVal.TabIndex = 5;
            // 
            // CapacityVal
            // 
            CapacityVal.Location = new Point(15, 145);
            CapacityVal.Name = "CapacityVal";
            CapacityVal.Size = new Size(100, 23);
            CapacityVal.TabIndex = 6;
            // 
            // Display
            // 
            Display.Location = new Point(421, 36);
            Display.Multiline = true;
            Display.Name = "Display";
            Display.ReadOnly = true;
            Display.ScrollBars = ScrollBars.Vertical;
            Display.Size = new Size(281, 382);
            Display.TabIndex = 7;
            // 
            // ResultBox
            // 
            ResultBox.Location = new Point(12, 242);
            ResultBox.Multiline = true;
            ResultBox.Name = "ResultBox";
            ResultBox.ReadOnly = true;
            ResultBox.ScrollBars = ScrollBars.Vertical;
            ResultBox.Size = new Size(319, 196);
            ResultBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 224);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 9;
            label4.Text = "Results";
            // 
            // Instance
            // 
            Instance.AutoSize = true;
            Instance.Location = new Point(421, 18);
            Instance.Name = "Instance";
            Instance.Size = new Size(51, 15);
            Instance.TabIndex = 10;
            Instance.Text = "Instance";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 450);
            Controls.Add(Instance);
            Controls.Add(label4);
            Controls.Add(ResultBox);
            Controls.Add(Display);
            Controls.Add(CapacityVal);
            Controls.Add(SeedVal);
            Controls.Add(ItemsNum);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RunButton);
            Name = "Form1";
            Text = "Knapsack Problem Solver";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RunButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox ItemsNum;
        private TextBox SeedVal;
        private TextBox CapacityVal;
        private TextBox Display;
        private TextBox ResultBox;
        private Label label4;
        private Label Instance;
    }
}
