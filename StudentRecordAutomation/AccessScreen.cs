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
    public partial class AccessScreen : Form
    {
        public AccessScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LecturerDetails lecturerDetails = new LecturerDetails();
            lecturerDetails.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentAccess studentAccess2 = new StudentAccess();
            studentAccess2.Show();
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
