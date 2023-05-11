using kiyotaka.Web.Models.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace kiyotaka.Web.Data
{
    public class kiyotakaDbContext : IdentityDbContext
    {
        public kiyotakaDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AnimeHub> AnimeHubs { get; set; }//will be used by entity framework core when creating tables in mysqldb
        public DbSet<Tag> Tags { get; set; }
    }
}
