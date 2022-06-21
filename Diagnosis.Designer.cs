
namespace Hospital_Management_System___HIT_Clinic
{
    partial class Diagnosis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diagnosis));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DiagnosisID = new System.Windows.Forms.TextBox();
            this.PatientIdCB = new System.Windows.Forms.ComboBox();
            this.PatientNameTB = new System.Windows.Forms.TextBox();
            this.SymptomsTB = new System.Windows.Forms.TextBox();
            this.DiagnosisTB = new System.Windows.Forms.TextBox();
            this.MedicationTB = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.DiagnosisLabel = new System.Windows.Forms.Label();
            this.MedicationLabel = new System.Windows.Forms.Label();
            this.SymptomsLabel = new System.Windows.Forms.Label();
            this.PatientLabel = new System.Windows.Forms.Label();
            this.DiagnosisGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 87);
            this.panel1.TabIndex = 2;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Close.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Close.Location = new System.Drawing.Point(951, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(52, 40);
            this.Close.TabIndex = 25;
            this.Close.Text = "x";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(370, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "DIAGNOSIS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(370, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "HIT CLINIC";
            // 
            // DiagnosisID
            // 
            this.DiagnosisID.BackColor = System.Drawing.Color.DarkGray;
            this.DiagnosisID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiagnosisID.Location = new System.Drawing.Point(52, 132);
            this.DiagnosisID.Multiline = true;
            this.DiagnosisID.Name = "DiagnosisID";
            this.DiagnosisID.Size = new System.Drawing.Size(135, 23);
            this.DiagnosisID.TabIndex = 3;
            this.DiagnosisID.Text = "Diagnosis_ID";
            // 
            // PatientIdCB
            // 
            this.PatientIdCB.BackColor = System.Drawing.Color.DarkGray;
            this.PatientIdCB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PatientIdCB.FormattingEnabled = true;
            this.PatientIdCB.Location = new System.Drawing.Point(52, 161);
            this.PatientIdCB.Name = "PatientIdCB";
            this.PatientIdCB.Size = new System.Drawing.Size(135, 23);
            this.PatientIdCB.TabIndex = 8;
            this.PatientIdCB.Text = "Patient_ID";
            this.PatientIdCB.SelectedIndexChanged += new System.EventHandler(this.PatientIdTB_SelectedIndexChanged);
            this.PatientIdCB.SelectionChangeCommitted += new System.EventHandler(this.PatientIdCB_SelectionChangeCommitted);
            // 
            // PatientNameTB
            // 
            this.PatientNameTB.BackColor = System.Drawing.Color.DarkGray;
            this.PatientNameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PatientNameTB.Enabled = false;
            this.PatientNameTB.Location = new System.Drawing.Point(52, 190);
            this.PatientNameTB.Multiline = true;
            this.PatientNameTB.Name = "PatientNameTB";
            this.PatientNameTB.Size = new System.Drawing.Size(135, 23);
            this.PatientNameTB.TabIndex = 9;
            this.PatientNameTB.Text = "Patient_Name";
            // 
            // SymptomsTB
            // 
            this.SymptomsTB.BackColor = System.Drawing.Color.DarkGray;
            this.SymptomsTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SymptomsTB.Location = new System.Drawing.Point(194, 132);
            this.SymptomsTB.Multiline = true;
            this.SymptomsTB.Name = "SymptomsTB";
            this.SymptomsTB.Size = new System.Drawing.Size(135, 23);
            this.SymptomsTB.TabIndex = 10;
            this.SymptomsTB.Text = "Symptoms";
            // 
            // DiagnosisTB
            // 
            this.DiagnosisTB.BackColor = System.Drawing.Color.DarkGray;
            this.DiagnosisTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiagnosisTB.Location = new System.Drawing.Point(194, 161);
            this.DiagnosisTB.Multiline = true;
            this.DiagnosisTB.Name = "DiagnosisTB";
            this.DiagnosisTB.Size = new System.Drawing.Size(135, 23);
            this.DiagnosisTB.TabIndex = 11;
            this.DiagnosisTB.Text = "Diagnosis";
            // 
            // MedicationTB
            // 
            this.MedicationTB.BackColor = System.Drawing.Color.DarkGray;
            this.MedicationTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MedicationTB.Location = new System.Drawing.Point(194, 190);
            this.MedicationTB.Multiline = true;
            this.MedicationTB.Name = "MedicationTB";
            this.MedicationTB.Size = new System.Drawing.Size(135, 23);
            this.MedicationTB.TabIndex = 12;
            this.MedicationTB.Text = "Medication";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(149, 308);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 47);
            this.button4.TabIndex = 19;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(257, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 47);
            this.button3.TabIndex = 18;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(149, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 47);
            this.button2.TabIndex = 17;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(40, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 47);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(146, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 27);
            this.label3.TabIndex = 21;
            this.label3.Text = "DIAGNOSIS SUMMARY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(428, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 36);
            this.label4.TabIndex = 22;
            this.label4.Text = "DIAGNOSES";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.DiagnosisLabel);
            this.panel2.Controls.Add(this.MedicationLabel);
            this.panel2.Controls.Add(this.SymptomsLabel);
            this.panel2.Controls.Add(this.PatientLabel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(370, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(588, 270);
            this.panel2.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(481, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 21);
            this.label9.TabIndex = 26;
            this.label9.Text = "Date";
            // 
            // DiagnosisLabel
            // 
            this.DiagnosisLabel.AutoSize = true;
            this.DiagnosisLabel.BackColor = System.Drawing.Color.Transparent;
            this.DiagnosisLabel.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DiagnosisLabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.DiagnosisLabel.Location = new System.Drawing.Point(298, 53);
            this.DiagnosisLabel.Name = "DiagnosisLabel";
            this.DiagnosisLabel.Size = new System.Drawing.Size(102, 21);
            this.DiagnosisLabel.TabIndex = 25;
            this.DiagnosisLabel.Text = "Diagnosis";
            // 
            // MedicationLabel
            // 
            this.MedicationLabel.AutoSize = true;
            this.MedicationLabel.BackColor = System.Drawing.Color.Transparent;
            this.MedicationLabel.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MedicationLabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.MedicationLabel.Location = new System.Drawing.Point(298, 127);
            this.MedicationLabel.Name = "MedicationLabel";
            this.MedicationLabel.Size = new System.Drawing.Size(113, 21);
            this.MedicationLabel.TabIndex = 24;
            this.MedicationLabel.Text = "Medication";
            // 
            // SymptomsLabel
            // 
            this.SymptomsLabel.AutoSize = true;
            this.SymptomsLabel.BackColor = System.Drawing.Color.Transparent;
            this.SymptomsLabel.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SymptomsLabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.SymptomsLabel.Location = new System.Drawing.Point(20, 127);
            this.SymptomsLabel.Name = "SymptomsLabel";
            this.SymptomsLabel.Size = new System.Drawing.Size(109, 21);
            this.SymptomsLabel.TabIndex = 23;
            this.SymptomsLabel.Text = "Symptoms";
            // 
            // PatientLabel
            // 
            this.PatientLabel.AutoSize = true;
            this.PatientLabel.BackColor = System.Drawing.Color.Transparent;
            this.PatientLabel.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientLabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.PatientLabel.Location = new System.Drawing.Point(20, 53);
            this.PatientLabel.Name = "PatientLabel";
            this.PatientLabel.Size = new System.Drawing.Size(129, 21);
            this.PatientLabel.TabIndex = 22;
            this.PatientLabel.Text = "PatientName";
            // 
            // DiagnosisGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DiagnosisGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DiagnosisGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DiagnosisGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiagnosisGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DiagnosisGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DiagnosisGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DiagnosisGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.DiagnosisGV.Location = new System.Drawing.Point(30, 425);
            this.DiagnosisGV.Name = "DiagnosisGV";
            this.DiagnosisGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DiagnosisGV.RowHeadersVisible = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.DiagnosisGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DiagnosisGV.RowTemplate.Height = 25;
            this.DiagnosisGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DiagnosisGV.Size = new System.Drawing.Size(928, 191);
            this.DiagnosisGV.TabIndex = 24;
            this.DiagnosisGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientGV_CellContentClick);
            // 
            // Diagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1003, 628);
            this.Controls.Add(this.DiagnosisGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MedicationTB);
            this.Controls.Add(this.DiagnosisTB);
            this.Controls.Add(this.SymptomsTB);
            this.Controls.Add(this.PatientNameTB);
            this.Controls.Add(this.PatientIdCB);
            this.Controls.Add(this.DiagnosisID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Diagnosis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagnosis";
            this.Load += new System.EventHandler(this.Diagnosis_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DiagnosisID;
        private System.Windows.Forms.ComboBox PatientIdCB;
        private System.Windows.Forms.TextBox PatientNameTB;
        private System.Windows.Forms.TextBox SymptomsTB;
        private System.Windows.Forms.TextBox DiagnosisTB;
        private System.Windows.Forms.TextBox MedicationTB;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label DiagnosisLabel;
        private System.Windows.Forms.Label MedicationLabel;
        private System.Windows.Forms.Label SymptomsLabel;
        private System.Windows.Forms.Label PatientLabel;
        private System.Windows.Forms.DataGridView DiagnosisGV;
        private System.Windows.Forms.Button Close;
    }
}