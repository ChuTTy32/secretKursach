using System;
using Microsoft.EntityFrameworkCore;
using Model.CarInfo;
using Model.Client;
using Model.Order;
using Model.Position;
using Model.Staff;

namespace Libs
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // DbSet properties for each model
        public DbSet<PositionModel> Positions { get; set; }
        public DbSet<CarInfoModel> Cars { get; set; }
        public DbSet<ClientModel> Clients { get; set; }
        public DbSet<OrderModel> Orders { get; set; }
        public DbSet<StaffModel> Staff { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PositionModel>(builder =>
            {
                builder.Property(x => x.Id).ValueGeneratedOnAdd();
                builder.Property(x => x.Name).HasMaxLength(64).HasColumnName("Name").IsRequired();
                builder.Property(x => x.Salary).HasColumnName("Salary").IsRequired();
            });
            modelBuilder.Entity<PositionModel>().HasKey(x => x.Id);

            modelBuilder.Entity<CarInfoModel>(builder =>
            {
                builder.Property(x => x.Id).ValueGeneratedOnAdd();
                builder.Property(x => x.Brand).IsRequired().HasMaxLength(32).HasColumnName("Brand");
                builder.Property(x => x.Model).IsRequired().HasMaxLength(32).HasColumnName("Model");
                builder.Property(x => x.Weight).IsRequired().HasColumnName("Weight");
                builder.Property(x => x.Power).IsRequired().HasColumnName("Power");
                builder.Property(x => x.Type).IsRequired().HasMaxLength(32).HasColumnName("Type");
                builder.Property(x => x.Height).IsRequired().HasColumnName("Height");
                builder.Property(x => x.Width).IsRequired().HasColumnName("Width");
                builder.Property(x => x.Value).IsRequired().HasColumnName("Value");
                builder.Property(x => x.Serial).IsRequired().HasMaxLength(32).HasColumnName("Serial");
            });
            modelBuilder.Entity<CarInfoModel>().HasKey(x => x.Id);

            modelBuilder.Entity<ClientModel>(builder =>
            {
                builder.Property(x => x.Id).ValueGeneratedOnAdd();
                builder.Property(x => x.Name).IsRequired().HasMaxLength(64);
                builder.Property(x => x.Surname).IsRequired().HasMaxLength(64);
                builder.Property(x => x.Phone).IsRequired().HasMaxLength(12);
                builder.Property(x => x.Phone).HasMaxLength(64);
            });
            modelBuilder.Entity<ClientModel>().HasKey(x => x.Id);

            modelBuilder.Entity<StaffModel>(builder =>
            {
                builder.Property(x => x.Id).ValueGeneratedOnAdd();
                builder.Property(x => x.Name).IsRequired().HasMaxLength(64);
                builder.Property(x => x.Surname).IsRequired().HasMaxLength(64);
                builder.Property(x => x.Experience).IsRequired();
                builder.Property(x => x.IsAdmin).IsRequired();
                builder.Property(x => x.PositionId).IsRequired();
                builder.Property(x => x.Schedule).IsRequired().HasMaxLength(8);
            });
            modelBuilder.Entity<StaffModel>().HasKey(x => x.Id);

            modelBuilder.Entity<StaffModel>().HasOne(x => x.Position)
                .WithMany(x => x.Staff)
                .HasForeignKey(x => x.PositionId);

            modelBuilder.Entity<OrderModel>().HasOne(x => x.Worker)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.WorkerId);

            modelBuilder.Entity<OrderModel>().HasOne(x => x.Client)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.ClientId);

            modelBuilder.Entity<OrderModel>().HasOne(x => x.Car)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.CarId);
        }
    }
}
