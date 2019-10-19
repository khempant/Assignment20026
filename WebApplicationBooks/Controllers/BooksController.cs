using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryOfBooks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static LibraryOfBooks.Books;

namespace WebApplicationBooks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        public static List<Books> BookList = new List<Books>
        {
            new Books("SocialStudies","Khem",108,"1239567896542"),
            new Books("HealthScience","Ganga",98,"1234767896943"),
            new Books("Games","Boris",58,"1234562965743"),
            new Books("Algebra","Michel",231,"1234568896513"),
            new Books("MusicsStudies","William",65,"1234567896842"),

        };
        // GET: api/Book
        [HttpGet]
        public ActionResult<IEnumerable<Books>> Get()
        {
            return BookList;
        }

        // GET: api/Book/5
        [HttpGet("{id}")]
        public ActionResult<Books> Get(string id)
        {
            return BookList.Find(e => e.Isbn13 == id);
        }

        // POST: api/Book
        [HttpPost]
        public void Post([FromBody] Books newBookList)
        {
            BookList.Add(newBookList);
        }

        // PUT: api/Book/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Books newBookList)
        {
            Delete(id);
            Post(newBookList);
        }

        private void Delete(string id)
        {
            BookList.RemoveAll(e => e.Isbn13 == id);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
