using kiyotaka.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace kiyotaka.Web.Data
{
    public class kiyotakaDbContext : DbContext
    {
        public kiyotakaDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AnimeHub> AnimeHubs { get; set; }//will be used by entity framework core when creating tables in mysqldb
        public DbSet<Tag> Tags { get; set; }
    }
}
