using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanMuBaoHiem.ViewModel;
using BanMuBaoHiem.DAO;
using BanMuBaoHiem.EF;

namespace BanMuBaoHiem
{
    public partial class UserControl_Search : UserControl
    {
        public UserControl_Search()
        {
            InitializeComponent();
            dgr_search.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        void Search_Product(string text)
        {
            List<ProductViewModel> list = new ProductDAO().Search(text);
            dgr_search.DataSource = list;
            dgr_search.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        void Search_Employee(string text)
        {
            List<EmployeeViewModel> list = new EmployeeDAO().Search(text);
            dgr_search.DataSource = list;
            dgr_search.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        void Search_Hang(string text)
        {
            List<ProductCategory> list = new ProductCategoryDAO().Search(text);
            dgr_search.DataSource = list;
            dgr_search.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            string type = cbo_search.SelectedItem.ToString();
            string text = txb_search.Text;
            if (type == "Sản phẩm")
            {
                Search_Product(text);
            }
            else if (type == "Nhân viên")
            {
                Search_Employee(text);
            }
            else
            {
                Search_Hang(text);
            }
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            try
            {
                string type = cbo_search.SelectedItem.ToString();
                if (type == "Sản phẩm")
                {
                    dgr_search.DataSource = new ProductDAO().ListAll();

                }
                else if (type == "Nhân viên")
                {
                    dgr_search.DataSource = new EmployeeDAO().ListAll();
                }
                else
                {
                    dgr_search.DataSource = new ProductCategoryDAO().ListAll();
                }
            }
            catch
            {
                MessageBox.Show("Bạn phải chọn dữ liệu trong combobox");
            }
        }
    }
}
