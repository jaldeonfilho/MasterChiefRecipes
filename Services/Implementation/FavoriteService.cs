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
    public class FavoriteService : IFavoriteService
    {
        private readonly IFavoriteRepository _favoriteRepository;

        public FavoriteService(IFavoriteRepository favoriteRepository)
        {
            _favoriteRepository = favoriteRepository;
        }

        public void AddFavorite(Favorite favorite)
        {
            _favoriteRepository.AddFavorite(favorite);
        }

        public Favorite GetFavoriteById(int id)
        {
            return _favoriteRepository.GetFavoriteById(id);
        }
        public Favorite GetFavorite(int userId, int recipeId)
        {
            return _favoriteRepository.GetFavorite(userId, recipeId);
        }

        public IEnumerable<Favorite> GetAllFavorites()
        {
            return _favoriteRepository.GetAllFavorites();
        }

        public void RemoveFavorite(int id)
        {
            _favoriteRepository.RemoveFavorite(id);
        }
    }
}
