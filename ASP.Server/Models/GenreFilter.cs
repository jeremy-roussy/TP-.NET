using System;
using System.Collections.Generic;
using System.Linq;

namespace ASP.Server.Model
{
	public class GenreFilter
	{
		public Genre Genre { init; private get; }
		public string Type { get; set; }

		public GenreFilter(Genre genre)
		{
			this.Genre = genre;
			this.Type = genre.Type;
		}
		public static List<GenreFilter> convertionListGenreFilter(ICollection<Genre> genres)
		{
			List<GenreFilter> listeARetourner = new List<GenreFilter>();
			foreach (Genre elem in genres)
			{
				listeARetourner.Add(new GenreFilter(elem));
			}
			return listeARetourner;
		}
	}	
}