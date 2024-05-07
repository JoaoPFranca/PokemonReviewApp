namespace PokemonReviewApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<PokemonCategory> PokemonCategories { get; set; } //Many-To-Many. Basically, I'm doing a One-To-Many with a join table.
    }
}
