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
    public partial class Diagnosis : Form
    {
        public Diagnosis()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BullionBars\Documents\HIT_HMSdb.mdf;Integrated Security=True;Connect Timeout=30");

        void populate()
        {
            Con.Open();
            string query = "select * from DiagnosisTable";
            SqlDataAdapter sqlData = new SqlDataAdapter(query, Con);
            SqlCommandBuilder sqlCommand = new SqlCommandBuilder(sqlData);
            var ds = new DataSet();
            sqlData.Fill(ds);
            DiagnosisGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        void populateCombo()
        {
            string sql = "SELECT * FROM PatientTable";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("PatientID", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                PatientIdCB.ValueMember = "PatientID";
                PatientIdCB.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }
        string patName;

        void fetchName()
        {
            Con.Open();
            string mySql = "SELECT * FROM PatientTable WHERE PatientID = "+PatientIdCB.SelectedValue.ToString()+"";
            SqlCommand cmd = new SqlCommand(mySql, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                patName = dr["PatientName"].ToString();
                PatientNameTB.Text = patName;
            }
            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void PatientGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DiagnosisID.Text = DiagnosisGV.SelectedRows[0].Cells[0].Value.ToString();
            PatientIdCB.Text = DiagnosisGV.SelectedRows[0].Cells[1].Value.ToString();
            PatientNameTB.Text = DiagnosisGV.SelectedRows[0].Cells[2].Value.ToString();
            SymptomsTB.Text = DiagnosisGV.SelectedRows[0].Cells[3].Value.ToString();
            DiagnosisTB.Text = DiagnosisGV.SelectedRows[0].Cells[4].Value.ToString();
            MedicationTB.Text = DiagnosisGV.SelectedRows[0].Cells[5].Value.ToString();
            PatientLabel.Text = DiagnosisGV.SelectedRows[0].Cells[2].Value.ToString();
            DiagnosisLabel.Text = DiagnosisGV.SelectedRows[0].Cells[4].Value.ToString();
            SymptomsLabel.Text = DiagnosisGV.SelectedRows[0].Cells[3].Value.ToString();
            MedicationLabel.Text = DiagnosisGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DiagnosisID.Text == "" || PatientNameTB.Text == "" || SymptomsTB.Text == "" || MedicationTB.Text == "" || PatientIdCB.Text == "" || DiagnosisTB.Text == "")
                MessageBox.Show("Error! Empty Fields Not Allowed", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Con.Open();
                string query = "Insert Into DiagnosisTable values(" + DiagnosisID.Text + ",'" + PatientIdCB.SelectedValue.ToString() + "','"+PatientNameTB.Text+"','" + SymptomsTB.Text + "', '" + DiagnosisTB.Text + "', '" + MedicationTB.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis Record Added Successfully");
                Con.Close();
                populate();
            }
        }

        private void PatientIdTB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Diagnosis_Load(object sender, EventArgs e)
        {
            populate();
            populateCombo();
        }

        private void PatientIdCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchName();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DiagnosisID.Text == "")
            {
                MessageBox.Show("Enter Patient ID");
            }
            else
            {
                Con.Open();
                string query = "Delete from DiagnosisTable where DiagnosisID = " + DiagnosisID.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis Record Deleted Successfully.");
                Con.Close();
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "Update DiagnosisTable Set PatientId = '" + PatientIdCB.SelectedValue.ToString() + "', PatientName = '" + PatientNameTB.Text + "', Symptoms = '" + SymptomsTB.Text + "', Diagnosis = '" + DiagnosisTB.Text + "', Medication = '" + MedicationTB.Text + "' Where DiagnosisID = '" + DiagnosisID.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Diagnosis Record Updated Successfully!");
            Con.Close();
            populate();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
