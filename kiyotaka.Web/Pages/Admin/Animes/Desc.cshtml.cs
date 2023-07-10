using kiyotaka.Web.Data;
using kiyotaka.Web.Models.Domain;
using kiyotaka.Web.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kiyotaka.Web.Pages.Admin.Animes
{
    public class DescModel : PageModel
    {
        private readonly kiyotakaDbContext context;
        [BindProperty]
        public AnimeHub anime { get; set; }

        public DescModel(kiyotakaDbContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
        }
    }
}
