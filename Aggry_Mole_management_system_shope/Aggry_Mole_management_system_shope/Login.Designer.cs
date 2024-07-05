
namespace Aggry_Mole_management_system_shope
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_login_clrar = new System.Windows.Forms.Label();
            this.checkBox_login = new System.Windows.Forms.CheckBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_login_password = new System.Windows.Forms.TextBox();
            this.txt_login_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_login_clrar);
            this.panel1.Controls.Add(this.checkBox_login);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.txt_login_password);
            this.panel1.Controls.Add(this.txt_login_username);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(327, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 565);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(80, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 40);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(71, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username";
            // 
            // lbl_login_clrar
            // 
            this.lbl_login_clrar.AutoSize = true;
            this.lbl_login_clrar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_login_clrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_clrar.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_login_clrar.Location = new System.Drawing.Point(80, 498);
            this.lbl_login_clrar.Name = "lbl_login_clrar";
            this.lbl_login_clrar.Size = new System.Drawing.Size(76, 29);
            this.lbl_login_clrar.TabIndex = 2;
            this.lbl_login_clrar.Text = "Clear";
            // 
            // checkBox_login
            // 
            this.checkBox_login.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_login.ForeColor = System.Drawing.Color.Maroon;
            this.checkBox_login.Location = new System.Drawing.Point(179, 498);
            this.checkBox_login.Name = "checkBox_login";
            this.checkBox_login.Size = new System.Drawing.Size(237, 44);
            this.checkBox_login.TabIndex = 3;
            this.checkBox_login.Text = "Show Password";
            this.checkBox_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_login.UseVisualStyleBackColor = false;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.Blue;
            this.btn_login.Location = new System.Drawing.Point(76, 384);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(304, 68);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_login_password
            // 
            this.txt_login_password.BackColor = System.Drawing.Color.White;
            this.txt_login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_login_password.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_login_password.Location = new System.Drawing.Point(76, 294);
            this.txt_login_password.Name = "txt_login_password";
            this.txt_login_password.Size = new System.Drawing.Size(313, 36);
            this.txt_login_password.TabIndex = 2;
            this.txt_login_password.UseSystemPasswordChar = true;
            // 
            // txt_login_username
            // 
            this.txt_login_username.BackColor = System.Drawing.Color.White;
            this.txt_login_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_login_username.Location = new System.Drawing.Point(76, 154);
            this.txt_login_username.Name = "txt_login_username";
            this.txt_login_username.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_login_username.Size = new System.Drawing.Size(313, 36);
            this.txt_login_username.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(154, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIgn In";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1162, 706);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_login_clrar;
        private System.Windows.Forms.CheckBox checkBox_login;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_login_password;
        private System.Windows.Forms.TextBox txt_login_username;
        private System.Windows.Forms.Label label1;
    }
}