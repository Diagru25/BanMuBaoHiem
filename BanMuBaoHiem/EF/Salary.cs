namespace BanMuBaoHiem.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Salary")]
    public partial class Salary
    {
        public long ID { get; set; }

        public long EmpID { get; set; }

        public decimal? salary { get; set; }

        public int? WorkingDay { get; set; }

        public int? WorkingHours { get; set; }
    }
}
