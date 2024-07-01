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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentRecordAutomation
{
    public partial class LecturerDetails : Form
    {
        public LecturerDetails()
        {
            InitializeComponent();
        }

        private void LecturerDetails_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'studentRecordAutomationDataSet.TBLStudent' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLStudentTableAdapter.Fill(this.studentRecordAutomationDataSet.TBLStudent);

        }

        SqlConnection sqlConnection =
            new SqlConnection(@"Data Source=DESKTOP-H9055HU\SQLEXPRESS;Initial Catalog=StudentRecordAutomation;Integrated Security=True");

        private void BtnSave_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            SqlCommand sqlCommand = 
                new SqlCommand("INSERT INTO  TBLStudent (St_Number, St_Name, St_Surname) VALUES (@P1, @P2, @P3)", sqlConnection);
            
            sqlCommand.Parameters.AddWithValue("@P1", mskTxtBoxNumber.Text);
            sqlCommand.Parameters.AddWithValue("@P2", TxtBoxName.Text);
            sqlCommand.Parameters.AddWithValue("@P3", TxtBoxSurname.Text);
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            MessageBox.Show("Student added into the system.");

            this.tBLStudentTableAdapter.Fill(this.studentRecordAutomationDataSet.TBLStudent);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int choose = dataGridView1.SelectedCells[0].RowIndex;
            
            mskTxtBoxNumber.Text = dataGridView1.Rows[choose].Cells[1].Value.ToString();
            TxtBoxName.Text = dataGridView1.Rows[choose].Cells[2].Value.ToString();
            TxtBoxSurname.Text = dataGridView1.Rows[choose].Cells[3].Value.ToString();
            TxtBoxMidterm.Text = dataGridView1.Rows[choose].Cells[4].Value.ToString();
            TxtBoxFinal.Text = dataGridView1.Rows[choose].Cells[5].Value.ToString();
            lblAverageNew.Text = dataGridView1.Rows[choose].Cells[6].Value.ToString();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            double average, midterm, final;

            string status;

            midterm = Convert.ToDouble(TxtBoxMidterm.Text);
            final = Convert.ToDouble(TxtBoxFinal.Text);

            average = ((midterm * 4) + (final * 6)) / 10;

            lblAverageNew.Text = average.ToString();

            if(average >= 50)
            {
                status = "Passed";
            }
            else
            {
                status = "Failed";
            }
           
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("UPDATE TBLStudent SET St_Midterm = @P1, St_Final = @P2, Average = @P3, Status = @P4 WHERE St_Number = @P5", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@P1", TxtBoxMidterm.Text);
            sqlCommand.Parameters.AddWithValue("@P2", TxtBoxFinal.Text);
            sqlCommand.Parameters.AddWithValue("@P3", decimal.Parse(lblAverageNew.Text));
            sqlCommand.Parameters.AddWithValue("@P4", status);
            sqlCommand.Parameters.AddWithValue("@P5", mskTxtBoxNumber.Text);

            sqlCommand.ExecuteNonQuery();
            
            sqlConnection.Close();

            MessageBox.Show("Student grades updated.");

            this.tBLStudentTableAdapter.Fill(this.studentRecordAutomationDataSet.TBLStudent);
        }
       

        private void BtnShow_Click(object sender, EventArgs e)
        {             
            decimal sum = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value);
            }
            
            decimal average = sum / (dataGridView1.Rows.Count - 1);

            LblAverage.Text = average.ToString();

            
            int pass = 0;
            int fail = 0;

            for (int i = 0; i < (dataGridView1.Rows.Count - 1); i++)
            {
                if (dataGridView1.Rows[i].Cells[7].Value.ToString() == "Passed") 
                   pass++;
                else
                    fail++;
            } 

            LblPassed.Text = pass.ToString();
            LblFailed.Text = fail.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccessScreen accessScreen = new AccessScreen();
            accessScreen.Show();
            this.Hide();
        }
    }
}