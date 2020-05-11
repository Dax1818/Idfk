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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=JDTN5H2\SQLSERVERFBS;Initial Catalog=Database Diagrams;Integrated Security=True");
    }
}
