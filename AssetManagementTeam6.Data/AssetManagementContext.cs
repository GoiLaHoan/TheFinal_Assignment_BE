using AssetManagementTeam6.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AssetManagementTeam6.Data 
{
    public class AssetManagementContext : DbContext
    {
        public AssetManagementContext(DbContextOptions<AssetManagementContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<RequestForReturn> RequestsForReturn { get; set; }
        public DbSet<Report> Reports { get; set; }
    }
}
