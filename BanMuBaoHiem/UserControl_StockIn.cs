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
    public partial class UserControl_StockIn : UserControl
    {

        BindingSource list = new BindingSource();
        public UserControl_StockIn()
        {
            InitializeComponent();
            dtg_stockin.DataSource = list;
            LoadALl();
            AddStockInBinding();
        }

        private void AddStockInBinding()
        {
            txb_si_code.DataBindings.Add("Text", dtg_stockin.DataSource, "ID", true, DataSourceUpdateMode.Never);
            txb_pro_id.DataBindings.Add("Text", dtg_stockin.DataSource, "ProdID", true, DataSourceUpdateMode.Never);
            cb_pro_name.DataBindings.Add("Text", dtg_stockin.DataSource, "ProdName", true, DataSourceUpdateMode.Never);
            txb_pro_brand.DataBindings.Add("Text", dtg_stockin.DataSource, "BrandName", true, DataSourceUpdateMode.Never);
            txb_pro_quantity.DataBindings.Add("Text", dtg_stockin.DataSource, "Quantity", true, DataSourceUpdateMode.Never);
            txb_pro_up.DataBindings.Add("Text", dtg_stockin.DataSource, "UnitPrice", true, DataSourceUpdateMode.Never);
            dtp_pro_date.DataBindings.Add("Value", dtg_stockin.DataSource, "date", true, DataSourceUpdateMode.Never);
        }

        private void LoadALl()
        {
            LoadEmp();
        }

        private void LoadEmp()
        {
            list.DataSource = new StockInDAO().ListAll();
            cb_pro_name.DataSource = new ProductDAO().ListAll();
            cb_pro_name.ValueMember = "ID";
            cb_pro_name.DisplayMember = "Name";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            rp.Show(this);
        }

        private void btn_lammoi_stockin_Click(object sender, EventArgs e)
        {
            txb_pro_id.Clear();
            txb_pro_quantity.Clear();
            txb_pro_up.Clear();
            txb_si_code.Clear();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            //StockIn item = new StockIn();
            //item.ProdID = Convert.ToInt64(cb_pro_name.SelectedValue);
            //item.Quantity = Convert.ToInt64(txb_pro_quantity.Text);
            //item
        }
    }
}
