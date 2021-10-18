namespace ProjectMovies.Shared.Entity
{
    public class CategoryMovie
    {
        public int MovieId {get;set;}
        public int CategoryId{get;set;}
        public Movie Movie{get;set;}
        public Category Category{get;set;} 
    }
}