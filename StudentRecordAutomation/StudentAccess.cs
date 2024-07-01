using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRecordAutomation
{
    public partial class StudentAccess : Form
    {
        public StudentAccess()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentDetails studentDetails = new StudentDetails();
            studentDetails.number = maskedTextBox1.Text;
            studentDetails.Show();
            this.Hide();
        }
    }
}