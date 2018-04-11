namespace BanMuBaoHiem
{
    partial class Form_main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.btn_product = new System.Windows.Forms.Button();
            this.btn_category_product = new System.Windows.Forms.Button();
            this.btn_employee = new System.Windows.Forms.Button();
            this.btn_search_form = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_search_form);
            this.panel1.Controls.Add(this.btn_employee);
            this.panel1.Controls.Add(this.btn_category_product);
            this.panel1.Controls.Add(this.btn_product);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 481);
            this.panel1.TabIndex = 0;
            // 
            // pnl_main
            // 
            this.pnl_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_main.Location = new System.Drawing.Point(218, 12);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(788, 481);
            this.pnl_main.TabIndex = 1;
            // 
            // btn_product
            // 
            this.btn_product.Location = new System.Drawing.Point(3, 33);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(194, 46);
            this.btn_product.TabIndex = 0;
            this.btn_product.Text = "Sản phẩm";
            this.btn_product.UseVisualStyleBackColor = true;
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // btn_category_product
            // 
            this.btn_category_product.Location = new System.Drawing.Point(3, 104);
            this.btn_category_product.Name = "btn_category_product";
            this.btn_category_product.Size = new System.Drawing.Size(194, 48);
            this.btn_category_product.TabIndex = 1;
            this.btn_category_product.Text = "Hãng sản phẩm";
            this.btn_category_product.UseVisualStyleBackColor = true;
            this.btn_category_product.Click += new System.EventHandler(this.btn_category_product_Click);
            // 
            // btn_employee
            // 
            this.btn_employee.Location = new System.Drawing.Point(3, 180);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Size = new System.Drawing.Size(194, 48);
            this.btn_employee.TabIndex = 2;
            this.btn_employee.Text = "Nhân viên";
            this.btn_employee.UseVisualStyleBackColor = true;
            this.btn_employee.Click += new System.EventHandler(this.btn_employee_Click);
            // 
            // btn_search_form
            // 
            this.btn_search_form.Location = new System.Drawing.Point(3, 257);
            this.btn_search_form.Name = "btn_search_form";
            this.btn_search_form.Size = new System.Drawing.Size(194, 45);
            this.btn_search_form.TabIndex = 3;
            this.btn_search_form.Text = "Tìm kiếm";
            this.btn_search_form.UseVisualStyleBackColor = true;
            this.btn_search_form.Click += new System.EventHandler(this.btn_search_form_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 505);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.panel1);
            this.Name = "Form_main";
            this.Text = "Bán mũ bảo hiểm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_search_form;
        private System.Windows.Forms.Button btn_employee;
        private System.Windows.Forms.Button btn_category_product;
        private System.Windows.Forms.Button btn_product;
        private System.Windows.Forms.Panel pnl_main;
    }
}

