namespace CSADB.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tariff")]
    public partial class Tariff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tariff()
        {
            Delivery = new HashSet<Delivery>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TariffID { get; set; }

        [Required]
        [StringLength(25)]
        public string TariffName { get; set; }

        [Column(TypeName = "money")]
        public decimal Rate { get; set; }

        public bool Fragile { get; set; }

        public bool Toxic { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Delivery> Delivery { get; set; }
    }
}
