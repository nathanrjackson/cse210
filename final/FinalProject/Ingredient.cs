class Ingredient : FoodItem
{
    private List<Nutrient> _nutrients;
    private string _units;

    public Ingredient() { }
    public Ingredient(string name, string desc, int quantity, string units)
        : base(name, desc, quantity)
    {
        _nutrients = new List<Nutrient>();
        _units = units;
    }

    public override void Display() { { Console.WriteLine($"{GetName()} ({GetQuantity() } {_units})"); }}
    public override void Describe() { Console.WriteLine($"{GetDesc()}"); }

    public void AddNutrient(Nutrient nutrient) { _nutrients.Add(nutrient); }
    public void DisplayNutrients()
    {
        foreach (var nutrient in _nutrients)
        {
            nutrient.Display();
        }
    }
}