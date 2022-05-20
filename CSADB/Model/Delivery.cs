namespace CSADB.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Delivery")]
    public partial class Delivery
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Delivery()
        {
            CourierDelivery = new HashSet<CourierDelivery>();
            Cargo = new HashSet<Cargo>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeliveryID { get; set; }

        public int Receiver { get; set; }

        public int? Postamat { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DeliveryDate { get; set; }

        public TimeSpan? DeliveryTime { get; set; }

        public int? DeliveryStatus { get; set; }

        public int? Tariff { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        public virtual Client Client { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourierDelivery> CourierDelivery { get; set; }

        public virtual Postamat Postamat1 { get; set; }

        public virtual DeliveryStatus DeliveryStatus1 { get; set; }

        public virtual Tariff Tariff1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cargo> Cargo { get; set; }
    }
}
