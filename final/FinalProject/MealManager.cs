class MealManager
{
    private List<Meal> _mealsList;

    public MealManager() { _mealsList = new List<Meal>(); }

    public Meal GetMeal(int index) { return _mealsList[index]; }
    public void AddMeal(Meal meal) { _mealsList.Add(meal); }
    public void RemoveMeal(string name)
    {
        if (_mealsList.Count > 0) { _mealsList.RemoveAll(meal => meal.GetName() == name); }
        else { Console.WriteLine("No meals have been added."); }
    }
    public void DisplayMeals()
    {
        int placeHolder = 1;
        
        foreach (var meal in _mealsList)
        {
            Console.Write($"{placeHolder}. ");
            meal.Display();
            placeHolder += 1;
        }
    }
}