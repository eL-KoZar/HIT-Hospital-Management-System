
namespace Hospital_Management_System___HIT_Clinic
{
    partial class Patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PatientId = new System.Windows.Forms.TextBox();
            this.PatientName = new System.Windows.Forms.TextBox();
            this.PatientAdd = new System.Windows.Forms.TextBox();
            this.PatientPhone = new System.Windows.Forms.TextBox();
            this.DateOfBirth = new System.Windows.Forms.TextBox();
            this.PatientGen = new System.Windows.Forms.ComboBox();
            this.PatientBG = new System.Windows.Forms.ComboBox();
            this.PatientIllness = new System.Windows.Forms.TextBox();
            this.DateCreated = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PatientGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGV)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1087, 87);
            this.panel1.TabIndex = 1;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Close.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Close.Location = new System.Drawing.Point(1035, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(52, 40);
            this.Close.TabIndex = 20;
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
            this.label2.Location = new System.Drawing.Point(314, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "PATIENT RECORDS";
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
            // PatientId
            // 
            this.PatientId.BackColor = System.Drawing.Color.DarkGray;
            this.PatientId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PatientId.Location = new System.Drawing.Point(74, 138);
            this.PatientId.Multiline = true;
            this.PatientId.Name = "PatientId";
            this.PatientId.Size = new System.Drawing.Size(135, 23);
            this.PatientId.TabIndex = 2;
            this.PatientId.Text = "Patient_ID";
            // 
            // PatientName
            // 
            this.PatientName.BackColor = System.Drawing.Color.DarkGray;
            this.PatientName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PatientName.Location = new System.Drawing.Point(74, 167);
            this.PatientName.Multiline = true;
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(135, 23);
            this.PatientName.TabIndex = 3;
            this.PatientName.Text = "Patient_Name";
            // 
            // PatientAdd
            // 
            this.PatientAdd.BackColor = System.Drawing.Color.DarkGray;
            this.PatientAdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PatientAdd.Location = new System.Drawing.Point(74, 225);
            this.PatientAdd.Multiline = true;
            this.PatientAdd.Name = "PatientAdd";
            this.PatientAdd.Size = new System.Drawing.Size(135, 23);
            this.PatientAdd.TabIndex = 4;
            this.PatientAdd.Text = "Patient_Address";
            // 
            // PatientPhone
            // 
            this.PatientPhone.BackColor = System.Drawing.Color.DarkGray;
            this.PatientPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PatientPhone.Location = new System.Drawing.Point(74, 254);
            this.PatientPhone.Multiline = true;
            this.PatientPhone.Name = "PatientPhone";
            this.PatientPhone.Size = new System.Drawing.Size(135, 23);
            this.PatientPhone.TabIndex = 5;
            this.PatientPhone.Text = "Patient_Phone";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.BackColor = System.Drawing.Color.DarkGray;
            this.DateOfBirth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateOfBirth.Location = new System.Drawing.Point(74, 196);
            this.DateOfBirth.Multiline = true;
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(135, 23);
            this.DateOfBirth.TabIndex = 6;
            this.DateOfBirth.Text = "Date_Of_Birth";
            // 
            // PatientGen
            // 
            this.PatientGen.BackColor = System.Drawing.Color.DarkGray;
            this.PatientGen.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PatientGen.FormattingEnabled = true;
            this.PatientGen.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.PatientGen.Location = new System.Drawing.Point(74, 283);
            this.PatientGen.Name = "PatientGen";
            this.PatientGen.Size = new System.Drawing.Size(135, 23);
            this.PatientGen.TabIndex = 7;
            this.PatientGen.Text = "Gender";
            // 
            // PatientBG
            // 
            this.PatientBG.BackColor = System.Drawing.Color.DarkGray;
            this.PatientBG.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PatientBG.FormattingEnabled = true;
            this.PatientBG.Items.AddRange(new object[] {
            "AB+",
            "AB-",
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-"});
            this.PatientBG.Location = new System.Drawing.Point(74, 312);
            this.PatientBG.Name = "PatientBG";
            this.PatientBG.Size = new System.Drawing.Size(135, 23);
            this.PatientBG.TabIndex = 8;
            this.PatientBG.Text = "Blood_Group";
            // 
            // PatientIllness
            // 
            this.PatientIllness.BackColor = System.Drawing.Color.DarkGray;
            this.PatientIllness.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PatientIllness.Location = new System.Drawing.Point(74, 341);
            this.PatientIllness.Multiline = true;
            this.PatientIllness.Name = "PatientIllness";
            this.PatientIllness.Size = new System.Drawing.Size(135, 23);
            this.PatientIllness.TabIndex = 9;
            this.PatientIllness.Text = "Major_Illness";
            // 
            // DateCreated
            // 
            this.DateCreated.BackColor = System.Drawing.Color.DarkGray;
            this.DateCreated.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateCreated.Location = new System.Drawing.Point(74, 370);
            this.DateCreated.Multiline = true;
            this.DateCreated.Name = "DateCreated";
            this.DateCreated.Size = new System.Drawing.Size(135, 23);
            this.DateCreated.TabIndex = 11;
            this.DateCreated.Text = "Date_Created";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(123, 519);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 47);
            this.button4.TabIndex = 15;
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
            this.button3.Location = new System.Drawing.Point(231, 451);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 47);
            this.button3.TabIndex = 14;
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
            this.button2.Location = new System.Drawing.Point(123, 451);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 47);
            this.button2.TabIndex = 13;
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
            this.button1.Location = new System.Drawing.Point(14, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 47);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(577, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 36);
            this.label3.TabIndex = 16;
            this.label3.Text = "PATIENTS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(215, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "(yyyy-mm-dd)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(215, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "(yyyy-mm-dd)";
            // 
            // PatientGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.PatientGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PatientGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PatientGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PatientGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.PatientGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PatientGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PatientGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.PatientGV.Location = new System.Drawing.Point(338, 138);
            this.PatientGV.Name = "PatientGV";
            this.PatientGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.PatientGV.RowHeadersVisible = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.PatientGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.PatientGV.RowTemplate.Height = 25;
            this.PatientGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PatientGV.Size = new System.Drawing.Size(715, 428);
            this.PatientGV.TabIndex = 19;
            this.PatientGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientGV_CellContentClick);
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1087, 663);
            this.Controls.Add(this.PatientGV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DateCreated);
            this.Controls.Add(this.PatientIllness);
            this.Controls.Add(this.PatientBG);
            this.Controls.Add(this.PatientGen);
            this.Controls.Add(this.DateOfBirth);
            this.Controls.Add(this.PatientPhone);
            this.Controls.Add(this.PatientAdd);
            this.Controls.Add(this.PatientName);
            this.Controls.Add(this.PatientId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BloodGroup";
            this.Load += new System.EventHandler(this.Patient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PatientId;
        private System.Windows.Forms.TextBox PatientName;
        private System.Windows.Forms.TextBox PatientAdd;
        private System.Windows.Forms.TextBox PatientPhone;
        private System.Windows.Forms.TextBox DateOfBirth;
        private System.Windows.Forms.ComboBox PatientGen;
        private System.Windows.Forms.ComboBox PatientBG;
        private System.Windows.Forms.TextBox PatientIllness;
        private System.Windows.Forms.TextBox DateCreated;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView PatientGV;
        private System.Windows.Forms.TextBox Pat_name;
        private System.Windows.Forms.TextBox DateOf;
        private System.Windows.Forms.Button Close;
    }
}