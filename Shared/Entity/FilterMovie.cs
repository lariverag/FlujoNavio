using System.Collections.Generic;
namespace ProjectMovies.Shared.Entity
{
    public class FilterMovie
    {
        public List<Movie> PeliculasEnCartelera{get;set;}
        public List<Movie> ProximosEstrenos{get;set;}
    }
}