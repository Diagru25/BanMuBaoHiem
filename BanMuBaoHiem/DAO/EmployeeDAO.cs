using BanMuBaoHiem.EF;
using BanMuBaoHiem.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanMuBaoHiem.DAO
{
    public class EmployeeDAO
    {
        BanMuDbContext db = null;

        public EmployeeDAO()
        {
            db = new BanMuDbContext();
        }

        public List<EmployeeViewModel> ListAll()
        {
            var list = (from e in db.Employees
                        join s in db.Salaries
                        on e.ID equals s.EmpID
                        select new EmployeeViewModel {
                            Address = e.Address,
                            DateOfBirth = e.DateOfBirth,
                            ID = e.ID,
                            Name = e.Name,
                            PhoneNumber = e.PhoneNumber,
                            salary = s.salary,
                            Sex = e.Sex,
                            WorkingDay = s.WorkingDay,
                            WorkingHours = s.WorkingHours
                        }).ToList();
            return list;
        }
        public long Insert(Employee item)
        {
            try
            {
                db.Employees.Add(item);
                db.SaveChanges();
                return item.ID;
            }
            catch
            {
                return 0;
            }
        }
        public bool Update(Employee item)
        {
            try
            {
                Employee emp = db.Employees.Find(item.ID);
                emp.Name = item.Name;
                emp.Address = item.Address;
                emp.DateOfBirth = item.DateOfBirth;
                emp.PhoneNumber = item.PhoneNumber;
                emp.Sex = item.Sex;

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
                db.Employees.Remove(db.Employees.Find(id));
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<EmployeeViewModel> Search(string text)
        {
            var list = (from e in db.Employees
                        join s in db.Salaries
                        on e.ID equals s.EmpID
                        select new EmployeeViewModel
                        {
                            Address = e.Address,
                            DateOfBirth = e.DateOfBirth,
                            ID = e.ID,
                            Name = e.Name,
                            PhoneNumber = e.PhoneNumber,
                            salary = s.salary,
                            Sex = e.Sex,
                            WorkingDay = s.WorkingDay,
                            WorkingHours = s.WorkingHours
                        }).Where(x=>x.Address.Contains(text) || x.DateOfBirth.Value.ToString().Contains(text)
                                 || x.Name.Contains(text) || x.PhoneNumber.Contains(text)
                                 || x.Sex.Contains(text) || x.salary.Value.ToString().Contains(text)
                                 || x.WorkingDay.Value.ToString().Contains(text) || x.WorkingHours.Value.ToString().Contains(text)).ToList();
            return list;
        }
    }
}
