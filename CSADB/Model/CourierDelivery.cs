namespace CSADB.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CourierDelivery")]
    public partial class CourierDelivery
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Courier { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Delivery { get; set; }

        [Column(TypeName = "date")]
        public DateTime IssueDate { get; set; }

        public TimeSpan IssueTime { get; set; }

        public virtual Courier Courier1 { get; set; }

        public virtual Delivery Delivery1 { get; set; }
    }
}
