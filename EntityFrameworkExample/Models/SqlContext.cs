namespace MigrationCodeFirst.Models
{
    using EntityFrameworkExample.Models;
    using Microsoft.EntityFrameworkCore;
    public class SqlContext : DbContext
    {
        public virtual DbSet<SqlWorker>? Workers { get; set; }
        //public virtual DbSet<SqlExcludeInMigration>? Excludes { get; set; }

        public SqlContext()
        {
        }

        public SqlContext(DbContextOptions<SqlContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<SqlWorker>(entity =>
            {
                entity.ToTable("workers");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.FirstName)
                    .HasColumnName("firstname")
                    .HasMaxLength(255)
                    .IsRequired();

                entity.Property(e => e.LastName)
                    .HasColumnName("lastname")
                    .HasMaxLength(255)
                    .IsRequired();

                entity.ToTable("ExcludeFromMigrations", t => t.ExcludeFromMigrations());
            });

            modelBuilder.Entity<SqlExcludeInMigration>(entityExclude =>
            {
                // Will not create the ExcludeFromMigrations table, but SqlExcludeInMigration
                // is still included in the model and can be used normally
                entityExclude.ToTable("ExcludeFromMigrations", t => t.ExcludeFromMigrations());

                // must hade key
                entityExclude.HasKey(e => e.Id);

                // https://docs.microsoft.com/en-us/ef/core/modeling/entity-types?tabs=data-annotations
            });
        }
    }
}
