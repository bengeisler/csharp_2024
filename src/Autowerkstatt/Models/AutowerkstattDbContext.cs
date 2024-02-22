using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Autowerkstatt.Models;

public partial class AutowerkstattDbContext : DbContext
{
    public AutowerkstattDbContext()
    {
    }

    public AutowerkstattDbContext(DbContextOptions<AutowerkstattDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Fahrzeug> Fahrzeugs { get; set; }

    public virtual DbSet<Reparatur> Reparaturs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=AutowerkstattDb; Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Fahrzeug>(entity =>
        {
            entity.HasKey(e => e.Nr);

            entity.ToTable("Fahrzeug");

            entity.Property(e => e.Halter)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Kennzeichen)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Marke)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Modell)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ort)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Reparatur>(entity =>
        {
            entity.HasKey(e => e.Nr).HasName("PK_Reparaturen");

            entity.ToTable("Reparatur");

            entity.Property(e => e.Beschreibung)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Datum).HasColumnType("smalldatetime");
            entity.Property(e => e.Kosten).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.FahrzeugNrNavigation).WithMany(p => p.Reparaturs)
                .HasForeignKey(d => d.FahrzeugNr)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Reparaturen_Fahrzeug");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
