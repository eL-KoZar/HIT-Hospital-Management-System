using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Management_System___HIT_Clinic
{
    public partial class Patient : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BullionBars\Documents\HIT_HMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        public Patient()
        {
            InitializeComponent();
        }

        void populate()
        {
            Con.Open();
            string query = "select * from PatientTable";
            SqlDataAdapter sqlData = new SqlDataAdapter(query, Con);
            SqlCommandBuilder sqlCommand = new SqlCommandBuilder(sqlData);
            var ds = new DataSet();
            sqlData.Fill(ds);
            PatientGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PatientId.Text == "" || PatientName.Text == "" || DateOfBirth.Text == "" || PatientAdd.Text == "" || PatientPhone.Text == "" || PatientGen.Text == "" || PatientBG.Text == "" || PatientIllness.Text == "" || DateCreated.Text == "")
                MessageBox.Show("Error! Empty Fields Not Allowed", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Con.Open();
                string query = "Insert Into PatientTable values(" + PatientId.Text + ",'" + PatientName.Text + "','" + DateOfBirth.Text + "', '" + PatientAdd.Text + "', '" + PatientPhone.Text + "', '" + PatientGen.SelectedItem.ToString() + "', '" + PatientBG.SelectedItem.ToString() + "', '" + PatientIllness.Text + "', '" + DateCreated.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Record Added Successfully");
                Con.Close();
                populate();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PatientId.Text == "")
            {
                MessageBox.Show("Enter Patient ID");
            }
            else
            {
                Con.Open();
                string query = "Delete from PatientTable where PatientId = " + PatientId.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Record Deleted Successfully.");
                Con.Close();
                populate();
            }
        }

        private void PatientGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatientId.Text = PatientGV.SelectedRows[0].Cells[0].Value.ToString();
            PatientName.Text = PatientGV.SelectedRows[0].Cells[1].Value.ToString();
            DateOfBirth.Text = PatientGV.SelectedRows[0].Cells[2].Value.ToString();
            PatientAdd.Text = PatientGV.SelectedRows[0].Cells[3].Value.ToString();
            PatientPhone.Text = PatientGV.SelectedRows[0].Cells[4].Value.ToString();
            PatientGen.Text = PatientGV.SelectedRows[0].Cells[5].Value.ToString();
            PatientBG.Text = PatientGV.SelectedRows[0].Cells[6].Value.ToString();
            PatientIllness.Text = PatientGV.SelectedRows[0].Cells[7].Value.ToString();
            DateCreated.Text = PatientGV.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "Update PatientTable Set PatientName = '" + PatientName.Text + "', DateOfBirth = '" + DateOfBirth.Text + "', PatientAddress = '" + PatientAdd.Text + "', PatientPhone = '" + PatientPhone.Text + "', Gender = '" + PatientGen.Text + "', BloodGroup = '" + PatientBG.Text + "', MajorIllness = '" + PatientIllness.Text + "', DateCreated = '" + DateCreated.Text + "' Where PatientId = '" + PatientId.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Patient Record Updated Successfully!");
            Con.Close();
            populate();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
