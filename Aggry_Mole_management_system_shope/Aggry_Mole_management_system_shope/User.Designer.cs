
namespace Aggry_Mole_management_system_shope
{
    partial class User
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cat_home = new System.Windows.Forms.Button();
            this.btn_cat_delete = new System.Windows.Forms.Button();
            this.btn_cat_edit = new System.Windows.Forms.Button();
            this.btn_cat_submit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_order_id = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UserGridview = new System.Windows.Forms.DataGridView();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_moile = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.agreemoleDataSet3 = new Aggry_Mole_management_system_shope.AgreemoleDataSet3();
            this.userTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTBTableAdapter = new Aggry_Mole_management_system_shope.AgreemoleDataSet3TableAdapters.UserTBTableAdapter();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uFullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agreemoleDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 137);
            this.panel1.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(469, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "User Management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(660, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "Aggry Mole Enterprize";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(1140, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 44);
            this.label2.TabIndex = 5;
            this.label2.Text = "X";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_cat_home
            // 
            this.btn_cat_home.BackColor = System.Drawing.Color.Blue;
            this.btn_cat_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cat_home.ForeColor = System.Drawing.Color.White;
            this.btn_cat_home.Location = new System.Drawing.Point(193, 616);
            this.btn_cat_home.Name = "btn_cat_home";
            this.btn_cat_home.Size = new System.Drawing.Size(134, 40);
            this.btn_cat_home.TabIndex = 26;
            this.btn_cat_home.Text = "Home";
            this.btn_cat_home.UseVisualStyleBackColor = false;
            this.btn_cat_home.Click += new System.EventHandler(this.btn_cat_home_Click);
            // 
            // btn_cat_delete
            // 
            this.btn_cat_delete.BackColor = System.Drawing.Color.Blue;
            this.btn_cat_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cat_delete.ForeColor = System.Drawing.Color.White;
            this.btn_cat_delete.Location = new System.Drawing.Point(360, 560);
            this.btn_cat_delete.Name = "btn_cat_delete";
            this.btn_cat_delete.Size = new System.Drawing.Size(133, 38);
            this.btn_cat_delete.TabIndex = 25;
            this.btn_cat_delete.Text = "Remove";
            this.btn_cat_delete.UseVisualStyleBackColor = false;
            this.btn_cat_delete.Click += new System.EventHandler(this.btn_cat_delete_Click);
            // 
            // btn_cat_edit
            // 
            this.btn_cat_edit.BackColor = System.Drawing.Color.Blue;
            this.btn_cat_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cat_edit.ForeColor = System.Drawing.Color.White;
            this.btn_cat_edit.Location = new System.Drawing.Point(193, 560);
            this.btn_cat_edit.Name = "btn_cat_edit";
            this.btn_cat_edit.Size = new System.Drawing.Size(134, 38);
            this.btn_cat_edit.TabIndex = 24;
            this.btn_cat_edit.Text = "Edit";
            this.btn_cat_edit.UseVisualStyleBackColor = false;
            this.btn_cat_edit.Click += new System.EventHandler(this.btn_cat_edit_Click);
            // 
            // btn_cat_submit
            // 
            this.btn_cat_submit.BackColor = System.Drawing.Color.Blue;
            this.btn_cat_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cat_submit.ForeColor = System.Drawing.Color.White;
            this.btn_cat_submit.Location = new System.Drawing.Point(49, 560);
            this.btn_cat_submit.Name = "btn_cat_submit";
            this.btn_cat_submit.Size = new System.Drawing.Size(114, 38);
            this.btn_cat_submit.TabIndex = 23;
            this.btn_cat_submit.Text = "Add";
            this.btn_cat_submit.UseVisualStyleBackColor = false;
            this.btn_cat_submit.Click += new System.EventHandler(this.btn_cat_submit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.YellowGreen;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(-3, 717);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1186, 36);
            this.panel2.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(123, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "TS Infotech";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Developed By :";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(12, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 36);
            this.label6.TabIndex = 54;
            this.label6.Text = "Mobile No";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(9, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 36);
            this.label5.TabIndex = 53;
            this.label5.Text = "Password";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(9, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 36);
            this.label4.TabIndex = 52;
            this.label4.Text = "Full Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_order_id
            // 
            this.lbl_order_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_order_id.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_id.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_order_id.Location = new System.Drawing.Point(9, 191);
            this.lbl_order_id.Name = "lbl_order_id";
            this.lbl_order_id.Size = new System.Drawing.Size(195, 36);
            this.lbl_order_id.TabIndex = 51;
            this.lbl_order_id.Text = "Username";
            this.lbl_order_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Brown;
            this.label7.Location = new System.Drawing.Point(764, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 38);
            this.label7.TabIndex = 47;
            this.label7.Text = "User List";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UserGridview
            // 
            this.UserGridview.AutoGenerateColumns = false;
            this.UserGridview.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.uFullnameDataGridViewTextBoxColumn,
            this.uPasswordDataGridViewTextBoxColumn,
            this.uMobileDataGridViewTextBoxColumn});
            this.UserGridview.DataSource = this.userTBBindingSource;
            this.UserGridview.GridColor = System.Drawing.Color.MediumBlue;
            this.UserGridview.Location = new System.Drawing.Point(466, 193);
            this.UserGridview.Name = "UserGridview";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserGridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.UserGridview.RowHeadersWidth = 51;
            this.UserGridview.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.UserGridview.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.UserGridview.RowTemplate.Height = 30;
            this.UserGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserGridview.Size = new System.Drawing.Size(702, 335);
            this.UserGridview.TabIndex = 50;
            // 
            // txt_fullname
            // 
            this.txt_fullname.BackColor = System.Drawing.Color.White;
            this.txt_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fullname.ForeColor = System.Drawing.Color.Blue;
            this.txt_fullname.Location = new System.Drawing.Point(213, 254);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_fullname.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_fullname.Size = new System.Drawing.Size(192, 36);
            this.txt_fullname.TabIndex = 49;
            this.txt_fullname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.White;
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.Color.Blue;
            this.txt_pass.Location = new System.Drawing.Point(213, 316);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_pass.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_pass.Size = new System.Drawing.Size(192, 36);
            this.txt_pass.TabIndex = 48;
            this.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_moile
            // 
            this.txt_moile.BackColor = System.Drawing.Color.White;
            this.txt_moile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_moile.ForeColor = System.Drawing.Color.Blue;
            this.txt_moile.Location = new System.Drawing.Point(213, 383);
            this.txt_moile.Name = "txt_moile";
            this.txt_moile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_moile.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_moile.Size = new System.Drawing.Size(192, 36);
            this.txt_moile.TabIndex = 46;
            this.txt_moile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.White;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.Blue;
            this.txt_username.Location = new System.Drawing.Point(213, 193);
            this.txt_username.Name = "txt_username";
            this.txt_username.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_username.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_username.Size = new System.Drawing.Size(192, 36);
            this.txt_username.TabIndex = 45;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // agreemoleDataSet3
            // 
            this.agreemoleDataSet3.DataSetName = "AgreemoleDataSet3";
            this.agreemoleDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTBBindingSource
            // 
            this.userTBBindingSource.DataMember = "UserTB";
            this.userTBBindingSource.DataSource = this.agreemoleDataSet3;
            // 
            // userTBTableAdapter
            // 
            this.userTBTableAdapter.ClearBeforeFill = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // uFullnameDataGridViewTextBoxColumn
            // 
            this.uFullnameDataGridViewTextBoxColumn.DataPropertyName = "UFullname";
            this.uFullnameDataGridViewTextBoxColumn.HeaderText = "UFullname";
            this.uFullnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uFullnameDataGridViewTextBoxColumn.Name = "uFullnameDataGridViewTextBoxColumn";
            this.uFullnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // uPasswordDataGridViewTextBoxColumn
            // 
            this.uPasswordDataGridViewTextBoxColumn.DataPropertyName = "UPassword";
            this.uPasswordDataGridViewTextBoxColumn.HeaderText = "UPassword";
            this.uPasswordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uPasswordDataGridViewTextBoxColumn.Name = "uPasswordDataGridViewTextBoxColumn";
            this.uPasswordDataGridViewTextBoxColumn.Width = 125;
            // 
            // uMobileDataGridViewTextBoxColumn
            // 
            this.uMobileDataGridViewTextBoxColumn.DataPropertyName = "UMobile";
            this.uMobileDataGridViewTextBoxColumn.HeaderText = "UMobile";
            this.uMobileDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uMobileDataGridViewTextBoxColumn.Name = "uMobileDataGridViewTextBoxColumn";
            this.uMobileDataGridViewTextBoxColumn.Width = 125;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 753);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_order_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UserGridview);
            this.Controls.Add(this.txt_fullname);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_moile);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_cat_home);
            this.Controls.Add(this.btn_cat_delete);
            this.Controls.Add(this.btn_cat_edit);
            this.Controls.Add(this.btn_cat_submit);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agreemoleDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cat_home;
        private System.Windows.Forms.Button btn_cat_delete;
        private System.Windows.Forms.Button btn_cat_edit;
        private System.Windows.Forms.Button btn_cat_submit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_order_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView UserGridview;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_moile;
        private System.Windows.Forms.TextBox txt_username;
        private AgreemoleDataSet3 agreemoleDataSet3;
        private System.Windows.Forms.BindingSource userTBBindingSource;
        private AgreemoleDataSet3TableAdapters.UserTBTableAdapter userTBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uFullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMobileDataGridViewTextBoxColumn;
    }
}