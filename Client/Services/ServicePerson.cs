using ProjectMovies.Shared.Entity;
using System.Collections.Generic;
using System;

namespace ProjectMovies.Client.Services
{
    public class ServicePerson: IServicePerson
    {
        public List<Actor> GetActors(){
            return new List<Actor>{
                new Actor(){Id =1, Name = "Actor 1", BirthDate =new DateTime(2021,11,23), Photo = "/Images/Person 6.jpg", KnowCredits=10},
                new Actor(){Id =2, Name = "Actor 2", BirthDate =new DateTime(2021,12,02), Photo  = "/Images/Person 2.jpg", KnowCredits=8},
                new Actor(){Id =3, Name = "Actor 3", BirthDate =new DateTime(2021,10,03), Photo = "/Images/Person 3.jpg", KnowCredits=9},
                new Actor(){Id =4, Name = "Actor 4", BirthDate =new DateTime(2021,11,23), Photo = "/Images/Person 4.jpg", KnowCredits=7},
                new Actor(){Id =5, Name = "Actor 5", BirthDate =new DateTime(2021,10,13), Photo = "/Images/Person 5.jpg", KnowCredits=8},
  
                };
          }
     }
}