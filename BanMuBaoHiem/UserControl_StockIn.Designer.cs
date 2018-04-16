namespace BanMuBaoHiem
{
    partial class UserControl_StockIn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtg_stockin = new System.Windows.Forms.DataGridView();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_si_code = new System.Windows.Forms.TextBox();
            this.txb_pro_id = new System.Windows.Forms.TextBox();
            this.txb_pro_quantity = new System.Windows.Forms.TextBox();
            this.dtp_pro_date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_pro_up = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_lammoi_stockin = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_pro_name = new System.Windows.Forms.ComboBox();
            this.txb_pro_brand = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_stockin)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_stockin
            // 
            this.dtg_stockin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_stockin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Prod_id,
            this.Prod_name,
            this.Brand,
            this.Quantity,
            this.Unit_price,
            this.date_col});
            this.dtg_stockin.Location = new System.Drawing.Point(3, 204);
            this.dtg_stockin.Name = "dtg_stockin";
            this.dtg_stockin.Size = new System.Drawing.Size(782, 274);
            this.dtg_stockin.TabIndex = 0;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(84, 152);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 0;
            this.btn_insert.Text = "Thêm";
            this.btn_insert.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(240, 152);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(410, 152);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(656, 152);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(96, 23);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "Tạo báo cáo";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã nhập kho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã Sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hãng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(557, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày nhập";
            // 
            // txb_si_code
            // 
            this.txb_si_code.Enabled = false;
            this.txb_si_code.Location = new System.Drawing.Point(84, 20);
            this.txb_si_code.Name = "txb_si_code";
            this.txb_si_code.ReadOnly = true;
            this.txb_si_code.Size = new System.Drawing.Size(164, 20);
            this.txb_si_code.TabIndex = 9;
            // 
            // txb_pro_id
            // 
            this.txb_pro_id.Location = new System.Drawing.Point(84, 66);
            this.txb_pro_id.Name = "txb_pro_id";
            this.txb_pro_id.ReadOnly = true;
            this.txb_pro_id.Size = new System.Drawing.Size(164, 20);
            this.txb_pro_id.TabIndex = 11;
            // 
            // txb_pro_quantity
            // 
            this.txb_pro_quantity.Location = new System.Drawing.Point(363, 65);
            this.txb_pro_quantity.Name = "txb_pro_quantity";
            this.txb_pro_quantity.Size = new System.Drawing.Size(164, 20);
            this.txb_pro_quantity.TabIndex = 12;
            // 
            // dtp_pro_date
            // 
            this.dtp_pro_date.CustomFormat = "dd/MM/yyyy";
            this.dtp_pro_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_pro_date.Location = new System.Drawing.Point(618, 19);
            this.dtp_pro_date.Name = "dtp_pro_date";
            this.dtp_pro_date.Size = new System.Drawing.Size(147, 20);
            this.dtp_pro_date.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tên sản phẩm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Đơn giá";
            // 
            // txb_pro_up
            // 
            this.txb_pro_up.Location = new System.Drawing.Point(363, 107);
            this.txb_pro_up.Name = "txb_pro_up";
            this.txb_pro_up.Size = new System.Drawing.Size(164, 20);
            this.txb_pro_up.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txb_pro_brand);
            this.panel1.Controls.Add(this.cb_pro_name);
            this.panel1.Controls.Add(this.btn_lammoi_stockin);
            this.panel1.Controls.Add(this.txb_pro_up);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtp_pro_date);
            this.panel1.Controls.Add(this.txb_pro_quantity);
            this.panel1.Controls.Add(this.txb_pro_id);
            this.panel1.Controls.Add(this.txb_si_code);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.btn_insert);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 195);
            this.panel1.TabIndex = 4;
            // 
            // btn_lammoi_stockin
            // 
            this.btn_lammoi_stockin.Location = new System.Drawing.Point(541, 152);
            this.btn_lammoi_stockin.Name = "btn_lammoi_stockin";
            this.btn_lammoi_stockin.Size = new System.Drawing.Size(75, 23);
            this.btn_lammoi_stockin.TabIndex = 18;
            this.btn_lammoi_stockin.Text = "Làm mới";
            this.btn_lammoi_stockin.UseVisualStyleBackColor = true;
            this.btn_lammoi_stockin.Click += new System.EventHandler(this.btn_lammoi_stockin_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã nhập kho";
            this.ID.Name = "ID";
            // 
            // Prod_id
            // 
            this.Prod_id.DataPropertyName = "ProdID";
            this.Prod_id.HeaderText = "Mã sản phẩm";
            this.Prod_id.Name = "Prod_id";
            // 
            // Prod_name
            // 
            this.Prod_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prod_name.DataPropertyName = "ProdName";
            this.Prod_name.HeaderText = "Tên sản phẩm";
            this.Prod_name.Name = "Prod_name";
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "BrandName";
            this.Brand.HeaderText = "Hãng";
            this.Brand.Name = "Brand";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.Name = "Quantity";
            // 
            // Unit_price
            // 
            this.Unit_price.DataPropertyName = "UnitPrice";
            this.Unit_price.HeaderText = "Đơn giá";
            this.Unit_price.Name = "Unit_price";
            // 
            // date_col
            // 
            this.date_col.DataPropertyName = "date";
            this.date_col.HeaderText = "Ngày nhập";
            this.date_col.Name = "date_col";
            // 
            // cb_pro_name
            // 
            this.cb_pro_name.FormattingEnabled = true;
            this.cb_pro_name.Location = new System.Drawing.Point(88, 106);
            this.cb_pro_name.Name = "cb_pro_name";
            this.cb_pro_name.Size = new System.Drawing.Size(160, 21);
            this.cb_pro_name.TabIndex = 20;
            // 
            // txb_pro_brand
            // 
            this.txb_pro_brand.Location = new System.Drawing.Point(363, 20);
            this.txb_pro_brand.Name = "txb_pro_brand";
            this.txb_pro_brand.Size = new System.Drawing.Size(164, 20);
            this.txb_pro_brand.TabIndex = 21;
            // 
            // UserControl_StockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtg_stockin);
            this.Name = "UserControl_StockIn";
            this.Size = new System.Drawing.Size(788, 481);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_stockin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_stockin;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_si_code;
        private System.Windows.Forms.TextBox txb_pro_id;
        private System.Windows.Forms.TextBox txb_pro_quantity;
        private System.Windows.Forms.DateTimePicker dtp_pro_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_pro_up;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_lammoi_stockin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_col;
        private System.Windows.Forms.ComboBox cb_pro_name;
        private System.Windows.Forms.TextBox txb_pro_brand;
    }
}
