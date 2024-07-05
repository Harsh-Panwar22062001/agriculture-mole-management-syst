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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_login_username.Text=="ADMIN" && txt_login_password.Text=="ADMIN123")
                {
                    MainForm mf = new MainForm();
                    mf.Show();
                    this.Hide();
                }    
            }
            catch(Exception ex)
            {

            }
        }
    }
}
