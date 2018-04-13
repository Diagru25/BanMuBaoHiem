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
    public partial class UserControl_Product : UserControl
    {
        BindingSource list = new BindingSource();
        public UserControl_Product()
        {
            InitializeComponent();
            dgr_product.DataSource = list;
            LoadAll();
            AddNhanVienBinding();
        }
        void LoadAll()
        {
            LoadProduct();
            LoadProductCategory();
        }
        void LoadProduct()
        {
            list.DataSource = new ProductDAO().ListAll();
        }
        void LoadProductCategory()
        {
            cbo_supplier.DataSource = new ProductCategoryDAO().ListAll();
            cbo_supplier.DisplayMember = "Name";
            cbo_supplier.ValueMember = "ID";
        }
        void ClearText()
        {
            txb_product_code.Clear();
            txb_product_name.Clear();
            txb_product_price.Clear();
            txb_product_quantity.Clear();
        }
        void AddNhanVienBinding()
        {
            txb_product_code.DataBindings.Add("Text", dgr_product.DataSource, "ID", true, DataSourceUpdateMode.Never);
            txb_product_name.DataBindings.Add("Text", dgr_product.DataSource, "Name", true, DataSourceUpdateMode.Never);
            txb_product_price.DataBindings.Add("Text", dgr_product.DataSource, "Price", true, DataSourceUpdateMode.Never);
            txb_product_quantity.DataBindings.Add("Text", dgr_product.DataSource, "Quantity", true, DataSourceUpdateMode.Never);
            cbo_supplier.DataBindings.Add("SelectedValue", dgr_product.DataSource, "CategoryID", true, DataSourceUpdateMode.Never);
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                Product item = new Product();
                item.Name = txb_product_name.Text;
                item.Price = Convert.ToDecimal(txb_product_price.Text);
                item.Quantity = Convert.ToInt32(txb_product_quantity.Text);
                item.CategoryID = Convert.ToInt32(cbo_supplier.SelectedValue);

                bool result = new ProductDAO().Insert(item);

                if (result == true)
                {
                    MessageBox.Show("Thêm sản phẩm thành công");
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình thêm");
                }
                LoadProduct();
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình nhập, bạn hãy xem lại dữ liệu nhập vào");
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                Product item = new Product();
                item.ID = Convert.ToInt32(txb_product_code.Text);
                item.Name = txb_product_name.Text;
                item.Price = Convert.ToDecimal(txb_product_price.Text);
                item.Quantity = Convert.ToInt32(txb_product_quantity.Text);
                item.CategoryID = Convert.ToInt32(cbo_supplier.SelectedValue);

                bool result = new ProductDAO().Update(item);

                if (result == true)
                {
                    MessageBox.Show("Sửa sản phẩm thành công");
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình sửa");
                }
                LoadProduct();
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình nhập, bạn hãy xem lại dữ liệu nhập vào");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này ?", "Thông báo", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                long id = Convert.ToInt32(txb_product_code.Text);

                bool result = new ProductDAO().Delete(id);

                if (result == true)
                {
                    MessageBox.Show("Xóa sản phẩm thành công");
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình xóa");
                }
                LoadProduct();
            }
        }
    }
}
