namespace StudentRecordAutomation
{
    partial class LecturerDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtBoxSurname = new System.Windows.Forms.TextBox();
            this.TxtBoxName = new System.Windows.Forms.TextBox();
            this.mskTxtBoxNumber = new System.Windows.Forms.MaskedTextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtBoxFinal = new System.Windows.Forms.TextBox();
            this.TxtBoxMidterm = new System.Windows.Forms.TextBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stMidtermDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentRecordAutomationDataSet = new StudentRecordAutomation.StudentRecordAutomationDataSet();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnShow = new System.Windows.Forms.Button();
            this.LblFailed = new System.Windows.Forms.Label();
            this.LblPassed = new System.Windows.Forms.Label();
            this.LblAverage = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tBLStudentTableAdapter = new StudentRecordAutomation.StudentRecordAutomationDataSetTableAdapters.TBLStudentTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAverageNew = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRecordAutomationDataSet)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtBoxSurname);
            this.groupBox1.Controls.Add(this.TxtBoxName);
            this.groupBox1.Controls.Add(this.mskTxtBoxNumber);
            this.groupBox1.Controls.Add(this.BtnSave);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Student";
            // 
            // TxtBoxSurname
            // 
            this.TxtBoxSurname.Location = new System.Drawing.Point(156, 120);
            this.TxtBoxSurname.Name = "TxtBoxSurname";
            this.TxtBoxSurname.Size = new System.Drawing.Size(221, 28);
            this.TxtBoxSurname.TabIndex = 6;
            this.TxtBoxSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.Location = new System.Drawing.Point(156, 76);
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.Size = new System.Drawing.Size(221, 28);
            this.TxtBoxName.TabIndex = 5;
            this.TxtBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mskTxtBoxNumber
            // 
            this.mskTxtBoxNumber.Location = new System.Drawing.Point(156, 164);
            this.mskTxtBoxNumber.Mask = "0000";
            this.mskTxtBoxNumber.Name = "mskTxtBoxNumber";
            this.mskTxtBoxNumber.Size = new System.Drawing.Size(221, 28);
            this.mskTxtBoxNumber.TabIndex = 4;
            this.mskTxtBoxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskTxtBoxNumber.ValidatingType = typeof(int);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.LightGray;
            this.BtnSave.Location = new System.Drawing.Point(186, 221);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(141, 45);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "SAVE";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(33, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(43, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(61, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAverageNew);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TxtBoxFinal);
            this.groupBox2.Controls.Add(this.TxtBoxMidterm);
            this.groupBox2.Controls.Add(this.BtnUpdate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(474, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 286);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exam Grades";
            // 
            // TxtBoxFinal
            // 
            this.TxtBoxFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBoxFinal.Location = new System.Drawing.Point(127, 109);
            this.TxtBoxFinal.Name = "TxtBoxFinal";
            this.TxtBoxFinal.Size = new System.Drawing.Size(147, 30);
            this.TxtBoxFinal.TabIndex = 4;
            this.TxtBoxFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxMidterm
            // 
            this.TxtBoxMidterm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBoxMidterm.Location = new System.Drawing.Point(127, 53);
            this.TxtBoxMidterm.Name = "TxtBoxMidterm";
            this.TxtBoxMidterm.Size = new System.Drawing.Size(147, 30);
            this.TxtBoxMidterm.TabIndex = 3;
            this.TxtBoxMidterm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.LightGray;
            this.BtnUpdate.Location = new System.Drawing.Point(127, 221);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(147, 45);
            this.BtnUpdate.TabIndex = 2;
            this.BtnUpdate.Text = "UPDATE";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(62, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Final:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Midterm:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(12, 314);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1068, 353);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Students";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stIDDataGridViewTextBoxColumn,
            this.stNumberDataGridViewTextBoxColumn,
            this.stNameDataGridViewTextBoxColumn,
            this.stSurnameDataGridViewTextBoxColumn,
            this.stMidtermDataGridViewTextBoxColumn,
            this.stFinalDataGridViewTextBoxColumn,
            this.averageDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLStudentBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1056, 325);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // stIDDataGridViewTextBoxColumn
            // 
            this.stIDDataGridViewTextBoxColumn.DataPropertyName = "St_ID";
            this.stIDDataGridViewTextBoxColumn.HeaderText = "St_ID";
            this.stIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stIDDataGridViewTextBoxColumn.Name = "stIDDataGridViewTextBoxColumn";
            this.stIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stNumberDataGridViewTextBoxColumn
            // 
            this.stNumberDataGridViewTextBoxColumn.DataPropertyName = "St_Number";
            this.stNumberDataGridViewTextBoxColumn.HeaderText = "St_Number";
            this.stNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stNumberDataGridViewTextBoxColumn.Name = "stNumberDataGridViewTextBoxColumn";
            // 
            // stNameDataGridViewTextBoxColumn
            // 
            this.stNameDataGridViewTextBoxColumn.DataPropertyName = "St_Name";
            this.stNameDataGridViewTextBoxColumn.HeaderText = "St_Name";
            this.stNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stNameDataGridViewTextBoxColumn.Name = "stNameDataGridViewTextBoxColumn";
            // 
            // stSurnameDataGridViewTextBoxColumn
            // 
            this.stSurnameDataGridViewTextBoxColumn.DataPropertyName = "St_Surname";
            this.stSurnameDataGridViewTextBoxColumn.HeaderText = "St_Surname";
            this.stSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stSurnameDataGridViewTextBoxColumn.Name = "stSurnameDataGridViewTextBoxColumn";
            // 
            // stMidtermDataGridViewTextBoxColumn
            // 
            this.stMidtermDataGridViewTextBoxColumn.DataPropertyName = "St_Midterm";
            this.stMidtermDataGridViewTextBoxColumn.HeaderText = "St_Midterm";
            this.stMidtermDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stMidtermDataGridViewTextBoxColumn.Name = "stMidtermDataGridViewTextBoxColumn";
            // 
            // stFinalDataGridViewTextBoxColumn
            // 
            this.stFinalDataGridViewTextBoxColumn.DataPropertyName = "St_Final";
            this.stFinalDataGridViewTextBoxColumn.HeaderText = "St_Final";
            this.stFinalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stFinalDataGridViewTextBoxColumn.Name = "stFinalDataGridViewTextBoxColumn";
            // 
            // averageDataGridViewTextBoxColumn
            // 
            this.averageDataGridViewTextBoxColumn.DataPropertyName = "Average";
            this.averageDataGridViewTextBoxColumn.HeaderText = "Average";
            this.averageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.averageDataGridViewTextBoxColumn.Name = "averageDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // tBLStudentBindingSource
            // 
            this.tBLStudentBindingSource.DataMember = "TBLStudent";
            this.tBLStudentBindingSource.DataSource = this.studentRecordAutomationDataSet;
            // 
            // studentRecordAutomationDataSet
            // 
            this.studentRecordAutomationDataSet.DataSetName = "StudentRecordAutomationDataSet";
            this.studentRecordAutomationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnShow);
            this.groupBox4.Controls.Add(this.LblFailed);
            this.groupBox4.Controls.Add(this.LblPassed);
            this.groupBox4.Controls.Add(this.LblAverage);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(823, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(251, 286);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Class Status";
            // 
            // BtnShow
            // 
            this.BtnShow.BackColor = System.Drawing.Color.LightGray;
            this.BtnShow.Location = new System.Drawing.Point(65, 211);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(126, 43);
            this.BtnShow.TabIndex = 6;
            this.BtnShow.Text = "SHOW";
            this.BtnShow.UseVisualStyleBackColor = false;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // LblFailed
            // 
            this.LblFailed.AutoSize = true;
            this.LblFailed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblFailed.Location = new System.Drawing.Point(157, 156);
            this.LblFailed.Name = "LblFailed";
            this.LblFailed.Size = new System.Drawing.Size(36, 25);
            this.LblFailed.TabIndex = 5;
            this.LblFailed.Text = "00";
            // 
            // LblPassed
            // 
            this.LblPassed.AutoSize = true;
            this.LblPassed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPassed.Location = new System.Drawing.Point(157, 107);
            this.LblPassed.Name = "LblPassed";
            this.LblPassed.Size = new System.Drawing.Size(36, 25);
            this.LblPassed.TabIndex = 4;
            this.LblPassed.Text = "00";
            // 
            // LblAverage
            // 
            this.LblAverage.AutoSize = true;
            this.LblAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAverage.Location = new System.Drawing.Point(157, 58);
            this.LblAverage.Name = "LblAverage";
            this.LblAverage.Size = new System.Drawing.Size(36, 25);
            this.LblAverage.TabIndex = 3;
            this.LblAverage.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(60, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Failed:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(47, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Passed:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(38, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Average:";
            // 
            // tBLStudentTableAdapter
            // 
            this.tBLStudentTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(28, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Average:";
            // 
            // lblAverageNew
            // 
            this.lblAverageNew.AutoSize = true;
            this.lblAverageNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAverageNew.Location = new System.Drawing.Point(173, 164);
            this.lblAverageNew.Name = "lblAverageNew";
            this.lblAverageNew.Size = new System.Drawing.Size(36, 25);
            this.lblAverageNew.TabIndex = 8;
            this.lblAverageNew.Text = "00";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.BackgroundImage = global::StudentRecordAutomation.Properties.Resources.Dryicons_Aesthetica_2_Back_48;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(474, 673);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 62);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LecturerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1092, 747);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LecturerDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LecturerDetails";
            this.Load += new System.EventHandler(this.LecturerDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRecordAutomationDataSet)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.MaskedTextBox mskTxtBoxNumber;
        private System.Windows.Forms.TextBox TxtBoxSurname;
        private System.Windows.Forms.TextBox TxtBoxName;
        private System.Windows.Forms.TextBox TxtBoxFinal;
        private System.Windows.Forms.TextBox TxtBoxMidterm;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private StudentRecordAutomationDataSet studentRecordAutomationDataSet;
        private System.Windows.Forms.BindingSource tBLStudentBindingSource;
        private StudentRecordAutomationDataSetTableAdapters.TBLStudentTableAdapter tBLStudentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stMidtermDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stFinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn averageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label LblFailed;
        private System.Windows.Forms.Label LblPassed;
        private System.Windows.Forms.Label LblAverage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.Label lblAverageNew;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}