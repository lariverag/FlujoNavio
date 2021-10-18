using System.Security.AccessControl;
using ProjectMovies.Shared.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ProjectMovies.Client.Services
{
    public interface ISeviceMovie
    {
         List<Movie> GetMovies();
         Task<HttpResponseWrapper<object>> Post<T>(string url, T send);
        Task<HttpResponseWrapper<TResponse>> Post<T,TResponse>(string url, T send);
        Task<HttpResponseWrapper<T>> Get<T>(string url);
    }
}