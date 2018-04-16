using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanMuBaoHiem.EF;
using BanMuBaoHiem.ViewModel;

namespace BanMuBaoHiem.DAO
{
    public class StockInDAO
    {
        BanMuDbContext db = null;
        public StockInDAO()
        {
            db = new BanMuDbContext();
        }
        public List<StockInViewModel> ListAll()
        {
            var data = from a in db.StockIns
                       join b in db.Products on a.ProdID equals b.ID
                       join c in db.ProductCategories on b.CategoryID equals c.ID
                       select new StockInViewModel()
                       {
                           ID = a.ID,
                           ProdID = b.ID,
                           ProdName = b.Name,
                           BrandName = c.Name,
                           date = a.Date,
                           Quantity = a.Quantity,
                           UnitPrice = a.UnitPrice
                       };
            return data.ToList();
        }
    }
}
