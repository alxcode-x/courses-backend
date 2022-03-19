using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using QuotesAPI.Data;
using QuotesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuotesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuotesController : ControllerBase
    {
        private QuotesDbContext _quotesDbContext;

        public QuotesController(QuotesDbContext quotesDbContext)
        {
            _quotesDbContext = quotesDbContext;
        }

        // GET: api/<QuotesController>
        //[HttpGet]
        //public IActionResult Get()
        //{
        //    return Ok(_quotesDbContext.Quotes);
        //    //return StatusCode(200);
        //    //return StatusCode(StatusCodes.Status200OK);
        //}

        [HttpGet]
        [ResponseCache(Duration = 60, Location = ResponseCacheLocation.Any)]
        public IActionResult Get(string sort)
        {
            IQueryable<Quote> quotes;
            switch (sort)
            {
                case "desc":
                    quotes = _quotesDbContext.Quotes.OrderByDescending(q => q.CreatedAt);
                    break;
                case "asc":
                    quotes = _quotesDbContext.Quotes.OrderBy(q => q.CreatedAt);
                    break;
                default:
                    quotes = _quotesDbContext.Quotes;
                    break;
            }

            return Ok(quotes);
        }


        // GET api/<QuotesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var entity = _quotesDbContext.Quotes.Find(id);

            if (entity == null)
                return NotFound($"Id {id} does not exist");
            else
                return Ok(entity);
        }

        [HttpGet("[action]")]
        public IActionResult Paging(int? pageNumber, int? pageSize)
        {
            var quotes = _quotesDbContext.Quotes.OrderBy(q => q.Id);
            var currentPageNumber = pageNumber ?? 1;
            var currentPageSize = pageSize ?? 5;

            return Ok(quotes.Skip((currentPageNumber - 1) * currentPageSize).Take(currentPageSize));
        }


        [HttpGet("[action]")]
        public IActionResult Searching(string type)
        {
            return Ok(_quotesDbContext.Quotes.Where(q => q.Type.Contains(type)));
        }
        
        #region Routing example
        //Get api/quotes/test/id
        [HttpGet("[action]/{id}")]
        public int Test(int id)
        {
            return id;
        }
        #endregion

        // POST api/<QuotesController>
        [HttpPost]
        public IActionResult Post([FromBody] Quote quote)
        {
            _quotesDbContext.Quotes.Add(quote);
            _quotesDbContext.SaveChanges();

            return StatusCode(StatusCodes.Status201Created);
        }

        // PUT api/<QuotesController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Quote quote)
        {
            var entity = _quotesDbContext.Quotes.Find(id);

            if (entity == null)
            {
                return NotFound($"Id {id} does not exist");
            }
            else
            {
                entity.Title = quote.Title;
                entity.Author = quote.Author;
                entity.Description = quote.Description;
                entity.Type = quote.Type;
                entity.CreatedAt = quote.CreatedAt;

                _quotesDbContext.SaveChanges();

                return Ok("Record updated successfully!");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var entity = _quotesDbContext.Quotes.Find(id);

            if (entity == null)
            {
                return NotFound($"Id {id} does not exist");
            }
            else
            {
                _quotesDbContext.Quotes.Remove(_quotesDbContext.Quotes.Find(id));
                _quotesDbContext.SaveChanges();
                return Ok("Record has been removed");
            }
        }
    }
}
