using System.Collections.Generic;
using System.Collections.ObjectModel;
using WPF.Reader.Model;

namespace WPF.Reader.Service
{
    public class LibraryService
    {
        // A remplacer avec vos propre données !!!!!!!!!!!!!!
        // Pensé qu'il ne faut mieux ne pas réaffecter la variable Books, mais juste lui ajouer et / ou enlever des éléments
        // Donc pas de LibraryService.Instance.Books = ...
        // mais plutot LibraryService.Instance.Books.Add(...)
        // ou LibraryService.Instance.Books.Clear()

        public ObservableCollection<Genre> Genres { get; set; }

        public LibraryService()
        {
            Genre SF, Classic;
            SF = new Genre() { Type = "SF" };
            Classic = new Genre() { Type = "Classic" };
            Genres = new ObservableCollection<Genre>() { SF, Classic };

            Books = new ObservableCollection<Book>() {
                new Book() { Title = "yyy", Price = 10.9F, Contenu = "HelloContenu", Genres = new List<Genre>() { SF } },
                new Book() { Title = "hhh", Price = 130, Contenu = "MAMAMAM", Genres = new List<Genre>() { } },
                new Book() { Title = "b", Price = 10, Contenu = "vnvfdnvvjvkxvjdx", Genres = new List<Genre>() { } },
                new Book() { Title = "ab", Price = 11, Contenu = "hhello my name is John blablla bla", Genres = new List<Genre>() { } },
                new Book() { Title = "abc", Price = 12, Contenu = "jnjndsjncdjndndsjs", Genres = new List<Genre>() { } },
                new Book() { Title = "hello", Price = 13.5F, Contenu = "gbfbfbsbs", Genres = new List<Genre>() { } },
                new Book() { Title = "world", Price = 14, Contenu = "nyrgsdsbsd", Genres = new List<Genre>() { } },
                new Book() { Title = "this", Price = 15, Contenu = "xcsvfdgb", Genres = new List<Genre>() { } },
                new Book() { Title = "book", Price = 159, Contenu = "ijijjjijijijij", Genres = new List<Genre>() { } },
                new Book() { Title = "good", Price = 17, Contenu = "ddcdddd", Genres = new List<Genre>() { } },
                new Book() { Title = "bro", Price = 15.9F, Contenu = "cdccdcdcdc", Genres = new List<Genre>() { } },
                new Book() { Title = "wheel", Price = 15.9F, Contenu = "dcddcdcdcd", Genres = new List<Genre>() { } },
                new Book() { Title = "OKOK", Price = 18, Contenu = "dcvbbtnujuyntbr ", Genres = new List<Genre>() { } },
                new Book() { Title = "FINI", Price = 1, Contenu = "ertyuiuytre", Genres = new List<Genre>() { } }
            };
        }
            

        public ObservableCollection<Book> Books { get; set; }

        // C'est aussi ici que vous ajouterez les requète réseau pour récupérer les livres depuis le web service que vous avez fait
        // Vous pourrez alors ajouter les livres obtenu a la variable Books !

    }
}
