namespace BanMuBaoHiem.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public decimal? Price { get; set; }

        public int? Quantity { get; set; }

        public long? CategoryID { get; set; }
    }
}
