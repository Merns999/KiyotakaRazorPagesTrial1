using Kelvin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kelvin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [Route("Create"), HttpPost]
        public Result Create([FromBody] Anime anime)
        {

            var responce = new Result();

            responce.Message = $"{anime.Name} Added successfully";
            responce.Successful = true;

            return responce;
        }
    }
}
