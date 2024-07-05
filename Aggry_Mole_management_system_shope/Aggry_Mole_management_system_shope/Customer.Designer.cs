
namespace Aggry_Mole_management_system_shope
{
    partial class Customer
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.customer_list = new System.Windows.Forms.Label();
            this.CustomerGv = new System.Windows.Forms.DataGridView();
            this.txt_customer_mobile = new System.Windows.Forms.TextBox();
            this.txt_Customer_name = new System.Windows.Forms.TextBox();
            this.txt_customer_id = new System.Windows.Forms.TextBox();
            this.agreemoleDataSet = new Aggry_Mole_management_system_shope.AgreemoleDataSet();
            this.agreemoleDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agreemoleDataSet1 = new Aggry_Mole_management_system_shope.AgreemoleDataSet1();
            this.customerTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTBTableAdapter = new Aggry_Mole_management_system_shope.AgreemoleDataSet1TableAdapters.CustomerTBTableAdapter();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerMobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agreemoleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agreemoleDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agreemoleDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-17, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 137);
            this.panel1.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(412, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Customer Management";
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
            // 
            // btn_cat_home
            // 
            this.btn_cat_home.BackColor = System.Drawing.Color.Blue;
            this.btn_cat_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cat_home.ForeColor = System.Drawing.Color.White;
            this.btn_cat_home.Location = new System.Drawing.Point(179, 616);
            this.btn_cat_home.Name = "btn_cat_home";
            this.btn_cat_home.Size = new System.Drawing.Size(134, 40);
            this.btn_cat_home.TabIndex = 52;
            this.btn_cat_home.Text = "Home";
            this.btn_cat_home.UseVisualStyleBackColor = false;
            this.btn_cat_home.Click += new System.EventHandler(this.btn_cat_home_Click);
            // 
            // btn_cat_delete
            // 
            this.btn_cat_delete.BackColor = System.Drawing.Color.Blue;
            this.btn_cat_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cat_delete.ForeColor = System.Drawing.Color.White;
            this.btn_cat_delete.Location = new System.Drawing.Point(346, 560);
            this.btn_cat_delete.Name = "btn_cat_delete";
            this.btn_cat_delete.Size = new System.Drawing.Size(133, 38);
            this.btn_cat_delete.TabIndex = 51;
            this.btn_cat_delete.Text = "Remove";
            this.btn_cat_delete.UseVisualStyleBackColor = false;
            this.btn_cat_delete.Click += new System.EventHandler(this.btn_cat_delete_Click);
            // 
            // btn_cat_edit
            // 
            this.btn_cat_edit.BackColor = System.Drawing.Color.Blue;
            this.btn_cat_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cat_edit.ForeColor = System.Drawing.Color.White;
            this.btn_cat_edit.Location = new System.Drawing.Point(179, 560);
            this.btn_cat_edit.Name = "btn_cat_edit";
            this.btn_cat_edit.Size = new System.Drawing.Size(134, 38);
            this.btn_cat_edit.TabIndex = 50;
            this.btn_cat_edit.Text = "Edit";
            this.btn_cat_edit.UseVisualStyleBackColor = false;
            this.btn_cat_edit.Click += new System.EventHandler(this.btn_cat_edit_Click);
            // 
            // btn_cat_submit
            // 
            this.btn_cat_submit.BackColor = System.Drawing.Color.Blue;
            this.btn_cat_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cat_submit.ForeColor = System.Drawing.Color.White;
            this.btn_cat_submit.Location = new System.Drawing.Point(35, 560);
            this.btn_cat_submit.Name = "btn_cat_submit";
            this.btn_cat_submit.Size = new System.Drawing.Size(114, 38);
            this.btn_cat_submit.TabIndex = 49;
            this.btn_cat_submit.Text = "Submit";
            this.btn_cat_submit.UseVisualStyleBackColor = false;
            this.btn_cat_submit.Click += new System.EventHandler(this.btn_cat_submit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.YellowGreen;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(-17, 717);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1186, 36);
            this.panel2.TabIndex = 47;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Khaki;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(12, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 38);
            this.label4.TabIndex = 60;
            this.label4.Text = "Mobile Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Khaki;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(12, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 38);
            this.label5.TabIndex = 59;
            this.label5.Text = "Customer ID";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Khaki;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(12, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 38);
            this.label6.TabIndex = 58;
            this.label6.Text = "Customer Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // customer_list
            // 
            this.customer_list.AutoSize = true;
            this.customer_list.BackColor = System.Drawing.Color.Khaki;
            this.customer_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_list.ForeColor = System.Drawing.Color.Brown;
            this.customer_list.Location = new System.Drawing.Point(719, 161);
            this.customer_list.Name = "customer_list";
            this.customer_list.Size = new System.Drawing.Size(291, 48);
            this.customer_list.TabIndex = 57;
            this.customer_list.Text = "Customer List";
            this.customer_list.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CustomerGv
            // 
            this.CustomerGv.AutoGenerateColumns = false;
            this.CustomerGv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomerGv.ColumnHeadersHeight = 29;
            this.CustomerGv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIdDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.customerMobileDataGridViewTextBoxColumn});
            this.CustomerGv.DataSource = this.customerTBBindingSource;
            this.CustomerGv.GridColor = System.Drawing.Color.PeachPuff;
            this.CustomerGv.Location = new System.Drawing.Point(509, 232);
            this.CustomerGv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerGv.Name = "CustomerGv";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerGv.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CustomerGv.RowHeadersWidth = 51;
            this.CustomerGv.RowTemplate.Height = 24;
            this.CustomerGv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerGv.Size = new System.Drawing.Size(632, 323);
            this.CustomerGv.TabIndex = 56;
            // 
            // txt_customer_mobile
            // 
            this.txt_customer_mobile.BackColor = System.Drawing.Color.White;
            this.txt_customer_mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customer_mobile.ForeColor = System.Drawing.Color.Blue;
            this.txt_customer_mobile.Location = new System.Drawing.Point(288, 404);
            this.txt_customer_mobile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_customer_mobile.Name = "txt_customer_mobile";
            this.txt_customer_mobile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_customer_mobile.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_customer_mobile.Size = new System.Drawing.Size(202, 36);
            this.txt_customer_mobile.TabIndex = 55;
            this.txt_customer_mobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Customer_name
            // 
            this.txt_Customer_name.BackColor = System.Drawing.Color.White;
            this.txt_Customer_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Customer_name.ForeColor = System.Drawing.Color.Blue;
            this.txt_Customer_name.Location = new System.Drawing.Point(288, 312);
            this.txt_Customer_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Customer_name.Name = "txt_Customer_name";
            this.txt_Customer_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Customer_name.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_Customer_name.Size = new System.Drawing.Size(202, 36);
            this.txt_Customer_name.TabIndex = 54;
            this.txt_Customer_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_customer_id
            // 
            this.txt_customer_id.BackColor = System.Drawing.Color.White;
            this.txt_customer_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customer_id.ForeColor = System.Drawing.Color.Blue;
            this.txt_customer_id.Location = new System.Drawing.Point(288, 232);
            this.txt_customer_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_customer_id.Name = "txt_customer_id";
            this.txt_customer_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_customer_id.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_customer_id.Size = new System.Drawing.Size(202, 36);
            this.txt_customer_id.TabIndex = 53;
            this.txt_customer_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // agreemoleDataSet
            // 
            this.agreemoleDataSet.DataSetName = "AgreemoleDataSet";
            this.agreemoleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agreemoleDataSetBindingSource
            // 
            this.agreemoleDataSetBindingSource.DataSource = this.agreemoleDataSet;
            this.agreemoleDataSetBindingSource.Position = 0;
            // 
            // agreemoleDataSet1
            // 
            this.agreemoleDataSet1.DataSetName = "AgreemoleDataSet1";
            this.agreemoleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTBBindingSource
            // 
            this.customerTBBindingSource.DataMember = "CustomerTB";
            this.customerTBBindingSource.DataSource = this.agreemoleDataSet1;
            // 
            // customerTBTableAdapter
            // 
            this.customerTBTableAdapter.ClearBeforeFill = true;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerMobileDataGridViewTextBoxColumn
            // 
            this.customerMobileDataGridViewTextBoxColumn.DataPropertyName = "CustomerMobile";
            this.customerMobileDataGridViewTextBoxColumn.HeaderText = "CustomerMobile";
            this.customerMobileDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerMobileDataGridViewTextBoxColumn.Name = "customerMobileDataGridViewTextBoxColumn";
            this.customerMobileDataGridViewTextBoxColumn.Width = 125;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 753);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.customer_list);
            this.Controls.Add(this.CustomerGv);
            this.Controls.Add(this.txt_customer_mobile);
            this.Controls.Add(this.txt_Customer_name);
            this.Controls.Add(this.txt_customer_id);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_cat_home);
            this.Controls.Add(this.btn_cat_delete);
            this.Controls.Add(this.btn_cat_edit);
            this.Controls.Add(this.btn_cat_submit);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agreemoleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agreemoleDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agreemoleDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTBBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label customer_list;
        private System.Windows.Forms.DataGridView CustomerGv;
        private System.Windows.Forms.TextBox txt_customer_mobile;
        private System.Windows.Forms.TextBox txt_Customer_name;
        private System.Windows.Forms.TextBox txt_customer_id;
        private System.Windows.Forms.BindingSource agreemoleDataSetBindingSource;
        private AgreemoleDataSet agreemoleDataSet;
        private AgreemoleDataSet1 agreemoleDataSet1;
        private System.Windows.Forms.BindingSource customerTBBindingSource;
        private AgreemoleDataSet1TableAdapters.CustomerTBTableAdapter customerTBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerMobileDataGridViewTextBoxColumn;
    }
}