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

        public bool Insert(Product item)
        {
            try
            {
                db.Products.Add(item);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Product item)
        {
            try
            {
                Product pro = db.Products.Find(item.ID);
                pro.Name = item.Name;
                pro.Price = item.Price;
                pro.Quantity = item.Quantity;
                pro.CategoryID = item.CategoryID;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(long id)
        {
            try
            {
                db.Products.Remove(db.Products.Find(id));
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<ProductViewModel> Search(string text)
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
                        }).Where(x=>x.name.Contains(text) || x.Price.Value.ToString().Contains(text)
                                 || x.Quantity.Value.ToString().Contains(text) || x.supplier_name.Contains(text)).ToList();
            return list;
        }
    }
}
