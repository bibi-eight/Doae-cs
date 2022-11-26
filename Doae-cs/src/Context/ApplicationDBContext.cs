using Doae.Models;
using Doae_api_cs;
using Microsoft.EntityFrameworkCore;

namespace Doae.database
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            
        }

        public DbSet<InstitutionModel> Institutions {get; set; } = default!;
        public DbSet<DonationModel> Donations {get; set; } = default!;
        public DbSet<TargetModel> Targets {get; set; } = default!;
        public DbSet<ProductModel> Products {get; set; } = default!;
        public DbSet<RelationModel> Relations {get; set; } = default!;
        public DbSet<PublicationModel> Publications {get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}