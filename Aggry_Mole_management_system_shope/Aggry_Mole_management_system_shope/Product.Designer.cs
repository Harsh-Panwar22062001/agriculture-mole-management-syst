
namespace Aggry_Mole_management_system_shope
{
    partial class Product
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
            this.btn_cat_home = new System.Windows.Forms.Button();
            this.btn_cat_delete = new System.Windows.Forms.Button();
            this.btn_cat_edit = new System.Windows.Forms.Button();
            this.btn_cat_submit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_order_id = new System.Windows.Forms.Label();
            this.ProductGV = new System.Windows.Forms.DataGridView();
            this.CatCombo = new System.Windows.Forms.ComboBox();
            this.txt_product_description = new System.Windows.Forms.TextBox();
            this.txt_product_name = new System.Windows.Forms.TextBox();
            this.txt_product_qty = new System.Windows.Forms.TextBox();
            this.txt_product_price = new System.Windows.Forms.TextBox();
            this.txt_product_id = new System.Windows.Forms.TextBox();
            this.agreemoleDataSet = new Aggry_Mole_management_system_shope.AgreemoleDataSet();
            this.categoryTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTBTableAdapter = new Aggry_Mole_management_system_shope.AgreemoleDataSetTableAdapters.CategoryTBTableAdapter();
            this.agreemoleDataSet2 = new Aggry_Mole_management_system_shope.AgreemoleDataSet2();
            this.productTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTBTableAdapter = new Aggry_Mole_management_system_shope.AgreemoleDataSet2TableAdapters.ProductTBTableAdapter();
            this.prodIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodQTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodCAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agreemoleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agreemoleDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cat_home
            // 
            this.btn_cat_home.BackColor = System.Drawing.Color.Blue;
            this.btn_cat_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cat_home.ForeColor = System.Drawing.Color.White;
            this.btn_cat_home.Location = new System.Drawing.Point(194, 616);
            this.btn_cat_home.Name = "btn_cat_home";
            this.btn_cat_home.Size = new System.Drawing.Size(134, 40);
            this.btn_cat_home.TabIndex = 20;
            this.btn_cat_home.Text = "Home";
            this.btn_cat_home.UseVisualStyleBackColor = false;
            this.btn_cat_home.Click += new System.EventHandler(this.btn_cat_home_Click);
            // 
            // btn_cat_delete
            // 
            this.btn_cat_delete.BackColor = System.Drawing.Color.Blue;
            this.btn_cat_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cat_delete.ForeColor = System.Drawing.Color.White;
            this.btn_cat_delete.Location = new System.Drawing.Point(361, 560);
            this.btn_cat_delete.Name = "btn_cat_delete";
            this.btn_cat_delete.Size = new System.Drawing.Size(133, 38);
            this.btn_cat_delete.TabIndex = 19;
            this.btn_cat_delete.Text = "Remove";
            this.btn_cat_delete.UseVisualStyleBackColor = false;
            this.btn_cat_delete.Click += new System.EventHandler(this.btn_cat_delete_Click);
            // 
            // btn_cat_edit
            // 
            this.btn_cat_edit.BackColor = System.Drawing.Color.Blue;
            this.btn_cat_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cat_edit.ForeColor = System.Drawing.Color.White;
            this.btn_cat_edit.Location = new System.Drawing.Point(194, 560);
            this.btn_cat_edit.Name = "btn_cat_edit";
            this.btn_cat_edit.Size = new System.Drawing.Size(134, 38);
            this.btn_cat_edit.TabIndex = 18;
            this.btn_cat_edit.Text = "Edit";
            this.btn_cat_edit.UseVisualStyleBackColor = false;
            this.btn_cat_edit.Click += new System.EventHandler(this.btn_cat_edit_Click);
            // 
            // btn_cat_submit
            // 
            this.btn_cat_submit.BackColor = System.Drawing.Color.Blue;
            this.btn_cat_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cat_submit.ForeColor = System.Drawing.Color.White;
            this.btn_cat_submit.Location = new System.Drawing.Point(50, 560);
            this.btn_cat_submit.Name = "btn_cat_submit";
            this.btn_cat_submit.Size = new System.Drawing.Size(114, 38);
            this.btn_cat_submit.TabIndex = 17;
            this.btn_cat_submit.Text = "Submit";
            this.btn_cat_submit.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 137);
            this.panel1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(412, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Product Management";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.YellowGreen;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(-2, 717);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1186, 36);
            this.panel2.TabIndex = 15;
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
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(17, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 36);
            this.label7.TabIndex = 58;
            this.label7.Text = "Categories";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(17, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 36);
            this.label6.TabIndex = 57;
            this.label6.Text = "Description";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(17, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 36);
            this.label5.TabIndex = 56;
            this.label5.Text = "Price";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(17, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 36);
            this.label4.TabIndex = 55;
            this.label4.Text = "Quantity";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(17, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(234, 36);
            this.label10.TabIndex = 54;
            this.label10.Text = "Product Name";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_order_id
            // 
            this.lbl_order_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_order_id.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_id.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_order_id.Location = new System.Drawing.Point(17, 162);
            this.lbl_order_id.Name = "lbl_order_id";
            this.lbl_order_id.Size = new System.Drawing.Size(183, 36);
            this.lbl_order_id.TabIndex = 53;
            this.lbl_order_id.Text = "Product ID";
            this.lbl_order_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductGV
            // 
            this.ProductGV.AutoGenerateColumns = false;
            this.ProductGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodIDDataGridViewTextBoxColumn,
            this.prodNAMEDataGridViewTextBoxColumn,
            this.prodQTYDataGridViewTextBoxColumn,
            this.prodPriceDataGridViewTextBoxColumn,
            this.prodDescDataGridViewTextBoxColumn,
            this.prodCAtDataGridViewTextBoxColumn});
            this.ProductGV.DataSource = this.productTBBindingSource;
            this.ProductGV.GridColor = System.Drawing.Color.PeachPuff;
            this.ProductGV.Location = new System.Drawing.Point(533, 162);
            this.ProductGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductGV.Name = "ProductGV";
            this.ProductGV.RowHeadersWidth = 51;
            this.ProductGV.RowTemplate.Height = 24;
            this.ProductGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductGV.Size = new System.Drawing.Size(630, 422);
            this.ProductGV.TabIndex = 46;
            this.ProductGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGV_CellContentClick);
            // 
            // CatCombo
            // 
            this.CatCombo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoryTBBindingSource, "CatName", true));
            this.CatCombo.DataSource = this.categoryTBBindingSource;
            this.CatCombo.DisplayMember = "CatName";
            this.CatCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatCombo.FormattingEnabled = true;
            this.CatCombo.Location = new System.Drawing.Point(304, 452);
            this.CatCombo.Name = "CatCombo";
            this.CatCombo.Size = new System.Drawing.Size(190, 37);
            this.CatCombo.TabIndex = 52;
            this.CatCombo.ValueMember = "CatName";
            // 
            // txt_product_description
            // 
            this.txt_product_description.BackColor = System.Drawing.Color.White;
            this.txt_product_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_description.ForeColor = System.Drawing.Color.Blue;
            this.txt_product_description.Location = new System.Drawing.Point(304, 386);
            this.txt_product_description.Name = "txt_product_description";
            this.txt_product_description.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_product_description.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_product_description.Size = new System.Drawing.Size(190, 36);
            this.txt_product_description.TabIndex = 51;
            this.txt_product_description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_product_name
            // 
            this.txt_product_name.BackColor = System.Drawing.Color.White;
            this.txt_product_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_name.ForeColor = System.Drawing.Color.Blue;
            this.txt_product_name.Location = new System.Drawing.Point(304, 222);
            this.txt_product_name.Name = "txt_product_name";
            this.txt_product_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_product_name.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_product_name.Size = new System.Drawing.Size(190, 36);
            this.txt_product_name.TabIndex = 50;
            this.txt_product_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_product_qty
            // 
            this.txt_product_qty.BackColor = System.Drawing.Color.White;
            this.txt_product_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_qty.ForeColor = System.Drawing.Color.Blue;
            this.txt_product_qty.Location = new System.Drawing.Point(304, 279);
            this.txt_product_qty.Name = "txt_product_qty";
            this.txt_product_qty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_product_qty.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_product_qty.Size = new System.Drawing.Size(190, 36);
            this.txt_product_qty.TabIndex = 49;
            this.txt_product_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_product_price
            // 
            this.txt_product_price.BackColor = System.Drawing.Color.White;
            this.txt_product_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_price.ForeColor = System.Drawing.Color.Blue;
            this.txt_product_price.Location = new System.Drawing.Point(304, 337);
            this.txt_product_price.Name = "txt_product_price";
            this.txt_product_price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_product_price.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_product_price.Size = new System.Drawing.Size(190, 36);
            this.txt_product_price.TabIndex = 48;
            this.txt_product_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_product_id
            // 
            this.txt_product_id.BackColor = System.Drawing.Color.White;
            this.txt_product_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_id.ForeColor = System.Drawing.Color.Blue;
            this.txt_product_id.Location = new System.Drawing.Point(304, 164);
            this.txt_product_id.Name = "txt_product_id";
            this.txt_product_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_product_id.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_product_id.Size = new System.Drawing.Size(190, 36);
            this.txt_product_id.TabIndex = 47;
            this.txt_product_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // agreemoleDataSet
            // 
            this.agreemoleDataSet.DataSetName = "AgreemoleDataSet";
            this.agreemoleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryTBBindingSource
            // 
            this.categoryTBBindingSource.DataMember = "CategoryTB";
            this.categoryTBBindingSource.DataSource = this.agreemoleDataSet;
            // 
            // categoryTBTableAdapter
            // 
            this.categoryTBTableAdapter.ClearBeforeFill = true;
            // 
            // agreemoleDataSet2
            // 
            this.agreemoleDataSet2.DataSetName = "AgreemoleDataSet2";
            this.agreemoleDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTBBindingSource
            // 
            this.productTBBindingSource.DataMember = "ProductTB";
            this.productTBBindingSource.DataSource = this.agreemoleDataSet2;
            // 
            // productTBTableAdapter
            // 
            this.productTBTableAdapter.ClearBeforeFill = true;
            // 
            // prodIDDataGridViewTextBoxColumn
            // 
            this.prodIDDataGridViewTextBoxColumn.DataPropertyName = "ProdID";
            this.prodIDDataGridViewTextBoxColumn.HeaderText = "ProdID";
            this.prodIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodIDDataGridViewTextBoxColumn.Name = "prodIDDataGridViewTextBoxColumn";
            this.prodIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // prodNAMEDataGridViewTextBoxColumn
            // 
            this.prodNAMEDataGridViewTextBoxColumn.DataPropertyName = "Prod_NAME";
            this.prodNAMEDataGridViewTextBoxColumn.HeaderText = "Prod_NAME";
            this.prodNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodNAMEDataGridViewTextBoxColumn.Name = "prodNAMEDataGridViewTextBoxColumn";
            this.prodNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // prodQTYDataGridViewTextBoxColumn
            // 
            this.prodQTYDataGridViewTextBoxColumn.DataPropertyName = "ProdQTY";
            this.prodQTYDataGridViewTextBoxColumn.HeaderText = "ProdQTY";
            this.prodQTYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodQTYDataGridViewTextBoxColumn.Name = "prodQTYDataGridViewTextBoxColumn";
            this.prodQTYDataGridViewTextBoxColumn.Width = 125;
            // 
            // prodPriceDataGridViewTextBoxColumn
            // 
            this.prodPriceDataGridViewTextBoxColumn.DataPropertyName = "Prod_Price";
            this.prodPriceDataGridViewTextBoxColumn.HeaderText = "Prod_Price";
            this.prodPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodPriceDataGridViewTextBoxColumn.Name = "prodPriceDataGridViewTextBoxColumn";
            this.prodPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // prodDescDataGridViewTextBoxColumn
            // 
            this.prodDescDataGridViewTextBoxColumn.DataPropertyName = "Prod_Desc";
            this.prodDescDataGridViewTextBoxColumn.HeaderText = "Prod_Desc";
            this.prodDescDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodDescDataGridViewTextBoxColumn.Name = "prodDescDataGridViewTextBoxColumn";
            this.prodDescDataGridViewTextBoxColumn.Width = 125;
            // 
            // prodCAtDataGridViewTextBoxColumn
            // 
            this.prodCAtDataGridViewTextBoxColumn.DataPropertyName = "Prod_CAt";
            this.prodCAtDataGridViewTextBoxColumn.HeaderText = "Prod_CAt";
            this.prodCAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodCAtDataGridViewTextBoxColumn.Name = "prodCAtDataGridViewTextBoxColumn";
            this.prodCAtDataGridViewTextBoxColumn.Width = 125;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_order_id);
            this.Controls.Add(this.ProductGV);
            this.Controls.Add(this.CatCombo);
            this.Controls.Add(this.txt_product_description);
            this.Controls.Add(this.txt_product_name);
            this.Controls.Add(this.txt_product_qty);
            this.Controls.Add(this.txt_product_price);
            this.Controls.Add(this.txt_product_id);
            this.Controls.Add(this.btn_cat_home);
            this.Controls.Add(this.btn_cat_delete);
            this.Controls.Add(this.btn_cat_edit);
            this.Controls.Add(this.btn_cat_submit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agreemoleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agreemoleDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cat_home;
        private System.Windows.Forms.Button btn_cat_delete;
        private System.Windows.Forms.Button btn_cat_edit;
        private System.Windows.Forms.Button btn_cat_submit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_order_id;
        private System.Windows.Forms.DataGridView ProductGV;
        private System.Windows.Forms.ComboBox CatCombo;
        private System.Windows.Forms.TextBox txt_product_description;
        private System.Windows.Forms.TextBox txt_product_name;
        private System.Windows.Forms.TextBox txt_product_qty;
        private System.Windows.Forms.TextBox txt_product_price;
        private System.Windows.Forms.TextBox txt_product_id;
        private AgreemoleDataSet agreemoleDataSet;
        private System.Windows.Forms.BindingSource categoryTBBindingSource;
        private AgreemoleDataSetTableAdapters.CategoryTBTableAdapter categoryTBTableAdapter;
        private AgreemoleDataSet2 agreemoleDataSet2;
        private System.Windows.Forms.BindingSource productTBBindingSource;
        private AgreemoleDataSet2TableAdapters.ProductTBTableAdapter productTBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodQTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodCAtDataGridViewTextBoxColumn;
    }
}