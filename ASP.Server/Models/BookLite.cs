using System;

public class BookLite
{
	public BookLite()
	{
		public Book Book { init; private get; }
		public string Title { get => Book.Title }
		public List<GenreFilter> Genre { get => Book.Genres.Select(x => new GenreFilter() { Genres = x }).ToList(); }
	}
}
