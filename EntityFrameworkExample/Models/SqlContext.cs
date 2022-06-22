namespace MigrationCodeFirst.Models
{
    using Microsoft.EntityFrameworkCore;
    public class SqlContext : DbContext
    {
        public virtual DbSet<SqlWorker>? Workers { get; set; }

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
                    .HasMaxLength(255);

                entity.Property(e => e.LastName)
                    .HasColumnName("lastname")
                    .HasMaxLength(255);

                entity.Property(e => e.MiddleName)
                    .HasColumnName("middlename")
                    .HasMaxLength(255);
            });
        }
    }
}
