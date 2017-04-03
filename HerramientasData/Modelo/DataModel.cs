namespace HerramientasData.Modelo
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=DataModel")
        {
        }

        public virtual DbSet<candidata> candidatas { get; set; }
        public virtual DbSet<municipio> municipios { get; set; }
        public virtual DbSet<permiso> permisos { get; set; }
        public virtual DbSet<permisosnegadosrol> permisosnegadosrols { get; set; }
        public virtual DbSet<role> roles { get; set; }
        public virtual DbSet<usuario> usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<candidata>()
                .Property(e => e.cNombreCom)
                .IsUnicode(false);

            modelBuilder.Entity<candidata>()
                .Property(e => e.cDescripcion)
                .IsUnicode(false);

            modelBuilder.Entity<candidata>()
                .Property(e => e.cCorre)
                .IsUnicode(false);

            modelBuilder.Entity<candidata>()
                .Property(e => e.cCurp)
                .IsUnicode(false);

            modelBuilder.Entity<candidata>()
                .Property(e => e.cNivelStudio)
                .IsUnicode(false);

            modelBuilder.Entity<candidata>()
                .Property(e => e.cFoto)
                .IsUnicode(false);

            modelBuilder.Entity<municipio>()
                .Property(e => e.mNombre)
                .IsUnicode(false);

            modelBuilder.Entity<municipio>()
                .Property(e => e.mLogotipo)
                .IsUnicode(false);

            modelBuilder.Entity<municipio>()
                .Property(e => e.mDescripion)
                .IsUnicode(false);

            modelBuilder.Entity<municipio>()
                .HasMany(e => e.candidatas)
                .WithOptional(e => e.municipio)
                .HasForeignKey(e => e.fkMunicipio);

            modelBuilder.Entity<permiso>()
                .Property(e => e.sModulo)
                .IsUnicode(false);

            modelBuilder.Entity<permiso>()
                .Property(e => e.sDescripcion)
                .IsUnicode(false);

            modelBuilder.Entity<permiso>()
                .HasMany(e => e.permisosnegadosrols)
                .WithOptional(e => e.permiso)
                .HasForeignKey(e => e.fkPermisos);

            modelBuilder.Entity<role>()
                .Property(e => e.sNombre)
                .IsUnicode(false);

            modelBuilder.Entity<role>()
                .HasMany(e => e.permisosnegadosrols)
                .WithOptional(e => e.role)
                .HasForeignKey(e => e.fkRoles);

            modelBuilder.Entity<role>()
                .HasMany(e => e.usuarios)
                .WithOptional(e => e.role)
                .HasForeignKey(e => e.fkRol);

            modelBuilder.Entity<usuario>()
                .Property(e => e.sEmail)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.sPassword)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .HasMany(e => e.candidatas)
                .WithOptional(e => e.usuario)
                .HasForeignKey(e => e.fkUsuario);
        }
    }
}
