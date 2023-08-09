using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdmisionQRGenerated.Models;

public partial class AdmissionDetailsContext : DbContext
{
    public AdmissionDetailsContext()
    {
    }

    public AdmissionDetailsContext(DbContextOptions<AdmissionDetailsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admissionlist> Admissionlists { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=AdmissionDetails;Username=postgres;Password=1234567");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admissionlist>(entity =>
        {
            entity.HasKey(e => e.Standard).HasName("admissionlist_pkey");

            entity.ToTable("admissionlist");

            entity.Property(e => e.Standard)
                .ValueGeneratedNever()
                .HasColumnName("standard");
            entity.Property(e => e.Fees).HasColumnName("fees");
            entity.Property(e => e.Studentname)
                .HasMaxLength(50)
                .HasColumnName("studentname");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
