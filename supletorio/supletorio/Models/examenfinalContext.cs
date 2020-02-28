using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace supletorio.Models
{
    public partial class examenfinalContext : DbContext
    {
        public examenfinalContext()
        {
        }

        public examenfinalContext(DbContextOptions<examenfinalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Comentarios> Comentarios { get; set; }
        public virtual DbSet<Entradas> Entradas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=MAURY\\MSSQLSERVER01;Database=examenfinal;Trusted_Connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comentarios>(entity =>
            {
                entity.HasKey(e => e.Idcometarios)
                    .HasName("PK__Comentar__DFD87721889DD050");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdentradasNavigation)
                    .WithMany(p => p.Comentarios)
                    .HasForeignKey(d => d.Identradas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_entradas1");
            });

            modelBuilder.Entity<Entradas>(entity =>
            {
                entity.HasKey(e => e.Identradas)
                    .HasName("PK__Entradas__0C31FC0D933F4CD8");

                entity.Property(e => e.Autor)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
