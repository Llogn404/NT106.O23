namespace Lab_2
{
    partial class Task_3
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
            rtb_ReadInput = new RichTextBox();
            btn_ReadFile = new Button();
            btn_ComputeAndWrite = new Button();
            btn_WriteToFile = new Button();
            SuspendLayout();
            // 
            // rtb_ReadInput
            // 
            rtb_ReadInput.Location = new Point(401, 12);
            rtb_ReadInput.Name = "rtb_ReadInput";
            rtb_ReadInput.Size = new Size(483, 283);
            rtb_ReadInput.TabIndex = 1;
            rtb_ReadInput.Text = "";
            // 
            // btn_ReadFile
            // 
            btn_ReadFile.BackColor = Color.Gainsboro;
            btn_ReadFile.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ReadFile.Location = new Point(152, 64);
            btn_ReadFile.Name = "btn_ReadFile";
            btn_ReadFile.Size = new Size(132, 51);
            btn_ReadFile.TabIndex = 2;
            btn_ReadFile.Text = "Read file";
            btn_ReadFile.UseVisualStyleBackColor = false;
            btn_ReadFile.Click += btn_ReadFile_Click;
            // 
            // btn_ComputeAndWrite
            // 
            btn_ComputeAndWrite.BackColor = Color.Gainsboro;
            btn_ComputeAndWrite.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ComputeAndWrite.Location = new Point(152, 167);
            btn_ComputeAndWrite.Name = "btn_ComputeAndWrite";
            btn_ComputeAndWrite.Size = new Size(132, 47);
            btn_ComputeAndWrite.TabIndex = 3;
            btn_ComputeAndWrite.Text = "Compute";
            btn_ComputeAndWrite.UseVisualStyleBackColor = false;
            btn_ComputeAndWrite.Click += btn_ComputeAndWrite_Click;
            // 
            // btn_WriteToFile
            // 
            btn_WriteToFile.BackColor = Color.Gainsboro;
            btn_WriteToFile.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_WriteToFile.Location = new Point(116, 263);
            btn_WriteToFile.Name = "btn_WriteToFile";
            btn_WriteToFile.Size = new Size(197, 59);
            btn_WriteToFile.TabIndex = 4;
            btn_WriteToFile.Text = "Write to file output";
            btn_WriteToFile.UseVisualStyleBackColor = false;
            btn_WriteToFile.Click += btn_WriteToFile_Click;
            // 
            // Task_3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 402);
            Controls.Add(btn_WriteToFile);
            Controls.Add(btn_ComputeAndWrite);
            Controls.Add(btn_ReadFile);
            Controls.Add(rtb_ReadInput);
            Name = "Task_3";
            Text = "Task_3";
            ResumeLayout(false);
        }

        #endregion
        private RichTextBox rtb_ReadInput;
        private Button btn_ReadFile;
        private Button btn_ComputeAndWrite;
        private Button btn_WriteToFile;
    }
}