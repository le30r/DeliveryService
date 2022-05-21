namespace CSADB.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Postamat")]
    public partial class Postamat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Postamat()
        {
            Delivery = new HashSet<Delivery>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PostamatID { get; set; }

        public int City { get; set; }

        [Required]
        [StringLength(65)]
        public string PostamatAddress { get; set; }

        public int? Capacity { get; set; }

        public virtual City City1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Delivery> Delivery { get; set; }
    }
}
