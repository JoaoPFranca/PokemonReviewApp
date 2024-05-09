namespace PokemonReviewApp.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Review> Reviews { get; set; } //One-To-Many
        public ICollection<PokemonOwner> PokemonOwners { get; set; } //Many-To-Many. Basically, I'm doing a One-To-Many with a join table.
        public ICollection<PokemonCategory> PokemonCategories { get; set; } //Many-To-Many. Basically, I'm doing a One-To-Many with a join table.
    }
}
