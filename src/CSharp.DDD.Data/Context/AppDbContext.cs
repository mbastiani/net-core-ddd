using CSharp.DDD.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CSharp.DDD.Data.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>(entity => entity.HasKey(e => e.Id));

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasOne(p => p.Person).WithMany(p => p.Products).HasForeignKey(fk => fk.PersonId);
            });
        }
    }
}