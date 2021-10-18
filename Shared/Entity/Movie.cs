using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace ProjectMovies.Shared.Entity
{
    public class Movie
    { 
        public int Id{get;set;}
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public string MovieName {get;set;}
        public bool EnCartelera {get;set;}
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public string MovieCategory {get;set;}
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public string Trailer{get;set;}
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public string MovieSynopsis {get;set;}
        public string MovieImage {get;set;}
        [Required(ErrorMessage ="El campo {0} es requerido")] 
        public DateTime Premier {get;set;}
        public List <CategoryMovie> CategoriesMovie {get;set;} = new List <CategoryMovie> ();
        
    }
}