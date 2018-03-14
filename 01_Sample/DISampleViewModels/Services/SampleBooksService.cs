using DISampleViewModels.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DISampleViewModels.Services
{
    public class SampleBooksService : IBooksService
    {
        private List<Book> _books = new List<Book>()
        {
            new Book { BookId = 1, Title = "Professional C# 6", Publisher = "Wrox Press"},
            new Book { BookId = 2, Title = "Professional C# 7", Publisher = "Wrox Press"},
            new Book { BookId = 3, Title = "Enterprise Services", Publisher = "AWL"},
        };
        public SampleBooksService()
        {

        }

        public Task<IEnumerable<Book>> GetAllBooksAsync() => Task.FromResult<IEnumerable<Book>>(_books);
    }
}
