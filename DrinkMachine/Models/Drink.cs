using DrinkMachine.Interfaces;

namespace DrinkMachine.Models
{
    public abstract class Drink : IDrink
    {
        public string Name { get; }
        public bool IsCarbonated { get; }
        public abstract float Price { get; }

        protected Drink(string name, bool isCarbonated)
        {
            Name = name;
            IsCarbonated = isCarbonated;
        }

        public abstract string GetDescription();
    }
}
