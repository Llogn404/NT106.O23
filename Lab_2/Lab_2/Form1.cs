namespace Lab_2
{
    public partial class Menu_Form : Form
    {
        public Menu_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task_1 task_1 = new Task_1();
            task_1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task_2 task_2 = new Task_2();
            task_2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Task_3 task_3 = new Task_3();
            task_3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Task_5 task_5 = new Task_5();
            task_5.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Task_7 task_7 = new Task_7();
            task_7.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Task_4 task_4 = new Task_4();
            task_4.Show();
        }
    }
}
