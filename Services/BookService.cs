using LT.NETCore.Demo1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LT.NETCore.Demo1.Services
{
    public class BookService : IBookService
    {
        public void Create(BookCreateViewModel viewModel)
        {
            
        }

        public void Delete(int id)
        {
            
        }

        public IEnumerable<BookListViewModel> Get()
        {
            return new List<BookListViewModel>();
        }

        public BookListViewModel Get(int id)
        {
            return new BookListViewModel
            {
                Description = "Learner's book",
                Title = "Learning Asp.Net Core",
                Price = 987.50,
                Id = id
            };
        }

        public void Update(BookUpdateViewModel viewModel)
        {
            
        }
    }
}
