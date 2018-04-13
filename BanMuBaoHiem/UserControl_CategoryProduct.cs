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
    public partial class UserControl_CategoryProduct : UserControl
    {
        BindingSource list = new BindingSource();
        public UserControl_CategoryProduct()
        {
            InitializeComponent();
            dgr_category.DataSource = list;
            LoadCategory();
            AddBindingCategory();
        }
        void LoadCategory()
        {
            list.DataSource = new ProductCategoryDAO().ListAll();
        }
        void AddBindingCategory()
        {
            txb_supplier_code.DataBindings.Add("Text", dgr_category.DataSource, "ID", true, DataSourceUpdateMode.Never);
            txb_supplier_name.DataBindings.Add("Text", dgr_category.DataSource, "Name", true, DataSourceUpdateMode.Never);
            txb_supplier_address.DataBindings.Add("Text", dgr_category.DataSource, "Address", true, DataSourceUpdateMode.Never);
            txb_supplier_phone.DataBindings.Add("Text", dgr_category.DataSource, "PhoneNumber", true, DataSourceUpdateMode.Never);
        }
        void Clear()
        {
            txb_supplier_address.Clear();
            txb_supplier_code.Clear();
            txb_supplier_name.Clear();
            txb_supplier_phone.Clear();
        }
        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                ProductCategory item = new ProductCategory();
                item.Address = txb_supplier_address.Text;
                item.Name = txb_supplier_name.Text;
                item.PhoneNumber = txb_supplier_phone.Text;

                bool result = new ProductCategoryDAO().Insert(item);

                if (result == true)
                {
                    MessageBox.Show("Thêm nhà cung cấp thành công");
                    LoadCategory();
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình Thêm");
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình Thêm");
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                ProductCategory item = new ProductCategory();
                item.ID = Convert.ToInt32(txb_supplier_code.Text);
                item.Address = txb_supplier_address.Text;
                item.Name = txb_supplier_name.Text;
                item.PhoneNumber = txb_supplier_phone.Text;

                bool result = new ProductCategoryDAO().Update(item);

                if (result == true)
                {
                    MessageBox.Show("Sửa nhà cung cấp thành công");
                    LoadCategory();
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

            if (r == DialogResult.Yes)
            {
                long id = Convert.ToInt32(txb_supplier_code.Text);

                bool result = new ProductCategoryDAO().Delete(id);

                if (result == true)
                {
                    MessageBox.Show("Xóa nhà cung cáp thành công");
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình xóa");
                }
            }
            LoadCategory();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
