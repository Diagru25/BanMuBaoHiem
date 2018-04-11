using BanMuBaoHiem.EF;
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
    }
}
