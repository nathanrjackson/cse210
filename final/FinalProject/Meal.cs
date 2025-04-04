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
    
    public void AddIngredient(Ingredient ingredient) { _ingredients.Add(ingredient); }
    public void DisplayIngredients(bool numbered = true)
    {
        if (numbered)    
        {    
            int placeholder = 1;
            
            foreach (var ingredient in _ingredients)
            {
                Console.Write($"{placeholder}. ");
                ingredient.Display();
                placeholder += 1;
            }
        }
        else
        {
            foreach (var ingredient in _ingredients)
            {
                Console.Write("- ");
                ingredient.Display();
            } 
        }
    }
    public void DisplayOneIngredient(int index)
    {
        _ingredients[index].Display();
        _ingredients[index].DisplayNutrients();
    }
    public void DisplayAllNutrients()
    {
        foreach (var ingredient in _ingredients)
        {
            ingredient.DisplayNutrients();
        }
    }
}