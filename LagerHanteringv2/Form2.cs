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
    public partial class Form2 : Form
    {
        
        string message = "Do you want to save this product?";
        string message1 = "Are you sure you want to delete this product?";
        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
        string title = "";

        public Form2()
        {
            InitializeComponent();
            timer1.Start();
        }
        //This establishes the connection to my SQL server!
        SqlConnection con = new SqlConnection(@"Data Source=JDTN5H2\SQLSERVERFBS;Initial Catalog=Database Diagrams;Integrated Security=True");

        private void Form2_Load(object sender, EventArgs e)
        {
            CBCategory.DataSource = File.ReadAllLines("C:\\ProgramData\\heaven\\nameandnmbr.rex");
            con.Open();
            String query = "SELECT * FROM DataGridView_Table2";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void BTAdd_Click(object sender, EventArgs e)
        {
            if (TBName.Text == "" || TBQuantity.Text == "" || TBPrice.Text == "" || TBDescription.Text == "" || CBCategory.Text == "")
            {
                MessageBox.Show("Please fill in all of the product information");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM DataGridView_Table2 WHERE Name = '" + TBName.Text + "' AND Description = '" + TBDescription.Text + "'", con);
                SqlDataAdapter SDA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                SDA.Fill(DS);
                int i = DS.Tables[0].Rows.Count;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (i > 0)
                {
                    MessageBox.Show("Product with name:" + TBName.Text + "and description:" + TBDescription.Text + "already exists. Are you sure you want to save?");
                    if (result == DialogResult.Yes)
                    {
                        con.Open();
                        String query = "INSERT INTO DataGridView_Table2 (Name,Quantity,Price,Description,Category) VALUES('" + TBName.Text + "','" + TBQuantity.Text + "','" + TBPrice.Text + "','" + TBDescription.Text + "','" + CBCategory.Text + "')";
                        SqlDataAdapter SDA1 = new SqlDataAdapter(query, con);
                        SDA1.SelectCommand.ExecuteNonQuery();
                        con.Close();
                    }
                    else if (result == DialogResult.No)
                    {

                    }
                }
                else
                {


                    DialogResult result1 = MessageBox.Show(message, title, buttons);
                    if (result1 == DialogResult.Yes)
                    {
                        con.Open();
                        String query = "INSERT INTO DataGridView_Table2 (Name,Quantity,Price,Description,Category) VALUES('" + TBName.Text + "','" + TBQuantity.Text + "','" + TBPrice.Text + "','" + TBDescription.Text + "','" + CBCategory.Text + "')";
                        SqlDataAdapter SDA1 = new SqlDataAdapter(query, con);
                        SDA1.SelectCommand.ExecuteNonQuery();
                        con.Close();
                        con.Open();
                        String query1 = "SELECT * FROM DataGridView_Table2";
                        SqlDataAdapter SDA2 = new SqlDataAdapter(query1, con);
                        DataTable dt1 = new DataTable();
                        SDA2.Fill(dt1);
                        dataGridView1.DataSource = dt1;
                        con.Close();
                    }
                    else if (result1 == DialogResult.No)
                    {

                    }
                }
            }
        }

        private void BTClear_Click(object sender, EventArgs e)
        {
            CBCategory.Text = "";
            TBName.Text = "";
            TBDescription.Text = "";
            TBQuantity.Text = "";
            TBPrice.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string selected_Name = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            string selected_Quantity = dataGridView1.CurrentRow.Cells["Quantity"].Value.ToString();
            string selected_Price = dataGridView1.CurrentRow.Cells["Price"].Value.ToString();
            string selected_Description = dataGridView1.CurrentRow.Cells["Description"].Value.ToString();
            string selected_Category = dataGridView1.CurrentRow.Cells["Category"].Value.ToString();
            string query = "UPDATE DataGridView_Table2 SET Name = '" + TBName.Text + "',Quantity = '" + TBQuantity.Text + "',Price = '" + TBPrice.Text + "',Description = '" + TBDescription.Text + "',Category = '" + CBCategory.Text + "'WHERE Name = '" + selected_Name + "' AND Quantity = '" + selected_Quantity + "' AND Price = '" + selected_Price + "' AND Description = '" + selected_Description + "' AND Category = '" + selected_Category + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            con.Open();
            String query1 = "SELECT * FROM DataGridView_Table2";
            SqlDataAdapter SDA1 = new SqlDataAdapter(query1, con);
            DataTable dt = new DataTable();
            SDA1.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(message1, title, buttons);
            if (result == DialogResult.Yes)
            {
                con.Open();
                string selected_Name = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
                string selected_Quantity = dataGridView1.CurrentRow.Cells["Quantity"].Value.ToString();
                string selected_Price = dataGridView1.CurrentRow.Cells["Price"].Value.ToString();
                string selected_Description = dataGridView1.CurrentRow.Cells["Description"].Value.ToString();
                string selected_Category = dataGridView1.CurrentRow.Cells["Category"].Value.ToString();
                String query = "DELETE FROM DataGridView_Table2 WHERE Name = '" + selected_Name + "' AND Quantity = '" + selected_Quantity + "' AND Price = '" + selected_Price + "' AND Description = '" + selected_Description + "' AND Category = '" + selected_Category + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                con.Open();
                String query1 = "SELECT * FROM DataGridView_Table2";
                SqlDataAdapter SDA1 = new SqlDataAdapter(query1, con);
                DataTable dt = new DataTable();
                SDA1.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (result == DialogResult.No)
            {
                
            }
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            Form3 thirdForm = new Form3(this);
            thirdForm.Show();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TBName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            TBQuantity.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            TBPrice.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            TBDescription.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            CBCategory.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "Name like '%" + textBox1.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            this.label3.Text = time.ToString("dd/MM/yyyy hh:mm:ss");
        }
    }
}
