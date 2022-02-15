using System;
using System.Collections.Generic;
using System.Linq;


namespace ASP.Server.Model
{
	public class BookLite
	{ 
		public Book Book { init; private get; }
		public string Title { get => Book.Title; }
		public List<GenreFilter> Genre { get => Book.Genres.Select(x => new GenreFilter() { Genre = x }).ToList(); }
	}
}

