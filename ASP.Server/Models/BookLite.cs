using System;
using System.Collections.Generic;
using System.Linq;


namespace ASP.Server.Model
{
	public class BookLite
	{
        public Book Book { init; private get; }
		public long Id { get; set; }
		public string Title { get; set; }
		public float Price { get; set; }

		public List<GenreFilter> Genre { get => Book.Genres.Select(x => new GenreFilter() { Genre = x }).ToList(); } 

		public BookLite(Book book)
        {
			this.Book = book;
			this.Id = book.Id;
			this.Title = book.Title;
			this.Price = book.Price;
        }

		public BookLite() { }
    }
}

