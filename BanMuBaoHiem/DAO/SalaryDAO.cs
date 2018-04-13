using BanMuBaoHiem.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanMuBaoHiem.DAO
{
    public class SalaryDAO
    {
        BanMuDbContext db = null;

        public SalaryDAO()
        {
            db = new BanMuDbContext();
        }
        public bool Insert(Salary item)
        {
            try
            {
                Salary check = db.Salaries.Where(x => x.EmpID == item.EmpID).SingleOrDefault();
                if(check == null)
                   {
                    db.Salaries.Add(item);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    MessageBox.Show("mã nhân viên trong bảng Salary đã bị trùng");
                    return false;
                }
               
            }
            catch
            {
                return false;
            }
        }
        public bool Update(Salary item)
        {
            try
            {
                Salary s = db.Salaries.Where(x => x.EmpID == item.EmpID).Single();
                s.salary = item.salary;
                s.WorkingDay = item.WorkingDay;
                s.WorkingHours = item.WorkingHours;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(long emp_id)
        {
            try
            {
                db.Salaries.Remove(db.Salaries.Where(x => x.EmpID == emp_id).Single());
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
