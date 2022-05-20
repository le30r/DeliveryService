namespace CSADB.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string UserLogin { get; set; }

        [Required]
        [StringLength(128)]
        public string PasswordHash { get; set; }

        public int? AccessLevel { get; set; }

        public virtual Client Client { get; set; }

        public virtual Courier Courier { get; set; }
    }
}
