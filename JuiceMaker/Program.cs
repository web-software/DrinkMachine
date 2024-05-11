using System;
using JuiceMaker;
using JuiceMaker.Interfaces;
using JuiceMaker.Services;

namespace DrinkMachine
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Welcome to our drink machine! Here's what we're offering today:" + Environment.NewLine);
            var drinkService = new DrinkService();
            drinkService.DisplayDrinks();

            bool validSelection = false;
            int attempts = 0;
            while (!validSelection)
            {
                int selection = UserInteraction.GetUserSelection(drinkService.GetAllDrinks(), attempts > 0);
                if (selection == -1)
                {
                    UserInteraction.DisplayInvalidSelectionMessage();
                }
                else if (selection >= 1 && selection <= drinkService.GetDrinksCount())
                {
                    IDrink selectedDrink = drinkService.SelectDrink(selection - 1);
                    UserInteraction.DisplaySelectedDrinkMessage(selectedDrink);
                    validSelection = true;
                }
                else if (attempts > 0 && selection == drinkService.GetDrinksCount() + 1)
                {
                    UserInteraction.DisplayExitMessage();
                    return;
                }
                attempts++;
            }
            Console.Read(); // Keep the console open
        }
    }
}
