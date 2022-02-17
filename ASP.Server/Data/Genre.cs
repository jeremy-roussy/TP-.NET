﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace ASP.Server.Model
{
    public class Genre
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Key]
        public int Id { get; set; }

        // Mettez ici les propriété de votre livre: Nom et Livres associés
        public string Type { get; set; }
        [JsonIgnore]
        public ICollection<Book> Books { get; set; }
        // N'oublier pas qu'un genre peut avoir plusieur livres
    }

}

