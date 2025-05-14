using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IRatingService
    {
        public void AddRating(Rating rating);
        public Rating GetRatingById(int ratingId);
        public IEnumerable<Rating> GetAllRatings();
        public void UpdateRating(Rating rating);
        public void RemoveRating(int ratingId);
    }
}
