using DISampleViewModels.Models;
using DISampleViewModels.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using TheBestMVVMFrameworkInTown.Core;

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
        }

        private Book _selectedBook;

        public Book SelectedBook
        {
            get => _selectedBook;
            set => SetProperty(ref _selectedBook, value);
        }


        public ObservableCollection<Book> Books { get; } = new ObservableCollection<Book>();

        public RelayCommand MessageCommand { get; }

        private async void OnMessage() => await _showMessageService.ShowMessageAsync("Hello from the view-model!");
    }
}
