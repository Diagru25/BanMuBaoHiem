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
        public bool Insert(ProductCategory item)
        {
            try
            {
                db.ProductCategories.Add(item);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(ProductCategory item)
        {
            try
            {
                ProductCategory po = db.ProductCategories.Find(item.ID);
                po.Address = item.Address;
                po.Name = item.Name;
                po.PhoneNumber = item.PhoneNumber;
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
                db.ProductCategories.Remove(db.ProductCategories.Find(id));
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<ProductCategory> Search(string text)
        {
            return db.ProductCategories.Where(x => x.Name.Contains(text)
                                              || x.Address.Contains(text)
                                              || x.PhoneNumber.Contains(text)).ToList();
        }
    }
}
