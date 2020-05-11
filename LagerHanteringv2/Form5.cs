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
    public partial class Form5 : Form
    {

        string message = "Are you sure you want to add this customer?";
        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
        string title = "";
        public Form5()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=JDTN5H2\SQLSERVERFBS;Initial Catalog=Database Diagrams;Integrated Security=True");
        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        private void BTAdd_Click(object sender, EventArgs e)
        {
            Form4 forthForm = new Form4();
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                con.Open();
                String query = "INSERT INTO DataGridViewTable_UserDetails (FirstName,LastName,PhoneNumber,SSN,Email,Date) VALUES('" + TBFName.Text + "','" + TBLName.Text + "','" + TBPhoneNumber.Text + "','" + TBSSN.Text + "','" + label.Text + "','" + TBDate.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                this.Close();
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void BTClear_Click(object sender, EventArgs e)
        {
            TBFName.Text = "";
            TBLName.Text = "";
            TBPhoneNumber.Text = "";
            TBSSN.Text = "";
            label.Text = "";
            TBDate.Text = "";
        }
    }
}
