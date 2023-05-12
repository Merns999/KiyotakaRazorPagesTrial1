using kiyotaka.Web.Data;
using kiyotaka.Web.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kiyotaka.Web.Pages.Admin.Animes
{
    public class ListModel : PageModel
    {
        //a dbcontext object 
        private readonly kiyotakaDbContext kiyotakaDbContext;

        public List<AnimeHub> animes { get; set; }

        public ListModel(kiyotakaDbContext kiyotakaDbContext)
        {
            this.kiyotakaDbContext = kiyotakaDbContext;
        }

        public void OnGet()
        {
            animes = kiyotakaDbContext.AnimeHubs.ToList();
        }
    }
}
