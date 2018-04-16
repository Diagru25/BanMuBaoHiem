using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanMuBaoHiem.DAO;
using Microsoft.Reporting.WinForms;

namespace BanMuBaoHiem
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var date =  dateTimePicker1.Value;
            var data = new StockInDAO().ListAll();
            ReportDataSource rds = new ReportDataSource("StockIn", new StockInDAO().ListAll().Where(x=>x.date.ToShortDateString() == dateTimePicker1.Value.ToShortDateString()));
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
