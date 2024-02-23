using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Bestellungen.Models;

public partial class BestellungDbContext : DbContext
{
    public BestellungDbContext()
    {
    }

    public BestellungDbContext(DbContextOptions<BestellungDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bestellung> Bestellungs { get; set; }

    public virtual DbSet<Kunde> Kundes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=BestellungDb; Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bestellung>(entity =>
        {
            entity.HasKey(e => e.BestellNr).HasName("PK_Bestellungen");

            entity.ToTable("Bestellung");

            entity.Property(e => e.Datum).HasColumnType("datetime");
            entity.Property(e => e.Preis).HasColumnType("money");
            entity.Property(e => e.Text)
                .HasMaxLength(1024)
                .IsUnicode(false);

            entity.HasOne(d => d.KundenNrNavigation).WithMany(p => p.Bestellungs)
                .HasForeignKey(d => d.KundenNr)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bestellungen_Kunden");
        });

        modelBuilder.Entity<Kunde>(entity =>
        {
            entity.HasKey(e => e.KundenNr).HasName("PK_Kunden");

            entity.ToTable("Kunde");

            entity.Property(e => e.Adresse)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ort)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Plz)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PLZ");
            entity.Property(e => e.Telefon)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
