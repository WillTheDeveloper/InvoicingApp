using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoicingApp
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

        private void bttn_products_Click(object sender, EventArgs e)
        {
            var p = new Products();
            p.Show();
        }

        private void bttn_customers_Click(object sender, EventArgs e)
        {
            var c = new Customers();
            c.Show();
        }
    }
}
