using Microsoft.EntityFrameworkCore;
using OrgManager.WinForms.Domain;


namespace OrgManager.WinForms.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<OrgNode> OrgNodes => Set<OrgNode>();


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Použi LocalDB (funguje bez extra inštalácie SQL Express)
                optionsBuilder.UseSqlServer(
               //"Server=(localdb)\\MSSQLLocalDB;Database=OrgManagerDb;Trusted_Connection=True;MultipleActiveResultSets=true"
               // "Server=(localdb)\\MSSQLLocalDB;Database=OrgManagerDb;Trusted_Connection=True;"
               // "Server=.\\SQLEXPRESS;Database=OrgManagerDb;Trusted_Connection=True;MultipleActiveResultSets=true"
               "Server=.\\SQLEXPRESS;Database=OrgManagerDb;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;MultipleActiveResultSets=true"
                );
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrgNode>()
            .HasIndex(x => x.Code)
            .IsUnique();


            modelBuilder.Entity<OrgNode>()
            .HasOne(x => x.Parent)
            .WithMany(x => x.Children)
            .HasForeignKey(x => x.ParentId)
            .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<OrgNode>()
            .HasOne(x => x.Leader)
            .WithMany()
            .HasForeignKey(x => x.LeaderEmployeeId)
            .OnDelete(DeleteBehavior.SetNull);


            // Seed: 1 základná firma pre štart
            modelBuilder.Entity<OrgNode>().HasData(new OrgNode
            {
                Id = 1,
                Type = OrgNodeType.Company,
                Code = "COMP",
                Name = "Moja Firma"
            });
        }
    }
}