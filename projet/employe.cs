using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet
{
    public partial class employe : Form
    {
        public employe(string text)
        {
            InitializeComponent();
            shox(text);
           
        }
        

        private void employe_Load(object sender, EventArgs e)
        {

        }

        public void shox(string x)
        {
            depot depot = new depot();
            depot.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            shox(Text);
        }
        
    }
}
