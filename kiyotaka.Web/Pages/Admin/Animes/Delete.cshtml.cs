using kiyotaka.Web.Data;
using kiyotaka.Web.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace kiyotaka.Web.Pages.Admin.Animes
{
    [Authorize]
    public class DeleteModel : PageModel
    {
        private readonly kiyotakaDbContext context;
        [BindProperty]
        public DeleteAnimeVM deleteAnimeVM { get; set; }

        public DeleteModel(kiyotakaDbContext context)
        {
            this.context = context;
        }

        public void OnGet()
        {
        }
        public void OnPost(Guid Id)
        {
            var exists = context.AnimeHubs.Find(Id);
            if(exists != null)
            {
                context.Remove(exists);
                context.SaveChanges();
            }

            ViewData["Message"] = "Anime deleted Succefully";
        }

    }
}
