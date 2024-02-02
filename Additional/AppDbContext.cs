using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace testscaffold.Additional
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Connection.sqlcon);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<StudentBook> StudentBooks { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Uniform> uniforms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Student>().HasIndex(x => new { x.Name , x.Email });
            //modelBuilder.Entity<Student>().HasIndex(x => x.Name).IsUnique()
            //    .HasDatabaseName("xi_my_index").HasFilter("Name is not null");

            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
                                  .SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            modelBuilder.Entity<Invoice>().Property(x => x.qty)
                        .HasDefaultValue(1);

            modelBuilder.Entity<Invoice>().Property(x => x.createdDate)
                        .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Invoice>().Property(x => x.fullName)
                        .HasComputedColumnSql("[customerTitle] + ' ' + [customerName]");
            modelBuilder.Entity<Invoice>().Property(x => x.total)
                       .HasComputedColumnSql("[price] * [qty]");

            modelBuilder.Entity<Invoice>().HasData(

                new Invoice() { Id = 1, customerName = "MOha", customerTitle = "Tit", price = 10, qty = 5 },
                new Invoice() { Id = 2, customerName = "MOhamed", customerTitle = "Titingggg", price = 20, qty = 5 }

                );

            modelBuilder.HasSequence<int>("DeliveryOrder")
                .StartsAt(101)
                .IncrementsBy(1);

            modelBuilder.Entity<Book>().Property(p => p.DeliveryOrder)
                .HasDefaultValueSql("Next Value For DeliveryOrder");

            modelBuilder.Entity<Uniform>().Property(p => p.DeliveryOrder)
                 .HasDefaultValueSql("Next Value For DeliveryOrder");

            modelBuilder.Entity<Gender>().HasData(
                new Gender() { Id = 1, genderName = "Male" },
                new Gender() { Id = 2, genderName = "Female" }
                );
            

        }
    }
}
