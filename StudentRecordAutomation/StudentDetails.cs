using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentRecordAutomation
{
    public partial class StudentDetails : Form
    {
        public StudentDetails()
        {
            InitializeComponent();
        }
        
        public string number;

        SqlConnection sqlConnection =
            new SqlConnection(@"Data Source=DESKTOP-H9055HU\SQLEXPRESS;Initial Catalog=StudentRecordAutomation;Integrated Security=True");

        private void StudentDetails_Load(object sender, EventArgs e)
        {
            label14.Text = number;
            
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM TBLStudent WHERE St_Number = @p1", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@p1", number);

            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                label10.Text = reader[2].ToString() + " " + reader[3].ToString();
                label7.Text = reader[4].ToString();
                label11.Text = reader[5].ToString();
                label8.Text = reader[6].ToString();
                LblStatus.Text = reader[7].ToString();  
            }

            sqlConnection.Close();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            AccessScreen accessScreen = new AccessScreen();
            accessScreen.Show();
            this.Hide();
        }
    }
}
