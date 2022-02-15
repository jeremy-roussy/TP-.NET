﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.Server.Model
{
    public class Genre
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Key]
        public int Id { get; set; }

        // Mettez ici les propriété de votre livre: Nom et Livres associés
        private string Type { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        // N'oublier pas qu'un genre peut avoir plusieur livres
    }

}

