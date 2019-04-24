using NorthwindCF.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindEF.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CustomerBLL.Getcustomer();
        }
        
        private void getOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orders frm = new Orders();
            frm.CustomerID = dataGridView1.SelectedRows[0].Cells["CustomerID"].Value.ToString();
            frm.Show();
        }
    }
}
