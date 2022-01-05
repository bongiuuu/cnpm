namespace FinalCNPM_Winform.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReceiveDetail")]
    public partial class ReceiveDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int receiveId { get; set; }

        public int productId { get; set; }

        public int? quantity { get; set; }

        public decimal? price { get; set; }

        public string name { get; set; }

        public decimal? totalPrice { get; set; }

        public DateTime? createTime { get; set; }


    }
}
