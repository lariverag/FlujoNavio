using System.ComponentModel.DataAnnotations;
namespace ProjectMovies.Shared.Entity
{
    public class Category
    {
        public int Id {get;set;}
        [Required(ErrorMessage="El campo {0} es requerido")]
        public string CategoryType{get;set;}
        
    }
}