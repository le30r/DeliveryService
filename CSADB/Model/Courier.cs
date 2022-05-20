namespace CSADB.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Courier")]
    public partial class Courier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Courier()
        {
            CourierDelivery = new HashSet<CourierDelivery>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourierID { get; set; }

        [Required]
        [StringLength(25)]
        public string FirstName { get; set; }

        [StringLength(25)]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(25)]
        public string LastName { get; set; }

        [Column(TypeName = "date")]
        public DateTime Birthday { get; set; }

        public long Phone { get; set; }

        public int? PartnerCompany { get; set; }

        public int City { get; set; }

        [Required]
        [StringLength(65)]
        public string District { get; set; }

        public bool Car { get; set; }

        public virtual City City1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourierDelivery> CourierDelivery { get; set; }

        public virtual PartnerCompany PartnerCompany1 { get; set; }

        public virtual Users Users { get; set; }
    }
}
