using BanMuBaoHiem.EF;
using BanMuBaoHiem.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanMuBaoHiem.DAO
{
    public class ProductDAO
    {
        BanMuDbContext db = null;

        public ProductDAO()
        {
            db = new BanMuDbContext();
        }
        public List<ProductViewModel> ListAll()
        {
            var list = (from p in db.Products
                        join c in db.ProductCategories
                        on p.CategoryID equals c.ID
                        select new ProductViewModel()
                        {
                            ID = p.ID,
                            CategoryID = p.CategoryID,
                            name = p.Name,
                            Price = p.Price,
                            Quantity = p.Quantity,
                            supplier_name = c.Name
                        }).ToList();
            return list;
        }
    }
}
