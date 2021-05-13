using LT.NETCore.Demo1.Models;
using LT.NETCore.Demo1.Services;
using LT.NETCore.Demo1.ViewModels;
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
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        //  GET: get all
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_bookService.Get());
        }

        //  GET: get with id
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_bookService.Get(id));
        }

        //  POST
        [HttpPost]
        public IActionResult Create(BookCreateViewModel viewModel)
        {
            _bookService.Create(viewModel);
            return Ok();
        }

        //  PUT
        [HttpPut]
        public IActionResult Update(BookUpdateViewModel viewModel)
        {
            _bookService.Update(viewModel);
            return Ok();
        }

        //  DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _bookService.Delete(id);
            return Ok();
        }
    }
}
