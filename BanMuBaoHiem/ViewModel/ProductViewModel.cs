using BanMuBaoHiem.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanMuBaoHiem.ViewModel
{
    public class ProductViewModel
    {
        public long ID { get; set; }
        public long? CategoryID { get; set; }
        public string name { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public string supplier_name { get; set; }
    }
}
