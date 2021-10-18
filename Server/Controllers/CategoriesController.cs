using System.Diagnostics.Contracts;
using System.ComponentModel.Design.Serialization;
using System.Threading;
using ProjectMovies.Shared.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ProjectMovies.Server.Controllers
{
    [ApiController]
    /* El [controller] tomara el nombre del controlador, en este caso CategoryController */
    [Route("api/[controller]")]

    public class CategoriesController: ControllerBase
    {
        private readonly ApplicationDbContext context;
        /* Para crear el registro en la base de datos, debemos inyectar el DbContext en el controlador */
        public CategoriesController(ApplicationDbContext context){
            this.context = context;
        }

        [HttpPost]

        /* La tarea retorna un int correspondiente al Id de la categoría creada */
        public async Task<ActionResult<int>> Post(Category category){
            /* Con el mètodo add agregamos el registro en la BD */
            context.Add(category);
            /* Aplicamos los cambios en la BD, para guardar cambios de forma asincrona con el await */
            await context.SaveChangesAsync();
            return category.Id;
        }
    }
}