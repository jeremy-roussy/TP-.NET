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

            Genre SF, Classic, Romance, Thriller, Action, Politic, Jeunesse, Jurassic, Doc, School;
            bookDbContext.Genre.AddRange(
                SF = new Genre() { Id = 1, Type = "SF" },
                Classic = new Genre() { Id = 2, Type = "Classic" },
                Romance = new Genre() { Id = 3, Type = "Romance" },
                Thriller = new Genre() { Id = 4, Type = "Thriller" },
                Action = new Genre() { Id = 5, Type = "Action" },
                Politic = new Genre() { Id = 6, Type = "Politic" },
                Jeunesse = new Genre() { Id = 7, Type = "Jeunesse" },
                Jurassic = new Genre() { Id = 8, Type = "Jurassic" },
                Doc = new Genre() { Id = 9, Type = "Doc" },
                School = new Genre() { Id = 10, Type = "School" }
            );
            bookDbContext.SaveChanges();
            // Une fois les moèles complété Vous pouvez faire directement
            // new Book() { Author = "xxx", Name = "yyy", Price = n.nnf, Content = "ccc", Genres = new() { Romance, Thriller } }
            bookDbContext.Books.AddRange(
                new Book() { Title = "yyy", Price = 10.9F, Contenu = "HelloContenu", Genres = new List<Genre>() { Thriller } },
                new Book() { Title = "hhh", Price = 130, Contenu = "MAMAMAM", Genres = new List<Genre>() { Classic } },
                new Book() { Title = "b", Price = 10, Contenu = "vnvfdnvvjvkxvjdx", Genres = new List<Genre>() { Thriller } },
                new Book() { Title = "ab", Price = 11, Contenu = "hhello my name is John blablla bla", Genres = new List<Genre>() { Thriller } },
                new Book() { Title = "abc", Price = 12, Contenu = "jnjndsjncdjndndsjs", Genres = new List<Genre>() { Thriller } },
                new Book() { Title = "hello", Price = 13.5F, Contenu = "gbfbfbsbs", Genres = new List<Genre>() { Thriller, SF, Action } },
                new Book() { Title = "world", Price = 14, Contenu = "nyrgsdsbsd", Genres = new List<Genre>() { Thriller } },
                new Book() { Title = "this", Price = 15, Contenu = "xcsvfdgb", Genres = new List<Genre>() { Thriller } },
                new Book() { Title = "book", Price = 159, Contenu = "ijijjjijijijij", Genres = new List<Genre>() { Thriller } },
                new Book() { Title = "good", Price = 17, Contenu = "ddcdddd", Genres = new List<Genre>() { Thriller } },
                new Book() { Title = "bro", Price = 15.9F, Contenu = "cdccdcdcdc", Genres = new List<Genre>() { Thriller, Classic } },
                new Book() { Title = "wheel", Price = 15.9F, Contenu = "dcddcdcdcd", Genres = new List<Genre>() { Thriller } },
                new Book() { Title = "OKOK", Price = 18, Contenu = "dcvbbtnujuyntbr ", Genres = new List<Genre>() { Thriller, Classic } },
                new Book() { Title = "FINI", Price = 1, Contenu = "ertyuiuytre", Genres = new List<Genre>() { Thriller } }
            );
            // Vous pouvez initialiser la BDD ici

            bookDbContext.SaveChanges();
        }
    }
}