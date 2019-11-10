using Domain;
using Microsoft.EntityFrameworkCore;

namespace Presistense
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Value> Values { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Value>()
                        .HasData(
                           new Value { Id = 1, Name = "Value 100" },
                           new Value { Id = 2, Name = "Value 102" },
                           new Value { Id = 3, Name = "Value 103" },
                           new Value { Id = 4, Name = "Value 104" },
                           new Value { Id = 5, Name = "Value 105" },
                           new Value { Id = 6, Name = "Value 106" },
                           new Value { Id = 7, Name = "Value 107" },
                           new Value { Id = 8, Name = "Value 108" },
                           new Value { Id = 9, Name = "Value 109" },
                           new Value { Id = 10, Name = "Value 110" }
                          );
        }
    }
}
