namespace JuiceMaker.Interfaces
{
    public interface IDrink
    {
        string Name { get; }
        bool IsCarbonated { get; }
        float Price { get; }
        string GetDescription();
    }
}
