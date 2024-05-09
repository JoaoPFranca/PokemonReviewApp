using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    //Repository -> Where database calls are made
    //Repository x Service -> Repository is where database is called. If it has any other type of functions, it is a Service (Service pattern)
    public class PokemonRepository : IPokemonRepository
    {
        private readonly DataContext _context;
        public PokemonRepository(DataContext context) 
        { 
            _context = context;
        }

        //ICollection is different than list. ICollections can only be shown. They can't be edited.
        public ICollection<Pokemon> GetPokemons() 
        {
            return _context.Pokemon.OrderBy(p => p.Id).ToList();
        }

    }
}
