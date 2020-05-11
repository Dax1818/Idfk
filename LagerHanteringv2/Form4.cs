using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace LagerHanteringv2
{
    public partial class Form4 : Form
    {

        string message = "Are you sure that you want to delete this customer?";
        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
        string title = "";
        public Form4()
        {
            InitializeComponent();
            timer1.Start();
        }
        SqlConnection con = new SqlConnection(@"Data Source=JDTN5H2\SQLSERVERFBS;Initial Catalog=Database Diagrams;Integrated Security=True");

        private void Form4_Load(object sender, EventArgs e)
        {
            con.Open();
            String query = "SELECT * FROM DataGridViewTable_UserDetails";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form5 fithForm = new Form5();
            fithForm.Show();
            con.Open();
            String query = "SELECT * FROM DataGridViewTable_UserDetails";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            this.label3.Text = time.ToString("dd/MM/yyyy  hh:mm:ss");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "Name like '%" + textBox1.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        private void BTDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                con.Open();
                string Selected_First_name = dataGridView1.CurrentRow.Cells["FirstName"].Value.ToString();
                string Selected_Last_name = dataGridView1.CurrentRow.Cells["LastName"].Value.ToString();
                string Selected_Phone_number = dataGridView1.CurrentRow.Cells["PhoneNumber"].Value.ToString();
                string Selected_SSN = dataGridView1.CurrentRow.Cells["SSN"].Value.ToString();
                string Selected_Email = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                string Selected_Date = dataGridView1.CurrentRow.Cells["Date"].Value.ToString();
                String query = "DELETE FROM DataGridViewTable_UserDetails WHERE FirstName = '" + Selected_First_name + "' AND LastName = '" + Selected_Last_name + "' AND PhoneNumber = '" + Selected_Phone_number + "' AND SSN = '" + Selected_SSN + "' AND Email = '" + Selected_Email + "' AND Date = '" + Selected_Date + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                con.Open();
                String query2 = "SELECT * FROM DataGridViewTable_UserDetails";
                SqlDataAdapter SDA2 = new SqlDataAdapter(query2, con);
                DataTable dt = new DataTable();
                SDA2.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "SELECT * FROM DataGridViewTable_UserDetails";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
