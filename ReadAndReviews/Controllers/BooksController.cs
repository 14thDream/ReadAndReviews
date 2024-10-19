using Managers.Services;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace ReadAndReviews.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookManager;

        public BooksController(IBookService bookManager)
        {
            _bookManager = bookManager;
        }

        [HttpPut]
        public CreatedAtActionResult AddBook(Book book)
        {
            _bookManager.AddBook(book);

            IEnumerable<Book> books = _bookManager.GetBooks();
            return CreatedAtAction(nameof(GetBook), new { Id = books.Count() }, book);
        }

        [HttpGet]
        public OkObjectResult GetBooks()
        {
            return Ok(_bookManager.GetBooks());
        }

        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            return _bookManager.GetBook(id) switch
            {
                null => NotFound(),
                var book => Ok(book)
            };
        }

        [HttpPost("{id}")]
        public ActionResult UpdateSummary(int id, string summary)
        {
            return _bookManager.UpdateSummary(id, summary) switch
            {
                null => NotFound(),
                _ => NoContent()
            };
        }
    }
}
