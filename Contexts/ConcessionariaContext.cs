using System;
using System.Collections.Generic;
using ConcessionariaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ConcessionariaAPI.Contexts;

public partial class ConcessionariaContext : DbContext
{
    public ConcessionariaContext(DbContextOptions<ConcessionariaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Marca> Marca { get; set; }

    public virtual DbSet<Veiculo> Veiculo { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Marca>(entity =>
        {
            entity.HasKey(e => e.IdMarca).HasName("PK__Marca__4076A88786B5928D");

            entity.HasIndex(e => e.Nome, "UQ__Marca__7D8FE3B2F3FE4B7C").IsUnique();

            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaisOrigem)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Veiculo>(entity =>
        {
            entity.HasKey(e => e.IdVeiculo).HasName("PK__Veiculo__CAC4F34626295B8D");

            entity.HasIndex(e => e.Placa, "UQ__Veiculo__8310F99DB4C0CCF6").IsUnique();

            entity.Property(e => e.Cor)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Modelo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Placa)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Preco).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.IdMarcaNavigation).WithMany(p => p.Veiculo)
                .HasForeignKey(d => d.IdMarca)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Veiculo__IdMarca__60A75C0F");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
