using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using testscaffold.Models;

namespace testscaffold.CONTEXT;

public partial class TstingscaffoldContext : DbContext
{
    public TstingscaffoldContext()
    {
    }

    public TstingscaffoldContext(DbContextOptions<TstingscaffoldContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Orderitem> Orderitems { get; set; }

    public virtual DbSet<Orderss> Ordersses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server = DESKTOP-SMHGA8V\\SQL;Database=tstingscaffold;user Id = sa;password =1234;TrustServerCertificate =True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Orderitem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Orderite__3214EC075CFCA2B1");

            entity.HasOne(d => d.Order).WithMany(p => p.Orderitems).HasConstraintName("FK__Orderitem__Order__276EDEB3");
        });

        modelBuilder.Entity<Orderss>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Orderss__3214EC077F0B2D23");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
