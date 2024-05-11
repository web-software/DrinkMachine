namespace DrinkMachine.Models
{
    public class Beer : Drink
    {
        public float AlcoholContent { get; }
        public override float Price => 5.00f;

        public Beer(string name, bool isCarbonated, float alcoholContent)
            : base(name, isCarbonated)
        {
            AlcoholContent = alcoholContent;
        }

        public override string GetDescription()
        {
            return $"{Name}, carbonated, {AlcoholContent:F1}% alcohol.";
        }
    }
}
