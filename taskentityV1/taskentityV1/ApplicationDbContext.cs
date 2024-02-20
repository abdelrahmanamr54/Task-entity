using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace taskentityV1
{
    internal class ApplicationDbContext :DbContext
    {

        public DbSet<Task> tasks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source =.; Initial Catalog = Efcore503-2; Integrated Security = True; TrustServerCertificate = True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>()
                .Property(b => b.Date)
                .IsRequired();

            modelBuilder.Entity<Task>()
                .Property(b => b.Date)
                .HasColumnName("Deadline");

        }


    }
}
