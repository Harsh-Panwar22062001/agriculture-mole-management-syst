using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Aggry_Mole_management_system_shope
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\asp.net\Aggry_Mole_management_system_shope\Aggry_Mole_management_system_shope\Agreemole.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_product_id.Text = ProductGV.SelectedRows[0].Cells[0].Value.ToString();
            txt_product_name.Text = ProductGV.SelectedRows[0].Cells[1].Value.ToString();
            txt_product_qty.Text = ProductGV.SelectedRows[0].Cells[2].Value.ToString();
            txt_product_price.Text = ProductGV.SelectedRows[0].Cells[3].Value.ToString();
            txt_product_description.Text = ProductGV.SelectedRows[0].Cells[4].Value.ToString();
            CatCombo.SelectedValue = ProductGV.SelectedRows[0].Cells[5].Value.ToString();
        }
        void populate()
        {
            try
            {
                con.Open();
                string str = "select * from ProductTB";
                SqlDataAdapter da = new SqlDataAdapter(str, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);

                ProductGV.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }

       
        private void Product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agreemoleDataSet2.ProductTB' table. You can move, or remove it, as needed.
            this.productTBTableAdapter.Fill(this.agreemoleDataSet2.ProductTB);
            // TODO: This line of code loads data into the 'agreemoleDataSet.CategoryTB' table. You can move, or remove it, as needed.
            this.categoryTBTableAdapter.Fill(this.agreemoleDataSet.CategoryTB);
            populate();
           // fillsearchcombo();
        }

        private void btn_cat_edit_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Edit Data Successfully...");
            }
            catch
            {
                MessageBox.Show("Please Check Input Details...");
            }
        }

        private void btn_cat_delete_Click(object sender, EventArgs e)
        {
            if(txt_product_id.Text=="")
            {
                MessageBox.Show("Please Input ID");
            }
            else
            {
                MessageBox.Show("Delete Data Successfully");
            }
        }

        private void btn_cat_home_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }
    }
}
