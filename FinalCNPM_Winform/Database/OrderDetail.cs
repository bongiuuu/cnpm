namespace FinalCNPM_Winform.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderDetail")]
    public partial class OrderDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int orderId { get; set; }

        public int? quantity { get; set; }

        public decimal? price { get; set; }

        public string name { get; set; }

        public decimal? totalPrice { get; set; }

        [StringLength(50)]
        public string status { get; set; }

        [StringLength(50)]
        public string paymentMethod { get; set; }

        [StringLength(50)]
        public string paymentStatus { get; set; }


    }
}
