using System;
using System.Collections.Generic;
using DrinkMachine.Models;
using JuiceMaker.Interfaces;

namespace JuiceMaker.Services
{
    public class DrinkService
    {
        private readonly List<IDrink> drinks;

        public DrinkService()
        {
            drinks = new List<IDrink>
            {
                new Juice("Orange Juice", false, "oranges"),
                new Beer("Budweiser", true, 5.0f),
                new Soda("Pepsi", true)
            };
        }

        public List<IDrink> GetAllDrinks()
        {
            return new List<IDrink>(drinks);
        }

        public void DisplayDrinks()
        {
            foreach (var drink in drinks)
            {
                Console.WriteLine(drink.GetDescription());
            }
        }

        public int GetDrinksCount()
        {
            return drinks.Count;
        }

        public IDrink SelectDrink(int index)
        {
            return drinks[index];
        }
    }
}
