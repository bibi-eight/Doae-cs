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
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        internal Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}