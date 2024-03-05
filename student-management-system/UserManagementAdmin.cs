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
    public partial class UserManagementAdmin : Form
    {
        public UserManagementAdmin()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void UserManagement_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SystemMenu systemMenu = new SystemMenu();
            systemMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
