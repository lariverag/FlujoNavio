using ProjectMovies.Shared.Entity;
using System.Collections.Generic;

namespace ProjectMovies.Client.Services
{
    public interface ISeviceMovie
    {
         List<Movie> GetMovies();
    }
}