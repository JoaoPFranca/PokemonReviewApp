using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface ICategoryRepository
    {
        //Get/Read
        ICollection<Category> GetCategories();
        Category GetCategory(int id);
        ICollection<Pokemon> GetPokemonByCategory(int id);
        bool CategoryExists(int id); //Makes validation a lot easier

        //Post/Create
        bool CreateCategory(Category category);

        //PUT/Update
        bool UpdateCategory(Category category);

        //DELETE
        bool DeleteCategory(Category category);

        bool Save();
    }
}
