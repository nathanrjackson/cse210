class Nutrient : FoodItem
{
    private string _units;

    public Nutrient() { }
    public Nutrient(string name, string desc, int quantity, string units)
        : base(name, desc, quantity)
    {
        _units = units;
    }

    public override void Display() { { Console.WriteLine($"{GetName()} ({GetQuantity() } {_units})"); }}
    public override void Describe() { Console.WriteLine($"{GetDesc()}"); }
}