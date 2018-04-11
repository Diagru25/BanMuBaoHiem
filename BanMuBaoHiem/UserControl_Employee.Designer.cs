namespace BanMuBaoHiem
{
    partial class UserControl_Employee
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
            this.btn_close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txb_emp_phone = new System.Windows.Forms.TextBox();
            this.txb_emp_address = new System.Windows.Forms.TextBox();
            this.txb_emp_name = new System.Windows.Forms.TextBox();
            this.txb_emp_code = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtp_emp_dob = new System.Windows.Forms.DateTimePicker();
            this.txb_emp_salary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(639, 152);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Đóng";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txb_emp_salary);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtp_emp_dob);
            this.panel1.Controls.Add(this.txb_emp_phone);
            this.panel1.Controls.Add(this.txb_emp_address);
            this.panel1.Controls.Add(this.txb_emp_name);
            this.panel1.Controls.Add(this.txb_emp_code);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.btn_insert);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 195);
            this.panel1.TabIndex = 3;
            // 
            // txb_emp_phone
            // 
            this.txb_emp_phone.Location = new System.Drawing.Point(363, 87);
            this.txb_emp_phone.Name = "txb_emp_phone";
            this.txb_emp_phone.Size = new System.Drawing.Size(164, 20);
            this.txb_emp_phone.TabIndex = 12;
            // 
            // txb_emp_address
            // 
            this.txb_emp_address.Location = new System.Drawing.Point(84, 88);
            this.txb_emp_address.Name = "txb_emp_address";
            this.txb_emp_address.Size = new System.Drawing.Size(164, 20);
            this.txb_emp_address.TabIndex = 11;
            // 
            // txb_emp_name
            // 
            this.txb_emp_name.Location = new System.Drawing.Point(363, 20);
            this.txb_emp_name.Name = "txb_emp_name";
            this.txb_emp_name.Size = new System.Drawing.Size(164, 20);
            this.txb_emp_name.TabIndex = 10;
            // 
            // txb_emp_code
            // 
            this.txb_emp_code.Enabled = false;
            this.txb_emp_code.Location = new System.Drawing.Point(84, 20);
            this.txb_emp_code.Name = "txb_emp_code";
            this.txb_emp_code.Size = new System.Drawing.Size(164, 20);
            this.txb_emp_code.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(557, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã nhân viên";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(461, 152);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(282, 152);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(782, 274);
            this.dataGridView1.TabIndex = 2;
            // 
            // dtp_emp_dob
            // 
            this.dtp_emp_dob.CustomFormat = "dd/MM/yyyy";
            this.dtp_emp_dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_emp_dob.Location = new System.Drawing.Point(618, 19);
            this.dtp_emp_dob.Name = "dtp_emp_dob";
            this.dtp_emp_dob.Size = new System.Drawing.Size(147, 20);
            this.dtp_emp_dob.TabIndex = 13;
            // 
            // txb_emp_salary
            // 
            this.txb_emp_salary.Location = new System.Drawing.Point(618, 87);
            this.txb_emp_salary.Name = "txb_emp_salary";
            this.txb_emp_salary.Size = new System.Drawing.Size(147, 20);
            this.txb_emp_salary.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(557, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Lương";
            // 
            // UserControl_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControl_Employee";
            this.Size = new System.Drawing.Size(788, 481);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txb_emp_salary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_emp_dob;
        private System.Windows.Forms.TextBox txb_emp_phone;
        private System.Windows.Forms.TextBox txb_emp_address;
        private System.Windows.Forms.TextBox txb_emp_name;
        private System.Windows.Forms.TextBox txb_emp_code;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
