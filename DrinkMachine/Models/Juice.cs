namespace DrinkMachine.Models
{
    public class Juice : Drink
    {
        public string Fruit { get; }
        public override float Price => 2.50f;

        public Juice(string name, bool isCarbonated, string fruit)
            : base(name, isCarbonated)
        {
            Fruit = fruit;
        }

        public override string GetDescription()
        {
            return $"{Name}, not carbonated, made from {Fruit}.";
        }
    }
}
