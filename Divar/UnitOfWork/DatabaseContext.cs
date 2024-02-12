using Microsoft.EntityFrameworkCore;
using Models;
using Models.Enums;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.EntityFrameworkCore.Extensions;
using Resources;

namespace UnitOfWork
{
    internal class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToCollection(CollectionNames.User);

            modelBuilder.Entity<Advertise>().ToCollection(CollectionNames.Advertise);
            modelBuilder.Entity<DigitalAdvertise>().ToCollection(CollectionNames.Advertise).HasDiscriminator<string>("Discriminator");
            modelBuilder.Entity<CarAdvertise>().ToCollection(CollectionNames.Advertise).HasDiscriminator<string>("Discriminator");
            modelBuilder.Entity<HouseAdvertise>().ToCollection(CollectionNames.Advertise).HasDiscriminator<string>("Discriminator");
            modelBuilder.Entity<ServiceAdvertise>().ToCollection(CollectionNames.Advertise).HasDiscriminator<string>("Discriminator");
            modelBuilder.Entity<ObjectAdvertise>().ToCollection(CollectionNames.Advertise).HasDiscriminator<string>("Discriminator");

        }

        public DbSet<Advertise> Advertises { get; set; }
        public DbSet<DigitalAdvertise> DigitalAdvertises { get; set; }
        public DbSet<CarAdvertise> CarAdvertises { get; set; }
        public DbSet<HouseAdvertise> HouseAdvertises { get; set; }
        public DbSet<ServiceAdvertise> ServiceAdvertises { get; set; }
        public DbSet<ObjectAdvertise> ObjectAdvertises { get; set; }
        public DbSet<User> Users { get; set; }

    }
}