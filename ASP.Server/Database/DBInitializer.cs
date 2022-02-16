using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ASP.Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ASP.Server.Database
{
    public class DbInitializer
    {
        public static void Initialize(LibraryDbContext bookDbContext)
        {

            if (bookDbContext.Books.Any())
                return;

            Genre SF, Classic, Romance, Thriller;
            bookDbContext.Genre.AddRange(
                SF = new Genre() {Id = 1, Type = "SF"},
                Classic = new Genre() { Id = 2, Type = "Classic" },
                Romance = new Genre() { Id = 3, Type = "Romance" },
                Thriller = new Genre() { Id = 4, Type = "Thriller" }
            );
            bookDbContext.SaveChanges();

            // Une fois les moèles complété Vous pouvez faire directement
            // new Book() { Author = "xxx", Name = "yyy", Price = n.nnf, Content = "ccc", Genres = new() { Romance, Thriller } }
            bookDbContext.Books.AddRange(
                new Book() { Title = "yyy", Price = 10.9F, Contenu = "HelloContenu", Genres = new List<Genre>(){ Thriller }}, 
                new Book() { Title = "hhh", Price = 130, Contenu = "MAMAMAM", Genres = new List<Genre>() { Classic }}, 
                new Book() { Title = "yjjjyy", Price = 15.9F, Contenu = "CHEEEEE", Genres = new List<Genre>() { Thriller }}
            );
            // Vous pouvez initialiser la BDD ici

            bookDbContext.SaveChanges();
        }
    }
}