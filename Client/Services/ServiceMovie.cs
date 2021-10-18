using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ProjectMovies.Shared.Entity;


namespace ProjectMovies.Client.Services
{
    public class ServiceMovie: ISeviceMovie
    {
        private readonly HttpClient httpClient;

        public ServiceMovie(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        private JsonSerializerOptions OpcionesPorDefectoJSON =>new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

   
/* METODOS CREAR */
        public async Task<HttpResponseWrapper<object>> Post<T>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, enviarContent);
            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
        }
/* Los siguientes dos métodos nos permitiran obtener el Id de la pelicula que acabo de crear */
        private async Task<T> DeserializarRespuesta<T>(HttpResponseMessage httpResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseString, jsonSerializerOptions);
        }

      public async Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, enviarContent);
            if (responseHttp.IsSuccessStatusCode)
            {
                var response = await DeserializarRespuesta<TResponse>(responseHttp, OpcionesPorDefectoJSON);
                return new HttpResponseWrapper<TResponse>(response, false, responseHttp);
            }
            else
            {
                return new HttpResponseWrapper<TResponse>(default, true, responseHttp);
            }
        }


/* METODO CONSULTAR */
     public async Task<HttpResponseWrapper<T>> Get<T>(string url)
        {
            var responseHTTP = await httpClient.GetAsync(url);
            if (responseHTTP.IsSuccessStatusCode)
            {
                var response = await DeserializarRespuesta<T>(responseHTTP, OpcionesPorDefectoJSON);
                return new HttpResponseWrapper<T>(response, false, responseHTTP);
            }
            else
            {
                return new HttpResponseWrapper<T>(default, true, responseHTTP);
            }
        }
        public async Task<HttpResponseWrapper<object>> Put<T>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PutAsync(url, enviarContent);
            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
        }

        

        public async Task<HttpResponseWrapper<object>> Delete(string url)
        {
            var responseHTTP = await httpClient.DeleteAsync(url);
            return new HttpResponseWrapper<object>(null, !responseHTTP.IsSuccessStatusCode, responseHTTP);
        }

        public List<Movie>GetMovies(){
            return new List<Movie>(){

                new Movie(){ Id= 1,MovieName = "Kin",MovieCategory = "Drama",MovieSynopsis = "Sinopsis de la pelicula",MovieImage = "/Images/Kin.PNG", Premier= new DateTime(2021,10,10) },
                new Movie(){ Id= 2,MovieName = "Lamb",MovieCategory = "Drama",MovieSynopsis = "Sinopsis de la pelicula",MovieImage = "/Images/Lamb.PNG", Premier= new DateTime(2021,10,08)},
                new Movie(){ Id= 3,MovieName = "Mass",MovieCategory = "Drama",MovieSynopsis = "Sinopsis de la pelicula",MovieImage = "/Images/mass.PNG", Premier= new DateTime(2021,11,05)}, 
                new Movie(){ Id= 4,MovieName = "Titane",MovieCategory = "Drama",MovieSynopsis = "Sinopsis de la pelicula",MovieImage = "/Images/Titane.PNG", Premier= new DateTime(2021,10,16)},
                new Movie(){ Id= 5,MovieName = "Halloween Kills",MovieCategory = "Terror",MovieSynopsis = "Sinopsis de la pelicula",MovieImage = "/Images/Halloween kills.PNG", Premier= new DateTime(2021,11,01)}, 
                new Movie(){ Id= 6,MovieName = "The Velvet",MovieCategory = "Musical",MovieSynopsis = "Sinopsis de la pelicula",MovieImage = "/Images/Thevelvet.PNG", Premier= new DateTime(2021,10,18)},  
                new Movie(){ Id= 7,MovieName = "Venom",MovieCategory = "Ciencia Ficción",MovieSynopsis = "Sinopsis de la pelicula",MovieImage = "/Images/Venom.PNG", Premier= new DateTime(2021,11,23)},};}
        }
    }
