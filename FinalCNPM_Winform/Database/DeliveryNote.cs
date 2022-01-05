namespace FinalCNPM_Winform.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DeliveryNote")]
    public partial class DeliveryNote
    {
        public int id { get; set; }

        public DateTime? createTime { get; set; }

        public int orderId { get; set; }

        public decimal? totalPrice { get; set; }
    }
}
