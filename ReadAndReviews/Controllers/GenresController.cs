using Managers.Services;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace ReadAndReviews.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IGenreService _genreService;

        public GenresController(IGenreService genreManager)
        {
            _genreService = genreManager;
        }

        [HttpPut]
        public ActionResult AddGenre(string name)
        {
            _genreService.AddGenre(name);

            Genre genre = _genreService.GetGenres().Last();
            return CreatedAtAction(nameof(GetGenre), new { Id = genre.Id}, genre);
        }

        [HttpGet("{id}")]
        public ActionResult<Genre> GetGenre(int id)
        {
            return _genreService.GetGenre(id) switch
            {
                null => NotFound(),
                var genre => Ok(genre)
            };
        }

        [HttpGet]
        public OkObjectResult GetGenres()
        {
            return Ok(_genreService.GetGenres());
        }
    }
}
