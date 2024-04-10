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
    public partial class Task_2 : Form
    {
        public Task_2()
        {
            InitializeComponent();
        }

        private void input_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            fileContent_richTextBox.Text = sr.ReadToEnd();

            string name = ofd.SafeFileName.ToString();
            textBox_fileName.Text = name;

            string url = fs.Name.ToString();
            textBox_url.Text = url;

            fs.Seek(0, SeekOrigin.Begin);
            int linecount = 0;
            while (sr.ReadLine() != null)
            {
                linecount++;
            }
            textBox_lineCount.Text = linecount.ToString();

            long size = fs.Length;
            textBox_size.Text = size.ToString() + " bytes";

            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            int wordCount = 0;
            string text = sr.ReadToEnd();
            string[] word = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            wordCount = word.Length;
            textBox_characterCount.Text = text.Length.ToString();
            textBox_wordsCount.Text = wordCount.ToString();
            sr.Close();
            fs.Close();

            
        }

    }
}
