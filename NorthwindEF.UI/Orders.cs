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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }
        public string CustomerID;
        private void Orders_Load(object sender, EventArgs e)
        {
            dgv_orders.DataSource = OrderBLL.OrderListele(CustomerID);
        }
    }
}
