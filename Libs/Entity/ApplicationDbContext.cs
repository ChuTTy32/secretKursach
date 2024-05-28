using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Identity.Client;
using Model;

namespace Libs;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.LogTo(Console.WriteLine);

        optionsBuilder.UseSqlServer("");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Position>(builder =>
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).HasMaxLength(64).HasColumnName("Name").IsRequired();
            builder.Property(x => x.Salary).HasColumnName("Salary").IsRequired();
        });
        modelBuilder.Entity<Position>().HasKey(x => x.Id);

        modelBuilder.Entity<CarInfo>(builder =>
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
        modelBuilder.Entity<CarInfo>().HasKey(x => x.Id);

        modelBuilder.Entity<Client>(builder =>
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(64);
            builder.Property(x => x.Surname).IsRequired().HasMaxLength(64);
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(12);
            builder.Property(x => x.Phone).HasMaxLength(64);
        });
        modelBuilder.Entity<Client>().HasKey(x => x.Id);

        modelBuilder.Entity<Staff>(builder =>
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(64);
            builder.Property(x => x.Surname).IsRequired().HasMaxLength(64);
            builder.Property(x => x.Experience).IsRequired();
            builder.Property(x => x.IsAdmin).IsRequired();
            builder.Property(x => x.PositionId).IsRequired();
            builder.Property(x => x.Schedule).IsRequired().HasMaxLength(8);
        });
        modelBuilder.Entity<Staff>().HasKey(x => x.Id);

        modelBuilder.Entity<Staff>().HasOne(x => x.Position).WithMany(x => x.Staff).HasForeignKey(x => x.PositionId);
        modelBuilder.Entity<Order>().HasOne(x => x.Worker).WithMany(x => x.Orders).HasForeignKey(x => x.WorkerId);
        modelBuilder.Entity<Order>().HasOne(x => x.Client).WithMany(x => x.Orders).HasForeignKey(x => x.ClientId);
        modelBuilder.Entity<Order>().HasOne(x => x.Car).WithMany(x => x.Orders).HasForeignKey(x => x.CarId);

        //Объект -> свойство -> метод настройки.
    }

}