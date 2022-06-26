namespace DataAccess.DataBase
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BarderDB : DbContext
    {
        public BarderDB()
            : base("name=BarderDB")
        {
        }

        public virtual DbSet<Emparejamiento> Emparejamiento { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<Fotos> Fotos { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Emparejamiento>()
                .Property(e => e.Ganador)
                .IsUnicode(false);

            modelBuilder.Entity<Estado>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Estado>()
                .HasMany(e => e.Emparejamiento)
                .WithRequired(e => e.Estado1)
                .HasForeignKey(e => e.Estado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Fotos>()
                .Property(e => e.RutaFoto)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Pais)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Ciudad)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Emparejamiento)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.UsuarioId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Fotos)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.UsuarioId)
                .WillCascadeOnDelete(false);
        }
    }
}
