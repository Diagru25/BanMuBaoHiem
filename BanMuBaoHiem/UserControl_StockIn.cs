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
            txb_pro_name.DataBindings.Add("Text", dtg_stockin.DataSource, "ProdName", true, DataSourceUpdateMode.Never);
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
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            rp.Show(this);
        }
    }
}
