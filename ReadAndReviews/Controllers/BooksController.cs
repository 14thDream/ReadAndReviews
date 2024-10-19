using Managers.Services;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace ReadAndReviews.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpPut]
        public CreatedAtActionResult AddBook(Book book)
        {
            _bookService.AddBook(book);

            IEnumerable<Book> books = _bookService.GetBooks();
            return CreatedAtAction(nameof(GetBook), new { Id = books.Count() }, book);
        }

        [HttpGet]
        public OkObjectResult GetBooks()
        {
            return Ok(_bookService.GetBooks());
        }

        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            return _bookService.GetBook(id) switch
            {
                null => NotFound(),
                var book => Ok(book)
            };
        }

        [HttpPost("{id}")]
        public ActionResult UpdateSummary(int id, string summary)
        {
            return _bookService.UpdateSummary(id, summary) switch
            {
                null => NotFound(),
                _ => NoContent()
            };
        }
    }
}
