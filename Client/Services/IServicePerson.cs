using System.Collections.Generic;
using System.Security.AccessControl;
using ProjectMovies.Shared.Entity;

namespace ProjectMovies.Client.Services
{
    public interface IServicePerson
    {
         List<Actor> GetActors();
    }
}