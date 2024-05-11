using System;
using System.Collections.Generic;
using JuiceMaker.Interfaces;

namespace JuiceMaker
{
    public static class UserInteraction
    {
        public static int GetUserSelection(List<IDrink> drinks, bool showExitOption)
        {
            Console.WriteLine(Environment.NewLine + "Please enter the number corresponding to the drink you would like:");

            for (int i = 0; i < drinks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {drinks[i].Name}");
            }

            if (showExitOption)
            {
                Console.WriteLine($"{drinks.Count + 1}. Nevermind");
            }

            Console.WriteLine();

            return int.TryParse(Console.ReadLine(), out int selection) ? selection : -1;
        }


        public static void DisplayInvalidSelectionMessage()
        {
            Console.WriteLine("Invalid selection. Please enter a valid number from the list.");
        }

        public static void DisplaySelectedDrinkMessage(IDrink drink)
        {
            Console.WriteLine($"{Environment.NewLine}You selected: {drink.GetDescription()}");
            Console.WriteLine($"That's a great option! The cost is ${drink.Price:F2}");
        }

        public static void DisplayExitMessage()
        {
            Console.WriteLine($"{Environment.NewLine}Okay, no worries. Thanks for stopping by. Have a great day!");
            Console.Read();
        }
    }

}
