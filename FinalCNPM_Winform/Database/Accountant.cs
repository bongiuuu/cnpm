namespace FinalCNPM_Winform.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Accountant")]
    public partial class Accountant
    {
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public int? age { get; set; }

        [StringLength(10)]
        public string phone { get; set; }

        public bool? sex { get; set; }

        [StringLength(50)]
        public string email { get; set; }
    }
}
