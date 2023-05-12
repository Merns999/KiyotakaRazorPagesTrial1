using kiyotaka.Web.Data;
using kiyotaka.Web.Models.Domain;
using kiyotaka.Web.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kiyotaka.Web.Pages.Admin.Animes
{
    public class EditModel : PageModel
    {
        private readonly kiyotakaDbContext kiyotakaDbContext;

        public EditModel(kiyotakaDbContext kiyotakaDbContext)
        {
            this.kiyotakaDbContext = kiyotakaDbContext;
        }

        [BindProperty]
        public EditAnimeVM EditAnimesRequest { get; set; }


        public void OnGet()
        {
            
        }

        //public void OnGet(Guid Id)
        //{
        //    var anime = kiyotakaDbContext.AnimeHubs.Find(Id);
        //    if(anime != null)
        //    {
        //        EditAnimesRequest = new EditAnimeVM()
        //        {
        //            Id = anime.Id,
        //            Heading= anime.Heading,
        //            PageTitle= anime.PageTitle,
        //            ShortDescription=anime.ShortDescription,
        //            ImageUrl=anime.ImageUrl,
        //            UrlHandle=anime.UrlHandle,
        //            ReleaseDate=anime.ReleaseDate,
        //            Visible=anime.Visible
        //        };
               

        //    }
        //}
        //public void OnPost()
        //{
        //    if(EditAnimesRequest != null)
        //    {
        //        var existingAnime = kiyotakaDbContext.AnimeHubs.Find(EditAnimesRequest.Id);
        //        if(existingAnime != null)
        //        {
        //            existingAnime.Heading = EditAnimesRequest.Heading;
        //            existingAnime.PageTitle = EditAnimesRequest.PageTitle;
        //            existingAnime.ShortDescription = EditAnimesRequest.ShortDescription;
        //            existingAnime.ImageUrl = EditAnimesRequest.ImageUrl;
        //            existingAnime.UrlHandle = EditAnimesRequest.UrlHandle;
        //            existingAnime.ReleaseDate = EditAnimesRequest.ReleaseDate;
        //            existingAnime.Visible = EditAnimesRequest.Visible;

        //            kiyotakaDbContext.Update(existingAnime);
        //            kiyotakaDbContext.SaveChanges();

        //            ViewData["Message"] = "Anime Edited Succefully";
        //        }
        //    }
        //}
        public void OnPost()
        {

        }
    }
}
