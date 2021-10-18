using System.ComponentModel.Design.Serialization;
using System.Runtime.CompilerServices;
using System.Threading;
using ProjectMovies.Shared.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectMovies.Server.Storage;


namespace ProjectMovies.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IFilesStorageClass FilesStorage;
        private readonly string carpeta = "movies";


        public MoviesController(ApplicationDbContext context,IFilesStorageClass filesStorage){
            this.context = context;
            this.FilesStorage = filesStorage;
        }

        /*Almacenar informeción*/
        [HttpPost]
        public async Task<ActionResult<int>> Post(Movie movie){
            if (!string.IsNullOrWhiteSpace(movie.MovieImage))
            {
                var movie_poster = Convert.FromBase64String(movie.MovieImage);
                movie.MovieImage = await FilesStorage.SaveFile(movie_poster,".jpg", carpeta);
            }
            context.Add(movie);
            await context.SaveChangesAsync();
            return movie.Id;
        }

        /*Listar peliculas*/
        /*[HttpGet]

        public async Task <ActionResult<FilterMovie>> Get(){
            var limit =10;
            /*var peliculasEnCartelera = await context.Movies.Where(x=> x.EnCartelera).Take(limit).OrderByDescending(x => x.Premier);*/
            /*var CurrentDate =DateTime.Today;var proximosEstrenos = await context.Movies.Where (x=> x.Premier> CurrentDate).OrderBy(x=> x.Premier).Take(limit).ToListAsync();*/
            /*var response =newFilterMovie();{
                PeliculasEnCartelera = peliculasEnCartelera;
                ProximosEstrenos = proximosEstrenos;
            };
            return response;
            }
            [HttpGet("{id}")]
            public async Task<ActionResult<>>Get(int id){
                var movie = await Context.Movies.where();
            }*/
        }
}

