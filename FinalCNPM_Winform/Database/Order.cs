namespace FinalCNPM_Winform.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        public int id { get; set; }

        public DateTime? createTime { get; set; }

        [StringLength(50)]
        public string status { get; set; }

        [StringLength(50)]
        public string paymentMethod { get; set; }

        [StringLength(50)]
        public string paymentStatus { get; set; }
    }
}
