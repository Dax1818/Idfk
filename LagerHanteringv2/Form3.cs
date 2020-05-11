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
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        private Form2 mainform = null;

        public Form3(Form callingForm)
        {
            mainform = callingForm as Form2;
            InitializeComponent();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            File.AppendAllText("C:\\ProgramData\\heaven\\nameandnmbr.rex", TxtBoxAddCategory.Text + Environment.NewLine);
            mainform.CBCategory.DataSource = File.ReadAllLines("C:\\ProgramData\\heaven\\nameandnmbr.rex");
        }

        public void TxtBoxAddCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TxtBoxAddCategory.Text = "";
        }
    }
}
