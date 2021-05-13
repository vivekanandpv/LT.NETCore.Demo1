using LT.NETCore.Demo1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LT.NETCore.Demo1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        //  GET: get all
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new List<Book>());
        }

        //  GET: get with id
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(new Book { Id = id, Title = "Learning Asp.Net Core", Description = "Learner's book", Price = 500.50 });
        }

        //  POST
        [HttpPost]
        public IActionResult Create(Book book)
        {
            return Ok(new { Message = "Created", Payload = book });
        }

        //  PUT
        [HttpPut]
        public IActionResult Update(Book book)
        {
            return Ok(new { Message = "Update", Payload = book });
        }

        //  DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(new { Message = $"Deleted successfully: {id}" });
        }
    }
}
