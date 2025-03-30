using System;

class Program
{
    static void Main(string[] args)
    {
        MealManager mealManager = new MealManager();
        Meal meal = new Meal("Frozen pizza", "A pizza with pineapple and ham", 1);
        Ingredient ingredient = new Ingredient("Cheese", "Really, really old milk", 1, "Cup");
        Nutrient nutrient = new Nutrient("Protein", "Good for building muscle", 2, "Grams");

        meal.AddIngredient(ingredient);
        ingredient.AddNutrient(nutrient);

        mealManager.AddMeal(meal);
        mealManager.DisplayMeals();
    }
}