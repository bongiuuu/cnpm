namespace FinalCNPM_Winform.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReceiveNote")]
    public partial class ReceiveNote
    {
        public int id { get; set; }

        public DateTime? createTime { get; set; }
    }
}
