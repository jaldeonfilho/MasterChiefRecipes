using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repository.Interfaces;
using Repository;


namespace Service.Implementation
{
    public class IngredientService : IIngredientService
    {
        private readonly IIngredientRepository _ingredientRepository;

        public IngredientService(IIngredientRepository ingredientRepository)
        {
            _ingredientRepository = ingredientRepository;
        }

        public void AddIngredient(Ingredient ingredient)
        {
            _ingredientRepository.AddIngredient(ingredient);
        }

        public IEnumerable<Ingredient> GetAllIngredients()
        {
            return _ingredientRepository.GetAllIngredients();
        }

        public Ingredient GetIngredientById(int ingredientId)
        {
            return _ingredientRepository.GetIngredientById(ingredientId);
        }

        public void RemoveIngredient(int ingredientId)
        {
            _ingredientRepository.RemoveIngredient(ingredientId);
        }
    }
}
