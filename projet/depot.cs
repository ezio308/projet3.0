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
using System.Configuration;

namespace projet
{
    public partial class depot : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=LAPTOP-NJ81HHSQ\SQLSERVER;Initial Catalog=dbdd;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader Reader;
        DataTable table = new DataTable();
        public depot()
        {
            InitializeComponent();
        }

        private void depot_Load(object sender, EventArgs e)
        {

        }
        public void Deconnecter()//ay bd ma7loula tssakerha//
        {
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deconnecter();
            cnx.Open();
            int x = int.Parse(textBox2.Text);

            cmd = new SqlCommand("INSERT INTO demande (datedepot,frais,login) VALUES ('" +DateTime.Today+ "',"+x+")", cnx);
            int i = cmd.ExecuteNonQuery();
        }
    }
}
