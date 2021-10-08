using System;
using ProjectMovies.Shared.Entity;
using System.Collections.Generic;

namespace ProjectMovies.Client.Services
{
    public class ServiceMovie: ISeviceMovie
    {
        public List<Movie>GetMovies(){
            return new List<Movie>(){

                new Movie(){ MovieId= 1,MovieName = "Kin",MovieGender = "Drama",MovieSynopsis = "Sinopsis de la pelicula",MovieImage = "/Images/Kin.PNG", CurrentDate= new DateTime(2021,10,10) },
                new Movie(){ MovieId= 2,MovieName = "Lamb",MovieGender = "Drama",MovieSynopsis = "Sinopsis de la pelicula",MovieImage = "/Images/Lamb.PNG", CurrentDate= new DateTime(2021,10,08)},
                new Movie(){ MovieId= 3,MovieName = "Mass",MovieGender = "Drama",MovieSynopsis = "Sinopsis de la pelicula",MovieImage = "/Images/mass.PNG", CurrentDate= new DateTime(2021,11,05)}, 
                new Movie(){ MovieId= 4,MovieName = "Titane",MovieGender = "Drama",MovieSynopsis = "Sinopsis de la pelicula",MovieImage = "/Images/Titane.PNG", CurrentDate= new DateTime(2021,10,16)},
                new Movie(){ MovieId= 5,MovieName = "Halloween Kills",MovieGender = "Terror",MovieSynopsis = "Sinopsis de la pelicula",MovieImage = "/Images/Halloween kills.PNG", CurrentDate= new DateTime(2021,11,01)}, 
                new Movie(){ MovieId= 6,MovieName = "The Velvet",MovieGender = "Musical",MovieSynopsis = "Sinopsis de la pelicula",MovieImage = "/Images/Thevelvet.PNG", CurrentDate= new DateTime(2021,10,18)},  
                new Movie(){ MovieId= 7,MovieName = "Venom",MovieGender = "Ciencia Ficción",MovieSynopsis = "Sinopsis de la pelicula",MovieImage = "/Images/Venom.PNG", CurrentDate= new DateTime(2021,11,23)},};}
        }
    }
