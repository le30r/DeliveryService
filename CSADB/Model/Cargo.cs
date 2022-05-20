namespace CSADB.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cargo")]
    public partial class Cargo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cargo()
        {
            Delivery = new HashSet<Delivery>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CargoID { get; set; }

        public int CargoType { get; set; }

        [StringLength(50)]
        public string CargoName { get; set; }

        public int? Storage { get; set; }

        public int Shipper { get; set; }

        [Column(TypeName = "date")]
        public DateTime ArrivalDate { get; set; }

        public TimeSpan ArrivalTime { get; set; }

        public float CargoWeight { get; set; }

        public float Height { get; set; }

        public float Width { get; set; }

        public float Depth { get; set; }

        public virtual Client Client { get; set; }

        public virtual Storage Storage1 { get; set; }

        public virtual CargoType CargoType1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Delivery> Delivery { get; set; }
    }
}
