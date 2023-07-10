using kiyotaka.Web.Data;
using kiyotaka.Web.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace kiyotaka.Web.Controllers
{
    public class MyAnimeController<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;

        public MyAnimeController(TRepository repository)
        {
            this.repository = repository;
        }


        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            return await repository.GetAll();
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(Guid id)
        {
            var movie = await repository.Get(id);
            if (movie == null)
            {
                return NotFound();
            }
            return movie;
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, TEntity anime)
        {
            if (id != anime.Id)
            {
                return BadRequest();
            }
            await repository.Update(anime);
            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity anime)
        {
            await repository.Add(anime);
            return CreatedAtAction("Get", new { id = anime.Id }, anime);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(Guid id)
        {
            var anime = await repository.Delete(id);
            if (anime == null)
            {
                return NotFound();
            }
            return anime;
        }

    }
}
