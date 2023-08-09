using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StudentApi.Models;

public partial class StudentDatabaseContext : DbContext
{
    public StudentDatabaseContext()
    {
    }

    public StudentDatabaseContext(DbContextOptions<StudentDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<StudentInfo> StudentInfos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=StudentDatabase;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StudentInfo>(entity =>
        {
            entity.HasKey(e => e.StudId);

            entity.ToTable("StudentInfo");

            entity.Property(e => e.StudId).HasColumnName("Stud_Id");
            entity.Property(e => e.StudAge).HasColumnName("Stud_Age");
            entity.Property(e => e.StudContact)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Stud_Contact");
            entity.Property(e => e.StudEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Stud_Email");
            entity.Property(e => e.StudName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Stud_Name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
