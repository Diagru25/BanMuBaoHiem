using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanMuBaoHiem.ViewModel
{
    public class EmployeeViewModel
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Sex { get; set; }
        public decimal? salary { get; set; }

        public int? WorkingDay { get; set; }

        public int? WorkingHours { get; set; }
    }
}
