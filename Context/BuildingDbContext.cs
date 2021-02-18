using Microsoft.EntityFrameworkCore;
using BuildingRestAPI.Modles;
namespace BuildingRestAPI.Context
{
    public class BuildingDbContext : DbContext
    {
        public BuildingDbContext(DbContextOptions<BuildingDbContext> options) : base(options) { }

        public DbSet<Building> Buildings { get; set; }
       
    }
}
