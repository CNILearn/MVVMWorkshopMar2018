using System;
using System.Collections.Generic;
using System.Text;

namespace TuplesSample
{
    public class Book
    {
        public Book(string title, string publisher)
        {
            Title = title;
            Publisher = publisher;
        }
        public string Title { get; }
        public string Publisher { get; }
    }

    public static class BookExtensions
    {
        public static void Deconstruct(this Book book, out string title, out string publisher)
        {
            title = book.Title;
            publisher = book.Publisher;
        }
    }
}
