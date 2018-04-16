using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanMuBaoHiem
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            UserControl_Product frm = new UserControl_Product();

            frm.Dock = DockStyle.Fill;

            pnl_main.Controls.Clear();

            pnl_main.Controls.Add(frm);
        }

        private void btn_category_product_Click(object sender, EventArgs e)
        {
            UserControl_CategoryProduct frm = new UserControl_CategoryProduct();

            frm.Dock = DockStyle.Fill;

            pnl_main.Controls.Clear();

            pnl_main.Controls.Add(frm);
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            UserControl_Employee frm = new UserControl_Employee();

            frm.Dock = DockStyle.Fill;

            pnl_main.Controls.Clear();

            pnl_main.Controls.Add(frm);
        }

        private void btn_search_form_Click(object sender, EventArgs e)
        {
            UserControl_Search frm = new UserControl_Search();

            frm.Dock = DockStyle.Fill;

            pnl_main.Controls.Clear();

            pnl_main.Controls.Add(frm);
        }

        private void btn_stock_form_Click(object sender, EventArgs e)
        {
            UserControl_StockIn frm = new UserControl_StockIn();

            frm.Dock = DockStyle.Fill;

            pnl_main.Controls.Clear();

            pnl_main.Controls.Add(frm);
        }
    }
}
