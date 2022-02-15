using System;

public class GenreFilter
{
	public GenreFilter()
	{
		public Genre Genre { init; private get; }
		public string Type { get => Genre.ToString() }
		public List<BookLite> Books { get => Genre.Books.Select(x => new BookLite() { Books = x }).ToList(); }
	}
}
