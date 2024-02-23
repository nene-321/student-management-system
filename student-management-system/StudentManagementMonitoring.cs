using STUDENT_MANAGEMENT_SYSTEM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_management_system
{
    public partial class StudentManagementMonitoring : Form
    {
        public StudentManagementMonitoring()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentManagementGrades studentManagementGrades = new StudentManagementGrades();
            studentManagementGrades.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentManagementAttendance studentManagementAttendance = new StudentManagementAttendance();
            studentManagementAttendance.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentManagementMonitoring studentManagementMonitoring = new StudentManagementMonitoring();
            studentManagementMonitoring.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentManagementPayment studentManagementPayment = new StudentManagementPayment();
            studentManagementPayment.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            SystemMenu systemMenu = new SystemMenu();
            systemMenu.Show();
        }
    }
}
