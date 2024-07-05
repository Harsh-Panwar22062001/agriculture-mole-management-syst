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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void btn_cat_submit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Customer Successfully...");
        }

        private void btn_cat_edit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit Customer Successfully...");
        }

        private void btn_cat_delete_Click(object sender, EventArgs e)
        {
             MessageBox.Show("Delete Customer Successfully...");
        }

        private void btn_cat_home_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agreemoleDataSet1.CustomerTB' table. You can move, or remove it, as needed.
            this.customerTBTableAdapter.Fill(this.agreemoleDataSet1.CustomerTB);

        }
    }
}
