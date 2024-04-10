using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab_2.Task_4;

namespace Lab_2
{
    public partial class Task_4 : Form
    {
        public Task_4()
        {
            InitializeComponent();
        }

        public class Student
        {
            public string Name { get; set; }
            public float MSSV { get; set; }
            public string Phone { get; set; }
            public float Course1 { get; set; }
            public float Course2 { get; set; }
            public float Course3 { get; set; }
            public double Average()
            {
                return Math.Round((Course1 + Course2 + Course3) / 3);
            }

            public Student() { }

            public override string ToString()
            {
                string result = string.Empty;
                result = Name + "\n"
                    + MSSV.ToString() + "\n"
                    + Phone + "\n"
                    + Course1.ToString() + "\n"
                    + Course2.ToString() + "\n"
                    + Course3.ToString() + "\n"
                    + Average().ToString();
                return result;
            }
        }
        List<Student> dsStudent = new List<Student>();
        private bool IsEmptyTextBox()
        {
            if (string.IsNullOrEmpty(textBox_WriteName.Text) ||
               string.IsNullOrEmpty(textBox_WriteID.Text) ||
               string.IsNullOrEmpty(textBox_WritePhone.Text) ||
               string.IsNullOrEmpty(textBox_WriteC1.Text) ||
               string.IsNullOrEmpty(textBox_WriteC2.Text) ||
               string.IsNullOrEmpty(textBox_WriteC3.Text))
            {
                return true;
            }
            return false;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (IsEmptyTextBox())
            {
                MessageBox.Show("Hãy nhập đầy đủ");
                return;
            }
            Student sv = new Student();
            sv.Name = textBox_WriteName.Text;
            int ID;
            if (textBox_WriteID.Text.Length < 8 || int.TryParse(textBox_WriteID.Text, out ID) == false)
            {
                MessageBox.Show("Sai dinh dang MSSV");
                return;
            }
            sv.MSSV = ID;
            if (textBox_WritePhone.Text[0] != '0' || textBox_WritePhone.Text.Length != 10)
            {
                MessageBox.Show("Sai dinh dang so dien thoai");
            }
            sv.Phone = textBox_WritePhone.Text;
            float c1, c2, c3;
            if (!(float.TryParse(textBox_WriteC1.Text, out c1) && float.TryParse(textBox_WriteC2.Text, out c2) && float.TryParse(textBox_WriteC3.Text, out c3)))
            {
                MessageBox.Show("Sai dinh dang diem");
                return;
            }
            sv.Course1 = c1;
            sv.Course2 = c2;
            sv.Course3 = c3;
           
            dsStudent.Add(sv);
            richTextBox1.Clear();
            foreach (Student student in dsStudent)
            {
                richTextBox1.Text += student.ToString() + "\n**************************\n";

            }
            textBox_WriteName.Text = string.Empty;
            textBox_WriteID.Text = string.Empty;
            textBox_WritePhone.Text = string.Empty;
            textBox_WriteC1.Text = string.Empty;
            textBox_WriteC2.Text = string.Empty;
            textBox_WriteC3.Text = string.Empty;

        }

        static void SerializeToJsonFile(string filePath, List<Student> students)
        {
            try
            {
                var options = new JsonSerializerOptions()
                {
                    IncludeFields = true,
                };
                string json = JsonSerializer.Serialize(students, options);
                File.WriteAllText(filePath, json);
                MessageBox.Show($"Successfully writen to {filePath} ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void btn_WriteToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName + ".json";
                SerializeToJsonFile(filePath, dsStudent);
            }
        }

        private List<Student> DeserializeFromFileJson(string filePath)
        {
            try
            {
                string json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<Student>>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                return default;
            }
        }
        private void showSinhVien(Student student)
        {
            if (student == null)
            {
                MessageBox.Show("Sinh vien khong ton tai");
                return;
            }
            textBox_ReadName.Text = student.Name;
            textBox_ReadPhone.Text = student.Phone;
            textBox_ReadId.Text = student.MSSV.ToString();
            textBox_ReadC1.Text = student.Course1.ToString();
            textBox_Read_C2.Text = student.Course2.ToString();
            textBox_ReadC3.Text = student.Course3.ToString();
            textBox_Average.Text = student.Average().ToString();
        }
        int page = 0;

        private void btn_ReadFile_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                label_STT.Text = (page + 1).ToString();
                string filePath = openFileDialog.FileName;
                dsStudent = DeserializeFromFileJson(filePath);
                if (dsStudent == null || dsStudent.Count == 0)
                {
                    MessageBox.Show("Danh sách rỗng");
                }
                showSinhVien(dsStudent[0]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (page > 0)
            {
                page--;
                label_STT.Text = (page + 1).ToString();
                showSinhVien(dsStudent[(int)page]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (page < dsStudent.Count - 1)
            {
                page++;
                label_STT.Text = (page + 1).ToString();
                showSinhVien(dsStudent[((int)page)]);
            }
        }
    }
}
