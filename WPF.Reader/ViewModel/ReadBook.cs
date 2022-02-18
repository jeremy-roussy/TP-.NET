using Microsoft.Toolkit.Mvvm.DependencyInjection;
using System.ComponentModel;
using WPF.Reader.Model;
using WPF.Reader.Service;

namespace WPF.Reader.ViewModel
{
    class ReadBook : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // A vous de jouer maintenant
        public Book CurrentBook { get; init; }

        public ReadBook(Book book)
        {
            CurrentBook = Ioc.Default.GetRequiredService<LibraryService>().GetBookAPI(book.Id) ;
        }

    }

    /* Cette classe sert juste a afficher des donnée de test dans le designer */
    class InDesignReadBook : ReadBook
    {
        public InDesignReadBook() : base(new Book() { /*Title = "test"*/ }) { }        
    }
}
