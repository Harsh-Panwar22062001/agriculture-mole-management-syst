using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aggry_Mole_management_system_shope
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agreemoleDataSet6.OrderTB' table. You can move, or remove it, as needed.
            this.orderTBTableAdapter.Fill(this.agreemoleDataSet6.OrderTB);
            // TODO: This line of code loads data into the 'agreemoleDataSet5.ProductTB' table. You can move, or remove it, as needed.
            this.productTBTableAdapter.Fill(this.agreemoleDataSet5.ProductTB);
            // TODO: This line of code loads data into the 'agreemoleDataSet4.CustomerTB' table. You can move, or remove it, as needed.
            this.customerTBTableAdapter.Fill(this.agreemoleDataSet4.CustomerTB);
            // TODO: This line of code loads data into the 'agreemoleDataSet.CategoryTB' table. You can move, or remove it, as needed.
            this.categoryTBTableAdapter.Fill(this.agreemoleDataSet.CategoryTB);

        }

        private void btn_insert_orders_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Order Successfully...");
        }

        private void btn_product_home_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }
    }
}
