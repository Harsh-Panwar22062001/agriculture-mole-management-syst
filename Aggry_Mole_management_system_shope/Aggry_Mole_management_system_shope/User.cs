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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void btn_cat_submit_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Add User Successfully...");
            }
            catch
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_cat_edit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit Data Successfully...");
        }

        private void btn_cat_delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User removed Successfully..."); 
        }

        private void btn_cat_home_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agreemoleDataSet3.UserTB' table. You can move, or remove it, as needed.
            this.userTBTableAdapter.Fill(this.agreemoleDataSet3.UserTB);

        }
    }
}
