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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\asp.net\Aggry_Mole_management_system_shope\Aggry_Mole_management_system_shope\Agreemole.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cat_submit_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string str = "insert into CategoryTB values("+txt_cat_id.Text+",'"+txt_cat_name.Text+"','"+txt_cat_type.Text+"')";
                cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Category Add Successfully");
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        void populate()
        {

            con.Open();

            string str1 = "select * from CategoryTB";
            da = new SqlDataAdapter(str1, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.Fill(ds);

            Cat_GridView.DataSource = ds.Tables[0];
            con.Close();
        }


        private void btn_cat_delete_Click(object sender, EventArgs e)
        {
            if (txt_cat_id.Text == "")
            {
                MessageBox.Show("Enter The Categories Id");
            }
            else
            {
                try
                {
                    con.Open();
                   string str3 = "delete from CategoryTB where CatId='" + txt_cat_id.Text + "'";
                    cmd = new SqlCommand(str3, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Categories Successfully Deleted");
                    con.Close();
                    populate();
                }
                catch
                {

                }
            }
        }

        private void btn_cat_home_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_cat_id.Text=Cat_GridView.SelectedRows[0].Cells[0].Value.ToString();
            txt_cat_name.Text = Cat_GridView.SelectedRows[0].Cells[0].Value.ToString();
            txt_cat_type.Text = Cat_GridView.SelectedRows[0].Cells[0].Value.ToString();

        }

        private void Category_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_cat_edit_Click(object sender, EventArgs e)
        {
            string str2 = "select * from CategoryTB";
            da = new SqlDataAdapter(str2, con);
            da.Fill(ds);


            try
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("update CategoryTB set CatName='" + txt_cat_name.Text + "','"+txt_cat_type.Text+"' where CatId=" + txt_cat_id.Text + "", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Categories Updated Successfully");
                con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
