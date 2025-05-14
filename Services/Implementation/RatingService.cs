using Models;
using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementation
{
    public class RatingService : IRatingService
    {
        private readonly IRatingRepository _ratingRepository;

        public RatingService(IRatingRepository ratingRepository)
        {
            _ratingRepository = ratingRepository;
        }

        public void AddRating(Rating rating)
        {
            _ratingRepository.AddRating(rating);
        }

        public Rating GetRatingById(int ratingId)
        {
            return _ratingRepository.GetRatingById(ratingId);
        }

        public IEnumerable<Rating> GetAllRatings()
        {
            return _ratingRepository.GetAllRatings();
        }

        public void UpdateRating(Rating rating)
        {
            _ratingRepository.UpdateRating(rating);
        }

        public void RemoveRating(int ratingId)
        {
            _ratingRepository.RemoveRating(ratingId);
        }
    }
}
