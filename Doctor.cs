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

namespace Hospital_Management_System___HIT_Clinic
{
    public partial class Doctor : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BullionBars\Documents\HIT_HMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        public Doctor()
        {
            InitializeComponent();
        }
        void populate()
        {
            Con.Open();
            string query = "select * from DoctorTable";
            SqlDataAdapter sqlData = new SqlDataAdapter(query, Con);
            SqlCommandBuilder sqlCommand = new SqlCommandBuilder(sqlData);
            var ds = new DataSet();
            sqlData.Fill(ds);
            DoctorGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DoctorID.Text == "" || DoctorName.Text == "" || DateOfEmployement.Text == "" || Password.Text == "")
                MessageBox.Show("Error! Empty Fields Not Allowed", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Con.Open();
                string query = "Insert Into DoctorTable values(" + DoctorID.Text + ",'" + DoctorName.Text + "','" + DateOfEmployement.Text + "', '" + Password.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Docter Record Added Successfully");
                Con.Close();
                populate();
            }
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(DoctorID.Text == "")
            {
                MessageBox.Show("Enter Doctor ID");
            }
            else
            {
                Con.Open();
                string query = "Delete from DoctorTable where DoctorID = " + DoctorID.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Record Deleted Successfully.");
                Con.Close();
                populate();
            }
        }

        private void DoctorGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DoctorID.Text = DoctorGV.SelectedRows[0].Cells[0].Value.ToString();
            DoctorName.Text = DoctorGV.SelectedRows[0].Cells[1].Value.ToString();
            DateOfEmployement.Text = DoctorGV.SelectedRows[0].Cells[2].Value.ToString();
            Password.Text = DoctorGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "Update DoctorTable Set DoctorName = '"+DoctorName.Text+"', DateOfEmployement = '"+DateOfEmployement.Text+"', Password = '"+Password.Text+"' Where DoctorID = '"+DoctorID.Text+"'";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Doctor Updated Successfully!");
            Con.Close();
            populate();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
