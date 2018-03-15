using System.Collections.Generic;
using System.Threading.Tasks;
using DISampleViewModels.Models;

namespace DISampleViewModels.Services
{
    public interface IBooksService
    {
        Task<IEnumerable<Book>> GetAllBooksAsync();
    }
}