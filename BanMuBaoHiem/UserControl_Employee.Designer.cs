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
            this.btn_clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txb_workinghours = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbo_sex = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_workingday = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_emp_salary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_emp_dob = new System.Windows.Forms.DateTimePicker();
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
            this.dgr_emp = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkingDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkingHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_emp)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(639, 152);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "Làm mới";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txb_workinghours);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbo_sex);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txb_workingday);
            this.panel1.Controls.Add(this.label7);
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
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.btn_insert);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 195);
            this.panel1.TabIndex = 3;
            // 
            // txb_workinghours
            // 
            this.txb_workinghours.Location = new System.Drawing.Point(618, 103);
            this.txb_workinghours.Name = "txb_workinghours";
            this.txb_workinghours.Size = new System.Drawing.Size(147, 20);
            this.txb_workinghours.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(557, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Số giờ làm";
            // 
            // cbo_sex
            // 
            this.cbo_sex.FormattingEnabled = true;
            this.cbo_sex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbo_sex.Location = new System.Drawing.Point(618, 65);
            this.cbo_sex.Name = "cbo_sex";
            this.cbo_sex.Size = new System.Drawing.Size(147, 21);
            this.cbo_sex.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(557, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Giới tính";
            // 
            // txb_workingday
            // 
            this.txb_workingday.Location = new System.Drawing.Point(363, 107);
            this.txb_workingday.Name = "txb_workingday";
            this.txb_workingday.Size = new System.Drawing.Size(164, 20);
            this.txb_workingday.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Số ngày làm";
            // 
            // txb_emp_salary
            // 
            this.txb_emp_salary.Location = new System.Drawing.Point(84, 107);
            this.txb_emp_salary.Name = "txb_emp_salary";
            this.txb_emp_salary.Size = new System.Drawing.Size(164, 20);
            this.txb_emp_salary.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Lương";
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
            // txb_emp_phone
            // 
            this.txb_emp_phone.Location = new System.Drawing.Point(363, 65);
            this.txb_emp_phone.Name = "txb_emp_phone";
            this.txb_emp_phone.Size = new System.Drawing.Size(164, 20);
            this.txb_emp_phone.TabIndex = 12;
            // 
            // txb_emp_address
            // 
            this.txb_emp_address.Location = new System.Drawing.Point(84, 66);
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
            this.label3.Location = new System.Drawing.Point(282, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 69);
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
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(282, 152);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(84, 152);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 0;
            this.btn_insert.Text = "Thêm";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // dgr_emp
            // 
            this.dgr_emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_emp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Address,
            this.DateOfBirth,
            this.Phone,
            this.Sex,
            this.Salary,
            this.WorkingDay,
            this.WorkingHours});
            this.dgr_emp.Location = new System.Drawing.Point(3, 204);
            this.dgr_emp.Name = "dgr_emp";
            this.dgr_emp.Size = new System.Drawing.Size(782, 274);
            this.dgr_emp.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Họ Tên";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Địa chỉ";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateOfBirth.DataPropertyName = "DateOfBirth";
            this.DateOfBirth.HeaderText = "Ngày sinh";
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phone.DataPropertyName = "PhoneNumber";
            this.Phone.HeaderText = "Số điện thoại";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Sex
            // 
            this.Sex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sex.DataPropertyName = "Sex";
            this.Sex.HeaderText = "Giới tính";
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "lương";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // WorkingDay
            // 
            this.WorkingDay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WorkingDay.DataPropertyName = "WorkingDay";
            this.WorkingDay.HeaderText = "Số ngày làm";
            this.WorkingDay.Name = "WorkingDay";
            this.WorkingDay.ReadOnly = true;
            // 
            // WorkingHours
            // 
            this.WorkingHours.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WorkingHours.DataPropertyName = "WorkingHours";
            this.WorkingHours.HeaderText = "Số giờ làm";
            this.WorkingHours.Name = "WorkingHours";
            this.WorkingHours.ReadOnly = true;
            // 
            // UserControl_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgr_emp);
            this.Name.Name = "UserControl_Employee";
            this.Size = new System.Drawing.Size(788, 481);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_emp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_clear;
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
        private System.Windows.Forms.DataGridView dgr_emp;
        private System.Windows.Forms.ComboBox cbo_sex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb_workingday;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_workinghours;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkingDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkingHours;
    }
}
