using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CSADB.Model
{
    public partial class DeliveryServiceEDM : DbContext
    {
        public DeliveryServiceEDM()
            : base("name=DeliveryServiceEDM")
        {
        }

        public DeliveryServiceEDM(string ConnectionString) : base(ConnectionString)
        {

        }

        public virtual DbSet<Cargo> Cargo { get; set; }
        public virtual DbSet<CargoType> CargoType { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Courier> Courier { get; set; }
        public virtual DbSet<CourierDelivery> CourierDelivery { get; set; }
        public virtual DbSet<Delivery> Delivery { get; set; }
        public virtual DbSet<DeliveryStatus> DeliveryStatus { get; set; }
        public virtual DbSet<PartnerCompany> PartnerCompany { get; set; }
        public virtual DbSet<Postamat> Postamat { get; set; }
        public virtual DbSet<Storage> Storage { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tariff> Tariff { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cargo>()
                .HasMany(e => e.Delivery)
                .WithMany(e => e.Cargo)
                .Map(m => m.ToTable("CargoDelivery").MapLeftKey("Cargo").MapRightKey("Delivery"));

            modelBuilder.Entity<CargoType>()
                .Property(e => e.TypeName)
                .IsUnicode(false);

            modelBuilder.Entity<CargoType>()
                .HasMany(e => e.Cargo)
                .WithRequired(e => e.CargoType1)
                .HasForeignKey(e => e.CargoType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.Courier)
                .WithRequired(e => e.City1)
                .HasForeignKey(e => e.City)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.Storage)
                .WithRequired(e => e.City1)
                .HasForeignKey(e => e.City)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.Delivery)
                .WithRequired(e => e.City)
                .HasForeignKey(e => e.DeliveryCity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.Postamat)
                .WithRequired(e => e.City1)
                .HasForeignKey(e => e.City)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Cargo)
                .WithRequired(e => e.Client)
                .HasForeignKey(e => e.Shipper)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Delivery)
                .WithRequired(e => e.Client)
                .HasForeignKey(e => e.Receiver)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Courier>()
                .HasMany(e => e.CourierDelivery)
                .WithRequired(e => e.Courier1)
                .HasForeignKey(e => e.Courier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Delivery>()
                .Property(e => e.DeliveryAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Delivery>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Delivery>()
                .HasMany(e => e.CourierDelivery)
                .WithRequired(e => e.Delivery1)
                .HasForeignKey(e => e.Delivery)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DeliveryStatus>()
                .Property(e => e.StatusName)
                .IsUnicode(false);

            modelBuilder.Entity<DeliveryStatus>()
                .HasMany(e => e.Delivery)
                .WithOptional(e => e.DeliveryStatus1)
                .HasForeignKey(e => e.DeliveryStatus);

            modelBuilder.Entity<PartnerCompany>()
                .HasMany(e => e.Courier)
                .WithOptional(e => e.PartnerCompany1)
                .HasForeignKey(e => e.PartnerCompany);

            modelBuilder.Entity<Postamat>()
                .Property(e => e.PostamatAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Postamat>()
                .HasMany(e => e.Delivery)
                .WithOptional(e => e.Postamat1)
                .HasForeignKey(e => e.Postamat);

            modelBuilder.Entity<Storage>()
                .HasMany(e => e.Cargo)
                .WithOptional(e => e.Storage1)
                .HasForeignKey(e => e.Storage);

            modelBuilder.Entity<Tariff>()
                .Property(e => e.TariffName)
                .IsUnicode(false);

            modelBuilder.Entity<Tariff>()
                .Property(e => e.Rate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tariff>()
                .HasMany(e => e.Delivery)
                .WithOptional(e => e.Tariff1)
                .HasForeignKey(e => e.Tariff);

            modelBuilder.Entity<Users>()
                .Property(e => e.PasswordHash)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .HasOptional(e => e.Client)
                .WithRequired(e => e.Users);

            modelBuilder.Entity<Users>()
                .HasOptional(e => e.Courier)
                .WithRequired(e => e.Users);
        }
    }
}
