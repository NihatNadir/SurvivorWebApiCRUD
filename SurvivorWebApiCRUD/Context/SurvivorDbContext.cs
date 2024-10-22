using Microsoft.EntityFrameworkCore;
using SurvivorWebApiCRUD.Entities;

namespace SurvivorWebApiCRUD.Context
{
    public class SurvivorDbContext : DbContext
    {
        public DbSet<CategoryEntity> Category => Set<CategoryEntity>();
        public DbSet<CompetitorEntity> Competitors => Set<CompetitorEntity>();

        public SurvivorDbContext(DbContextOptions<SurvivorDbContext>options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CompetitorEntity>()
                .HasOne(co => co.Category)
                .WithMany(ca => ca.Competitors)
                .HasForeignKey(co => co.CategoryId);

            modelBuilder.Entity<CompetitorEntity>(entity =>
            {
                entity.HasKey(co => co.Id);
                entity.Property(co => co.FirstName).HasMaxLength(25);
                entity.Property(co => co.LastName).HasMaxLength(25);
                
            });

            modelBuilder.Entity<CategoryEntity>(entity =>
            {
                entity.HasKey(ca => ca.Id);
                entity.Property(ca => ca.Name).HasMaxLength(25);
            });



        }
    }
}
