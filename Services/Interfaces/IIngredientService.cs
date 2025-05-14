﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;


namespace Service.Interfaces
{
    public interface IIngredientService
    {
        void AddIngredient(Ingredient ingredient);
        IEnumerable<Ingredient> GetAllIngredients();
        Ingredient GetIngredientById(int ingredientId);
        void RemoveIngredient(int ingredientId);
    }
}
