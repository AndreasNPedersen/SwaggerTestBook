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
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return new Book[] { new Book {Name="not null", Title="null" }, new Book {Name="asd",Title="asd" } };
        }

        // GET api/<BookController>/5

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
        [HttpPost("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Book Get(int id)
        {
            return new Book { Name="name", Title="a" };
        }

        
    }
}
