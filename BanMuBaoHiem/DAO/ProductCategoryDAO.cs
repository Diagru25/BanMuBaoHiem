using BanMuBaoHiem.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanMuBaoHiem.DAO
{
    public class ProductCategoryDAO
    {
        BanMuDbContext db = null;

        public ProductCategoryDAO()
        {
            db = new BanMuDbContext();
        }
        public List<ProductCategory> ListAll()
        {
            return db.ProductCategories.ToList();
        }
    }
}
