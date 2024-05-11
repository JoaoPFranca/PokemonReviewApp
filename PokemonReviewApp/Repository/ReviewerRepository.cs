using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    public class ReviewerRepository : IReviewerRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public ReviewerRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Reviewer GetReviewer(int reviewerId)
        {
            return _context.Reviewers.Where(r => r.Id == reviewerId).Include(e => e.Reviews).FirstOrDefault(); //We can use Include to literally include the reviews on the reviewer (The navigation property).
        }

        public ICollection<Reviewer> GetReviewers()
        {
            return _context.Reviewers.ToList();
        }

        public ICollection<Review> GetReviewsByReviewer(int id)
        {
            return _context.Reviews.Where(r => r.Reviewer.Id == id).ToList();
        }

        public bool ReviewerExists(int id)
        {
            return _context.Reviewers.Any(r => r.Id == id);
        }
    }
}
