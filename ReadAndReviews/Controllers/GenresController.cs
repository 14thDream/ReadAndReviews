using Managers;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace ReadAndReviews.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IGenreManager _genreManager;

        public GenresController(IGenreManager genreManager)
        {
            _genreManager = genreManager;
        }

        [HttpPut]
        public ActionResult AddGenre(string name)
        {
            _genreManager.AddGenre(name);

            Genre genre = _genreManager.GetGenres().Last();
            return CreatedAtAction(nameof(GetGenre), genre);
        }

        [HttpGet("{id}")]
        public ActionResult<Genre> GetGenre(int id)
        {
            return _genreManager.GetGenre(id) switch
            {
                null => NotFound(),
                var genre => Ok(genre)
            };
        }

        [HttpGet]
        public OkObjectResult GetGenres()
        {
            return Ok(_genreManager.GetGenres());
        }
    }
}
