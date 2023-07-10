using kiyotaka.Web.Data;
using kiyotaka.Web.Models.Domain;
using kiyotaka.Web.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client;

namespace kiyotaka.Web.Pages.Admin.Animes
{
    
    [Authorize]
    public class AddModel : PageModel
    {
        private readonly kiyotakaDbContext _kiyotakaDbContext;

        [BindProperty]
        public AddAnimes AddAnimesRequest { get; set; }

        public AddModel(kiyotakaDbContext kiyotakaDbContext)
        {
            _kiyotakaDbContext = kiyotakaDbContext;
        }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            var animes = new AnimeHub()
            {
                Heading = AddAnimesRequest.Heading,
                PageTitle = AddAnimesRequest.PageTitle,
                ShortDescription = AddAnimesRequest.ShortDescription,
                ImageUrl = AddAnimesRequest.ImageUrl,
                UrlHandle = AddAnimesRequest.UrlHandle,
                ReleaseDate = AddAnimesRequest.ReleaseDate,
                Visible = AddAnimesRequest.Visible
            };
            _kiyotakaDbContext.AnimeHubs.Add(animes);
            _kiyotakaDbContext.SaveChanges();

            ViewData["Message"] = "Player Added Succefully";
        }
    }
}
