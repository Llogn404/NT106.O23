namespace Lab_2
{
    partial class Task_2
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
            input_Button = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox_fileName = new TextBox();
            textBox_size = new TextBox();
            textBox_url = new TextBox();
            textBox_lineCount = new TextBox();
            textBox_wordsCount = new TextBox();
            textBox_characterCount = new TextBox();
            buttonExit = new Button();
            fileContent_richTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // input_Button
            // 
            input_Button.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            input_Button.Location = new Point(22, 27);
            input_Button.Margin = new Padding(3, 2, 3, 2);
            input_Button.Name = "input_Button";
            input_Button.Size = new Size(305, 25);
            input_Button.TabIndex = 0;
            input_Button.Text = "Read from File";
            input_Button.UseVisualStyleBackColor = true;
            input_Button.Click += input_Button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.WindowFrame;
            label1.CausesValidation = false;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(22, 80);
            label1.Name = "label1";
            label1.Size = new Size(72, 19);
            label1.TabIndex = 1;
            label1.Text = "File Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.WindowFrame;
            label2.CausesValidation = false;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(22, 120);
            label2.Name = "label2";
            label2.Size = new Size(34, 19);
            label2.TabIndex = 2;
            label2.Text = "Size";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.WindowFrame;
            label3.CausesValidation = false;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(22, 160);
            label3.Name = "label3";
            label3.Size = new Size(39, 19);
            label3.TabIndex = 3;
            label3.Text = "URL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.WindowFrame;
            label4.CausesValidation = false;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(22, 200);
            label4.Name = "label4";
            label4.Size = new Size(76, 19);
            label4.TabIndex = 4;
            label4.Text = "Line Count";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.WindowFrame;
            label5.CausesValidation = false;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(255, 128, 0);
            label5.Location = new Point(22, 240);
            label5.Name = "label5";
            label5.Size = new Size(91, 19);
            label5.TabIndex = 5;
            label5.Text = "Words Count";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.WindowFrame;
            label6.CausesValidation = false;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(255, 128, 0);
            label6.Location = new Point(22, 280);
            label6.Name = "label6";
            label6.Size = new Size(110, 19);
            label6.TabIndex = 6;
            label6.Text = "Character Count";
            // 
            // textBox_fileName
            // 
            textBox_fileName.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_fileName.Location = new Point(148, 80);
            textBox_fileName.Name = "textBox_fileName";
            textBox_fileName.Size = new Size(179, 22);
            textBox_fileName.TabIndex = 7;
            // 
            // textBox_size
            // 
            textBox_size.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_size.Location = new Point(148, 120);
            textBox_size.Name = "textBox_size";
            textBox_size.Size = new Size(179, 22);
            textBox_size.TabIndex = 8;
            // 
            // textBox_url
            // 
            textBox_url.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_url.Location = new Point(148, 160);
            textBox_url.Name = "textBox_url";
            textBox_url.Size = new Size(179, 22);
            textBox_url.TabIndex = 9;
            // 
            // textBox_lineCount
            // 
            textBox_lineCount.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_lineCount.Location = new Point(148, 200);
            textBox_lineCount.Name = "textBox_lineCount";
            textBox_lineCount.Size = new Size(179, 22);
            textBox_lineCount.TabIndex = 10;
            // 
            // textBox_wordsCount
            // 
            textBox_wordsCount.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_wordsCount.Location = new Point(148, 240);
            textBox_wordsCount.Name = "textBox_wordsCount";
            textBox_wordsCount.Size = new Size(179, 22);
            textBox_wordsCount.TabIndex = 11;
            // 
            // textBox_characterCount
            // 
            textBox_characterCount.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_characterCount.Location = new Point(148, 280);
            textBox_characterCount.Name = "textBox_characterCount";
            textBox_characterCount.Size = new Size(179, 22);
            textBox_characterCount.TabIndex = 12;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.YellowGreen;
            buttonExit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExit.ForeColor = Color.Red;
            buttonExit.Location = new Point(22, 330);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(305, 37);
            buttonExit.TabIndex = 13;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = false;
            // 
            // fileContent_richTextBox
            // 
            fileContent_richTextBox.BackColor = SystemColors.ScrollBar;
            fileContent_richTextBox.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fileContent_richTextBox.Location = new Point(343, 27);
            fileContent_richTextBox.Name = "fileContent_richTextBox";
            fileContent_richTextBox.Size = new Size(289, 338);
            fileContent_richTextBox.TabIndex = 14;
            fileContent_richTextBox.Text = "";
            // 
            // Task_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(649, 400);
            Controls.Add(fileContent_richTextBox);
            Controls.Add(buttonExit);
            Controls.Add(textBox_characterCount);
            Controls.Add(textBox_wordsCount);
            Controls.Add(textBox_lineCount);
            Controls.Add(textBox_url);
            Controls.Add(textBox_size);
            Controls.Add(textBox_fileName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(input_Button);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Task_2";
            Text = "Task_2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button input_Button;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox_fileName;
        private TextBox textBox_size;
        private TextBox textBox_url;
        private TextBox textBox_lineCount;
        private TextBox textBox_wordsCount;
        private TextBox textBox_characterCount;
        private Button buttonExit;
        private RichTextBox fileContent_richTextBox;
    }
}