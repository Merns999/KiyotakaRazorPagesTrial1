using kiyotaka.Web.Models.Domain;

namespace kiyotaka.Web.Data.EFCore
{
    public class EfCoreAnimeRepository: EfCoreRepository<AnimeHub,kiyotakaDbContext >
    {
        public EfCoreAnimeRepository(kiyotakaDbContext context) : base(context)
        {

        }
    }
}
