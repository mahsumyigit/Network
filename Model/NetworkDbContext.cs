using Microsoft.EntityFrameworkCore;

namespace network
{
    public class NetworkDbContext : DbContext
    {
        public DbSet<Team>? Teams { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<TeamDetails>? TeamDetails { get; set; }





        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));
            optionsBuilder.UseMySql("server=localhost;database=sahabt;user=root;port=3306;password=toortoor", serverVersion);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            NetworkDatabaseBuilder.TableBuilder(modelBuilder);
        }
    }
}