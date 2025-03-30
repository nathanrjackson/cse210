class MealManager
{
    private List<Meal> _meals;

    public MealManager()
    {
        _meals = new List<Meal>();
    }

    public void AddMeal(Meal meal)
    {
        _meals.Add(meal);
    }
    public void RemoveMeal(string name)
    {
        if (_meals.Count > 0) { _meals.RemoveAll(meal => meal.GetName() == name); }
        else { Console.WriteLine("No meals have been added."); }
    }
    public void DisplayMeals()
    {
        foreach (var meal in _meals)
        {
            meal.Display();
        }
    }
}