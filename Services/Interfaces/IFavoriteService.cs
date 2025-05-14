using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IFavoriteService
    {
        void AddFavorite(Favorite favorite);
        public Favorite GetFavoriteById(int id);
        public Favorite GetFavorite(int userId, int recipeId);
        IEnumerable<Favorite> GetAllFavorites();
        void RemoveFavorite(int id);
    }
}
