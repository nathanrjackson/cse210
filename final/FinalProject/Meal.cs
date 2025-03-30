class Meal : FoodItem
{
    private List<Ingredient> _ingredients;

    public Meal() { }
    public Meal(string name, string desc, int quantity)
        : base(name, desc, quantity)
    {
        _ingredients = new List<Ingredient>();
    }

    public override void Display() { Console.WriteLine($"{GetName()} - {GetDesc()}"); }
    public override void Describe() { Console.WriteLine($"{GetDesc()}"); }
    
    public void AddIngredient(Ingredient ingredient) { _ingredients.Add(ingredient); }
    public void DisplayIngredients()
    {
        foreach (var ingredient in _ingredients)
        {
            ingredient.Display();
        }
    }
}