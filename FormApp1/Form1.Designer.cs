namespace FormApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Shutdown = new System.Windows.Forms.Button();
            this.highTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hightButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.xNumberTextBox = new System.Windows.Forms.TextBox();
            this.yNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yNumber = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.AddRadioButton = new System.Windows.Forms.RadioButton();
            this.SubstractRadioButton = new System.Windows.Forms.RadioButton();
            this.MultiplyRadioButton = new System.Windows.Forms.RadioButton();
            this.DivideRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(484, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Super";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.Location = new System.Drawing.Point(736, 190);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(75, 23);
            this.RestartButton.TabIndex = 1;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(831, 190);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Shutdown
            // 
            this.Shutdown.Location = new System.Drawing.Point(530, 188);
            this.Shutdown.Name = "Shutdown";
            this.Shutdown.Size = new System.Drawing.Size(75, 23);
            this.Shutdown.TabIndex = 3;
            this.Shutdown.Text = "Shutdown";
            this.Shutdown.UseVisualStyleBackColor = true;
            this.Shutdown.Click += new System.EventHandler(this.Shutdown_Click);
            // 
            // highTextBox
            // 
            this.highTextBox.Location = new System.Drawing.Point(679, 35);
            this.highTextBox.Name = "highTextBox";
            this.highTextBox.Size = new System.Drawing.Size(175, 23);
            this.highTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(679, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter you height";
            // 
            // hightButton
            // 
            this.hightButton.Location = new System.Drawing.Point(715, 64);
            this.hightButton.Name = "hightButton";
            this.hightButton.Size = new System.Drawing.Size(96, 26);
            this.hightButton.TabIndex = 6;
            this.hightButton.Text = "Run";
            this.hightButton.UseVisualStyleBackColor = true;
            this.hightButton.Click += new System.EventHandler(this.hightButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(678, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 23);
            this.textBox1.TabIndex = 7;
            // 
            // xNumberTextBox
            // 
            this.xNumberTextBox.Location = new System.Drawing.Point(101, 111);
            this.xNumberTextBox.Name = "xNumberTextBox";
            this.xNumberTextBox.Size = new System.Drawing.Size(100, 23);
            this.xNumberTextBox.TabIndex = 8;
            // 
            // yNumberTextBox
            // 
            this.yNumberTextBox.Location = new System.Drawing.Point(101, 153);
            this.yNumberTextBox.Name = "yNumberTextBox";
            this.yNumberTextBox.Size = new System.Drawing.Size(100, 23);
            this.yNumberTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "X number";
            // 
            // yNumber
            // 
            this.yNumber.AutoSize = true;
            this.yNumber.Location = new System.Drawing.Point(101, 135);
            this.yNumber.Name = "yNumber";
            this.yNumber.Size = new System.Drawing.Size(59, 15);
            this.yNumber.TabIndex = 11;
            this.yNumber.Text = "Y number";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Document;
            this.resultTextBox.Location = new System.Drawing.Point(101, 352);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(100, 23);
            this.resultTextBox.TabIndex = 13;
            // 
            // AddRadioButton
            // 
            this.AddRadioButton.AutoSize = true;
            this.AddRadioButton.Checked = true;
            this.AddRadioButton.Location = new System.Drawing.Point(101, 192);
            this.AddRadioButton.Name = "AddRadioButton";
            this.AddRadioButton.Size = new System.Drawing.Size(47, 19);
            this.AddRadioButton.TabIndex = 14;
            this.AddRadioButton.TabStop = true;
            this.AddRadioButton.Text = "Add";
            this.AddRadioButton.UseVisualStyleBackColor = true;
            // 
            // SubstractRadioButton
            // 
            this.SubstractRadioButton.AutoSize = true;
            this.SubstractRadioButton.Location = new System.Drawing.Point(101, 217);
            this.SubstractRadioButton.Name = "SubstractRadioButton";
            this.SubstractRadioButton.Size = new System.Drawing.Size(74, 19);
            this.SubstractRadioButton.TabIndex = 15;
            this.SubstractRadioButton.Text = "Substract";
            this.SubstractRadioButton.UseVisualStyleBackColor = true;
            // 
            // MultiplyRadioButton
            // 
            this.MultiplyRadioButton.AutoSize = true;
            this.MultiplyRadioButton.Location = new System.Drawing.Point(101, 242);
            this.MultiplyRadioButton.Name = "MultiplyRadioButton";
            this.MultiplyRadioButton.Size = new System.Drawing.Size(69, 19);
            this.MultiplyRadioButton.TabIndex = 16;
            this.MultiplyRadioButton.Text = "Multiply";
            this.MultiplyRadioButton.UseVisualStyleBackColor = true;
            // 
            // DivideRadioButton
            // 
            this.DivideRadioButton.AutoSize = true;
            this.DivideRadioButton.Location = new System.Drawing.Point(101, 267);
            this.DivideRadioButton.Name = "DivideRadioButton";
            this.DivideRadioButton.Size = new System.Drawing.Size(58, 19);
            this.DivideRadioButton.TabIndex = 17;
            this.DivideRadioButton.Text = "Divide";
            this.DivideRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(912, 464);
            this.Controls.Add(this.DivideRadioButton);
            this.Controls.Add(this.MultiplyRadioButton);
            this.Controls.Add(this.SubstractRadioButton);
            this.Controls.Add(this.AddRadioButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.yNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yNumberTextBox);
            this.Controls.Add(this.xNumberTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.hightButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.highTextBox);
            this.Controls.Add(this.Shutdown);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "ALX Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button RestartButton;
        private Button ExitButton;
        private Button Shutdown;
        private TextBox highTextBox;
        private Label label1;
        private Button hightButton;
        private TextBox textBox1;
        private TextBox xNumberTextBox;
        private TextBox yNumberTextBox;
        private Label label2;
        private Label yNumber;
        private Button button2;
        private TextBox resultTextBox;
        private RadioButton AddRadioButton;
        private RadioButton SubstractRadioButton;
        private RadioButton MultiplyRadioButton;
        private RadioButton DivideRadioButton;
    }
}