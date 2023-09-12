using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace blablib.Controllers
{
    /// <summary>
    /// A book controller
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        // GET: api/<BookController>
        /// <summary>
        /// Get all books
        /// </summary>
        /// <returns>book objects</returns>
        /// <response code="200">
        /// Return good
        /// </response>
        /// <response code="400">
        /// Return bad request
        /// </response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetBooks()
        {
            return Ok(new Book[] { new Book {Name="not null", Title="null" }, new Book {Name="asd",Title="asd" } });
        }

        // Get api/<BookController>/5
        /// <summary>
        /// Get a Specific book from an ID
        /// </summary>
        /// <param name="id">Id on a book</param>
        /// <returns>a book</returns>
        /// <response code="200">
        /// Return good
        /// </response>
        /// <response code="400">
        /// Return bad request
        /// </response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Get(int id)
        {
            return Ok(new Book { Name="name", Title="a" });
        }


        /// <summary>
        /// Filter books from a name or title or both
        /// </summary>
        /// <param name="name">The name of a book</param>
        /// <param name="title">The title of a book</param>
        /// <returns>a book</returns>
        /// <response code="200">
        /// Return good
        /// </response>
        /// <response code="400">
        /// Return bad request
        /// </response>
        [HttpGet("Filter")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetFilterByName(string? name, string? title)
        {
            var books = new Book[] { new Book { Name = "name", Title = "a" } };
            if (!String.IsNullOrEmpty(name))
                return Ok(books.Where(book => book.Name.Contains(name)));
            else if (!String.IsNullOrEmpty(title))
                return Ok(books.Where(book => book.Name.Contains(title)));
            else
                return BadRequest();
        }





        /// <summary>
        /// update a Specific book from an ID
        /// </summary>
        /// <param name="bookId">Id on a book</param>
        /// <param name="book">A Book</param>
        /// <returns>a boolean</returns>
        /// <response code="200">
        /// Return good
        /// </response>
        /// <response code="400">
        /// Return bad request
        /// </response>
        /// /// <response code="404">
        /// Return Book not found
        /// </response>
        [HttpPut("{bookId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdateBook(int bookId, [FromBody] Book book)
        {
            return Ok(true);
        }

        /// <summary>
        /// create a Specific book from an ID
        /// </summary>
        /// <param name="book">A book object</param>
        /// <returns>a boolean</returns>
        /// <response code="200">
        /// Return good
        /// </response>
        /// <response code="400">
        /// Return bad request
        /// </response>
        /// /// <response code="201">
        /// The book was created successfully 
        /// </response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult CreateBook([FromBody] Book book)
        {
            return Created("",true);
        }

        /// <summary>
        /// Delete a Specific book from an ID
        /// </summary>
        /// <param name="bookId">Id on a book</param>
        /// <returns>a boolean</returns>
        /// <response code="200">
        /// Return good
        /// </response>
        /// <response code="400">
        /// Return bad request
        /// </response>
        /// /// <response code="404">
        /// Return Book not found
        /// </response>
        [HttpDelete("{bookId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteBook(int bookId)
        {
            return BadRequest("Not there: " + bookId);
        }

        
    }
}
