namespace BanMuBaoHiem.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StockIn")]
    public partial class StockIn
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public long? ProdID { get; set; }

        public int? Quantity { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public decimal? UnitPrice { get; set; }
    }
}
