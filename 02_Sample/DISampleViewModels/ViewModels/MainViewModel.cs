using DISampleViewModels.Events;
using DISampleViewModels.Models;
using DISampleViewModels.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using TheBestMVVMFrameworkInTown.Core;
using TheBestMVVMFrameworkInTown.Events;

namespace DISampleViewModels.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private readonly IShowMessageService _showMessageService;
        private readonly IBooksService _booksService;
        public MainViewModel(IShowMessageService showMessageService, IBooksService booksService)
        {
            _showMessageService = showMessageService;
            _booksService = booksService;
            RefreshBooksAsync();
    
            MessageCommand = new RelayCommand(OnMessage);
        }

        private async void RefreshBooksAsync()
        {
            Books.Clear();
            var books = await _booksService.GetAllBooksAsync();
            foreach (var book in books)
            {
                Books.Add(book);
            }
            SelectedBook = books.FirstOrDefault();
        }

        private Book _selectedBook;

        public Book SelectedBook
        {
            get => _selectedBook;
            set
            {
                if (SetProperty(ref _selectedBook, value))
                {
                    EventAggregator<BookEventArgs>.Instance.Publish(this, new BookEventArgs { Book = _selectedBook });
                }
            }
        }

        public ObservableCollection<Book> Books { get; } = new ObservableCollection<Book>();

        public RelayCommand MessageCommand { get; }

        private async void OnMessage() => await _showMessageService.ShowMessageAsync("Hello from the view-model!");
    }
}
