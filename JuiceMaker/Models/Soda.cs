namespace DrinkMachine.Models
{
    public class Soda : Drink
    {
        public override float Price => 3.50f;

        public Soda(string name, bool isCarbonated)
            : base(name, isCarbonated)
        {
        }

        public override string GetDescription()
        {
            return $"{Name}, carbonated.";
        }
    }
}
