﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuotesAPI.Models;

namespace QuotesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuotesFixController : ControllerBase
    {
        static List<Quote> quotes = new List<Quote>()
        {
            new Quote(){ Id = 0, Author = "Emuly Dickinson", Description = "The brain is wider than the sky.", Title = "Inspirational"},
            new Quote(){ Id = 1, Author = "Richard Bach", Description = "True love stories never have endings.", Title = "Love Stories"}
        };

        [HttpGet]
        public IEnumerable<Quote> Get()
        {
            return quotes;
        }

        [HttpPost]
        public void Post([FromBody]Quote quote)
        {
            quotes.Add(quote);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Quote quote)
        {
            quotes[id] = quote;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            quotes.RemoveAt(id);
        }
    }
}
