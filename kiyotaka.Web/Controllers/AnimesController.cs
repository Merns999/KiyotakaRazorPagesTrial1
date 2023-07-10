using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using kiyotaka.Web.Data;
using kiyotaka.Web.Models.Domain;
using kiyotaka.Web.Data.EFCore;

namespace kiyotaka.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimesController : MyAnimeController<AnimeHub,EfCoreAnimeRepository>
    {
        //private readonly kiyotakaDbContext _context;

        public AnimesController(EfCoreAnimeRepository repository) :base(repository)
        {
             
        }

        
    }
}
