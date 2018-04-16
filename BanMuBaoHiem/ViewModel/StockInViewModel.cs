using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanMuBaoHiem.ViewModel
{
    public class StockInViewModel
    {
        public long ID { get; set; }
        public long ProdID { get; set; }
        public string ProdName { get; set; }
        public string BrandName { get; set; }
        public int? Quantity { get; set; }
        public DateTime date { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
