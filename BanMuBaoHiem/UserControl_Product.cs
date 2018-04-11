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

namespace BanMuBaoHiem
{
    public partial class UserControl_Product : UserControl
    {
        public UserControl_Product()
        {
            InitializeComponent();
            LoadProduct();
            LoadProductCategory();
        }

        void LoadProduct()
        {
            dgr_product.DataSource = new ProductDAO().ListAll();
        }
        void LoadProductCategory()
        {
            cbo_supplier.DataSource = new ProductCategoryDAO().ListAll();
            cbo_supplier.DisplayMember = "Name";
            cbo_supplier.ValueMember = "ID";
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            
        }
    }
}
