using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace ProjectMovies.Shared.Entity
{
    public class Movie
    { 
        public int MovieId{get;set;}
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public string MovieName {get;set;}
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public string MovieGender {get;set;}
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public string MovieSynopsis {get;set;}
        public string MovieImage {get;set;}
        [Required(ErrorMessage ="El campo {0} es requerido")] 
        public DateTime CurrentDate {get;set;}
    }
}