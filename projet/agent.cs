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
    public partial class agent : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=LAPTOP-NJ81HHSQ\SQLSERVER;Initial Catalog=dbdd;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader Reader;
        DataTable table = new DataTable();
        public agent()
        {
            InitializeComponent();
        }

        private void agent_Load(object sender, EventArgs e)
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
            remplirgrid();
        }
        public void remplirgrid()
        {
            Deconnecter();
            cnx.Open();
            cmd = new SqlCommand("select * from demande where reponse is NULL ", cnx);
            Reader = cmd.ExecuteReader();
            table.Load(Reader);
            dataGridView1.DataSource = table;
            cnx.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
