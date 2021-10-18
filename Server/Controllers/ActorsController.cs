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
    public class ActorsController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IFilesStorageClass FilesStorage;
        private readonly string carpeta = "actors";


        public ActorsController(ApplicationDbContext context,IFilesStorageClass filesStorage){
            this.context = context;
            this.FilesStorage = filesStorage;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Actor actor){
            if (!string.IsNullOrWhiteSpace(actor.Photo))
            {
                var actor_photo = Convert.FromBase64String(actor.Photo);
                actor.Photo = await FilesStorage.SaveFile(actor_photo,".jpg", carpeta);
            }
            context.Add(actor);
            await context.SaveChangesAsync();
            return actor.Id;
        }
    }
}