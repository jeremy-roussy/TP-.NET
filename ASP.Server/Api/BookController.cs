using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASP.Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.Server.Database;

namespace ASP.Server.Api
{

    [Route("/api/[controller]/[action]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly LibraryDbContext libraryDbContext;

        public BookController(LibraryDbContext libraryDbContext)
        {
            this.libraryDbContext = libraryDbContext;
        }
    
    // Methode a ajouter : 
    // - GetBooks
    //   - Entrée: Optionel -> Liste d'Id de genre, limit -> defaut à 10, offset -> défaut à 0
    //     Le but de limit et offset est dé créer un pagination pour ne pas retourner la BDD en entier a chaque appel
    //   - Sortie: Liste d'object contenant uniquement: Auteur, Genres, Titre, Id, Prix
    //     la liste restourner doit être compsé des élément entre <offset> et <offset + limit>-
    //     Dans [1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20] si offset=8 et limit=5, les élément retourner seront : 8, 9, 10, 11, 12

    // - GetBook
    //   - Entrée: Id du livre
    //   - Sortie: Object livre entier

    // - GetGenres
    //   - Entrée: Rien
    //   - Sortie: Liste des genres

    // Aide:
    // Pour récupéré un objet d'une table :
    //   - libraryDbContext.MyObjectCollection.<Selecteurs>.First()
    // Pour récupéré des objets d'une table :
    //   - libraryDbContext.MyObjectCollection.<Selecteurs>.ToList()
    // Pour faire une requète avec filtre:
    //   - libraryDbContext.MyObjectCollection.<Selecteurs>.Skip().<Selecteurs>
    //   - libraryDbContext.MyObjectCollection.<Selecteurs>.Take().<Selecteurs>
    //   - libraryDbContext.MyObjectCollection.<Selecteurs>.Where(x => x == y).<Selecteurs>
    // Pour récupérer une 2nd table depuis la base:
    //   - .Include(x => x.yyyyy)
    //     ou yyyyy est la propriété liant a une autre table a récupéré
    //
    // Exemple:
    //   - Ex: libraryDbContext.MyObjectCollection.Include(x => x.yyyyy).Where(x => x.yyyyyy.Contains(z)).Skip(i).Take(j).ToList()


    // Vous vous montre comment faire la 1er, a vous de la compléter et de faire les autres !
    public ActionResult<List<BookLite>> GetBooks(int? genreId, int lim =10, int offset =0 )
        {
            IEnumerable<Book> listBooks = libraryDbContext.Books.Include(x => x.Genres);
            if (genreId.HasValue)  //Test nullité de genreId
            {
                var genre = libraryDbContext.Genre.SingleOrDefault(x => x.Id == genreId.Value);
                if (genre != null) 
                { 
                    listBooks = listBooks.Where(x => x.Genres.Contains(genre)); 
                }
            }
            //Utiliser Lim et Offset
            if(offset <= 0 || offset >= listBooks.Count()) { 
                offset = 0; 
            }
            if(lim + offset >= listBooks.Count() || lim <= 0) { 
                lim = listBooks.Count() - offset; 
            }
            return listBooks.Select(book => new BookLite(book)).Skip(offset).Take(lim).ToList() ;
        }

        public ActionResult<Book> GetBook(int id)
        {
            var b = libraryDbContext.Books.Include(x => x.Genres).SingleOrDefault(x => x.Id == id);
            if (b == null)
            {
                return NotFound();
            }
            return b;
        }

        public ActionResult<List<Genre>> GetGenres()
        {
            IEnumerable<Genre> listGenres = libraryDbContext.Genre.ToList();
            List<Genre> genres = new List<Genre>();
            foreach (Genre genre in listGenres)
            {
                genres.Add(genre);
            }
            return genres;
        }
    }
}


///.Include(x => new List<GenreFilter>(new GenreFilter(x.Genres)) ) )=> tentative recuperation Genre.Type
/* Book book = libraryDbContext.Books.Single(x => x.Id == id);
 * libraryDbContext.Books.Single(x => x.Id == id);
if (book == null)
{
    return NotFound();
}
else
{
    List<String> genres = new List<string>();
    foreach (Genre genre in book.Genres)
    {
        genres.Add(genre.Type);
    }
    List<String> listeARendre = new List<string>() { book.Id.ToString(), book.Title, book.Price.ToString(), book.Contenu, genres.ToString() };
    return listeARendre;
}*/
