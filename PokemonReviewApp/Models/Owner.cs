namespace PokemonReviewApp.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gym { get; set; }

        public Country Country { get; set; } //One-To-Many

        public ICollection<PokemonOwner> PokemonOwners { get; set; } //Many-To-Many. Basically, I'm doing a One-To-Many with a join table.
    }
}
