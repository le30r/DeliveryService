namespace CSADB.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Storage")]
    public partial class Storage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Storage()
        {
            Cargo = new HashSet<Cargo>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StorageID { get; set; }

        [Required]
        [StringLength(25)]
        public string StorageName { get; set; }

        public int Capacity { get; set; }

        public int City { get; set; }

        [Required]
        [StringLength(65)]
        public string StorageAddress { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cargo> Cargo { get; set; }

        public virtual City City1 { get; set; }
    }
}
