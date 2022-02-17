using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WPF.Reader.Model
{
    public class Genre
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Key]
        public int Id { get; set; }

        // Mettez ici les propriété de votre livre: Nom et Livres associés
        public string Type { get; set; }
        //[JsonIgnore]
        public ICollection<Book> Books { get; set; }
    }
}
