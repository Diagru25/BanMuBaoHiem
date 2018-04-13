using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanMuBaoHiem.DAO;
using BanMuBaoHiem.EF;

namespace BanMuBaoHiem
{
    public partial class UserControl_Employee : UserControl
    {
        BindingSource list = new BindingSource();
        public UserControl_Employee()
        {
            InitializeComponent();
            dgr_emp.DataSource = list;
            LoadAll();
            AddEmployeeBinding();
        }

        void LoadAll()
        {
            LoadEmp();
        }
        void LoadEmp()
        {
            list.DataSource = new EmployeeDAO().ListAll();
        }
        void clear()
        {
            txb_emp_address.Clear();
            txb_emp_code.Clear();
            txb_emp_name.Clear();
            txb_emp_phone.Clear();
            txb_emp_salary.Clear();
            txb_workingday.Clear();
            txb_workinghours.Clear();
            dtp_emp_dob.Value = DateTime.Today;
        }
        void AddEmployeeBinding()
        {
            txb_emp_code.DataBindings.Add("Text", dgr_emp.DataSource, "ID", true, DataSourceUpdateMode.Never);
            txb_emp_name.DataBindings.Add("Text", dgr_emp.DataSource, "Name", true, DataSourceUpdateMode.Never);
            txb_emp_address.DataBindings.Add("Text", dgr_emp.DataSource, "Address", true, DataSourceUpdateMode.Never);
            txb_emp_phone.DataBindings.Add("Text", dgr_emp.DataSource, "PhoneNumber", true, DataSourceUpdateMode.Never);
            txb_emp_salary.DataBindings.Add("Text", dgr_emp.DataSource, "Salary", true, DataSourceUpdateMode.Never);
            txb_workingday.DataBindings.Add("Text", dgr_emp.DataSource, "WorkingDay", true, DataSourceUpdateMode.Never);
            txb_workinghours.DataBindings.Add("Text", dgr_emp.DataSource, "WorkingHours", true, DataSourceUpdateMode.Never);
            dtp_emp_dob.DataBindings.Add("Value", dgr_emp.DataSource, "DateOfBirth", true, DataSourceUpdateMode.Never);
            cbo_sex.DataBindings.Add("Text", dgr_emp.DataSource, "Sex", true, DataSourceUpdateMode.Never);
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                // tạo nhân viên tạm
                Employee item = new Employee();
                item.Address = txb_emp_address.Text;
                item.DateOfBirth = dtp_emp_dob.Value;
                item.Name = txb_emp_name.Text;
                item.PhoneNumber = txb_emp_phone.Text;
                item.Sex = cbo_sex.SelectedItem.ToString();

                long emp_id = new EmployeeDAO().Insert(item);

                // tạo đối tượng salary tạm
                Salary item_s = new Salary();
                item_s.EmpID = emp_id;
                item_s.salary = Convert.ToDecimal(txb_emp_salary.Text);
                item_s.WorkingDay = Convert.ToInt32(txb_workingday.Text);
                item_s.WorkingHours = Convert.ToInt32(txb_workinghours.Text);

                bool result = new SalaryDAO().Insert(item_s);

                if (result == true)
                {
                    MessageBox.Show("Thêm nhân viên thành công");
                    LoadEmp();
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình thêm");
                    new EmployeeDAO().Delete(emp_id);
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình thêm");
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                // tạo 1 nhân viên tạm
                Employee item = new Employee();
                item.ID = Convert.ToInt32(txb_emp_code.Text);
                item.Address = txb_emp_address.Text;
                item.DateOfBirth = dtp_emp_dob.Value;
                item.Name = txb_emp_name.Text;
                item.PhoneNumber = txb_emp_phone.Text;
                item.Sex = cbo_sex.SelectedItem.ToString();

                //tạo 1 biến tạm của bảng salary
                Salary item_s = new Salary();
                item_s.EmpID = Convert.ToInt32(txb_emp_code.Text);
                item_s.salary = Convert.ToDecimal(txb_emp_salary.Text);
                item_s.WorkingDay = Convert.ToInt32(txb_workingday.Text);
                item_s.WorkingHours = Convert.ToInt32(txb_workinghours.Text);


                bool result = new EmployeeDAO().Update(item);
                bool result_s = new SalaryDAO().Update(item_s);

                if (result == true && result_s == true)
                {
                    MessageBox.Show("Sửa nhân viên thành công");
                    LoadEmp();
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình Sửa");
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình Sửa");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này ?", "Thông báo", MessageBoxButtons.YesNo);

            if(r==DialogResult.Yes)
            {
                long id = Convert.ToInt32(txb_emp_code.Text);

                bool result_s = new SalaryDAO().Delete(id);
                bool result = new EmployeeDAO().Delete(id);

                if(result == true && result_s == true)
                {
                    MessageBox.Show("Xóa nhân viên thành công");
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình xóa");
                }
            }
            LoadEmp();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
