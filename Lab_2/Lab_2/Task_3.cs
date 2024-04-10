using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Task_3 : Form
    {
        public Task_3()
        {
            InitializeComponent();
        }


        private void btn_ReadFile_Click(object sender, EventArgs e)
        {
            rtb_ReadInput.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text File|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                rtb_ReadInput.Text = sr.ReadToEnd();
            }
        }

        private void btn_ComputeAndWrite_Click(object sender, EventArgs e)
        {

            string[] lines = rtb_ReadInput.Lines;
            StringBuilder resultText = new StringBuilder();
            foreach (string line in lines)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    int result = 0;
                    char operation = '+';
                    int operand = 0;
                    foreach (char c in line)
                    {
                        if (char.IsDigit(c))
                        {
                            operand = operand * 10 + (c - '0');
                        }
                        else if (c == '+' || c == '-')
                        {
                            if (operation == '+')
                                result += operand;
                            else if (operation == '-')
                                result -= operand;
                            operation = c;
                            operand = 0;
                        }
                    }
                    if (operation == '+')
                        result += operand;
                    else if (operation == '-')
                        result -= operand;
                    resultText.AppendLine(line + " = " + result);
                }
            }
            rtb_ReadInput.Clear();
            rtb_ReadInput.AppendText(resultText.ToString());

        }

        private void btn_WriteToFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    using (StreamWriter streamWriter = new StreamWriter(fileStream))
                    {
                        string input = rtb_ReadInput.Text;

                        streamWriter.WriteLine(input);
                    }
                }
                MessageBox.Show("Text successfully written to file.");
            }
        }
    }
}