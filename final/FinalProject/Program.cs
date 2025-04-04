class Program
{
    static void Main(string[] args)
    {
        // Create menu
        Menu menu = new Menu();
        
        // Display meal creation menu:
        Console.WriteLine("\nMeal creation options:");
        menu.DisplayMealMenu();

        // Display cart menu:
        Console.WriteLine("\nCart menu options:");
        menu.DisplayCartMenu();

        // Create meal manager
        MealManager mealManager = new MealManager();

        /* ------------------------------------------------------------------------------------------------*/

        // Create meal 1
        Meal meal1 = new Meal("Fried chicken", "Chicken coated in a nice batter and fried to perfection", 1);

        // Create ingredients for meal 1
        Ingredient ingredient11 = new Ingredient("Chicken", "Lean and healthy", 500, "Grams");
        Ingredient ingredient12 = new Ingredient("Flour", "Ground up grain or something", 100, "Grams");
        Ingredient ingredient13 = new Ingredient("Oil", "Oi, eel! Get it?", 250, "milliliters");

        // Create nutrients for ingredients for meal 1
        Nutrient nutrient11 = new Nutrient("Protein", "Good for building muscle", 30, "Grams");
        Nutrient nutrient12 = new Nutrient("Carbohydrates", "I believe you don't want too many of these...", 100, "Grams");
        Nutrient nutrient13 = new Nutrient("Fat", "Uh-oh...", 15, "Grams");

        // Add nutrients to ingredients for meal 1
        ingredient11.AddNutrient(nutrient11);
        ingredient12.AddNutrient(nutrient12);
        ingredient13.AddNutrient(nutrient13);

        // Add ingredients for meal 1
        meal1.AddIngredient(ingredient11);
        meal1.AddIngredient(ingredient12);
        meal1.AddIngredient(ingredient13);

        // Add meal 1 to meal manager
        mealManager.AddMeal(meal1);

        /* ------------------------------------------------------------------------------------------------*/

        // Create meal 2
        Meal meal2 = new Meal("Potato soup", "A warm, creamy soup made from Erdaepfel", 1);

        // Create ingredients for meal 2
        Ingredient ingredient21 = new Ingredient("Potatoes", "Welcome to Idaho", 2, "Kiliograms");
        Ingredient ingredient22 = new Ingredient("Chicken stock", "Smart investments made by poultry", 500, "Milliliters");
        Ingredient ingredient23 = new Ingredient("Bacon", "Fatty, but very good taste", 8, "Strips");

        // Create nutrients for ingredients for meal 2
        Nutrient nutrient21 = new Nutrient("Carbohydrates", "I believe you don't want too many of these...", 250, "Grams");
        Nutrient nutrient22 = new Nutrient("Sodium", "A sodding great thing! Kind of...", 150, "Milligrams");
        Nutrient nutrient23 = new Nutrient("Fat", "Uh-oh...", 15, "Grams");

        // Add nutrients to ingredients for meal 2
        ingredient21.AddNutrient(nutrient21);
        ingredient22.AddNutrient(nutrient22);
        ingredient23.AddNutrient(nutrient23);

        // Add ingredients for meal 2
        meal2.AddIngredient(ingredient21);
        meal2.AddIngredient(ingredient22);
        meal2.AddIngredient(ingredient23);

        // Add meal 1 to meal manager
        mealManager.AddMeal(meal2);

        /* ------------------------------------------------------------------------------------------------*/

        // Display all meals
        Console.WriteLine("\nAll meals:");
        mealManager.DisplayMeals();

        // Display all ingredients for meal 1
        Console.WriteLine("\nAll ingredients for meal 1:");
        meal1.DisplayIngredients();

        // Display all nutrients for meal 1
        Console.WriteLine("\nAll nutrients for meal 1");
        meal1.DisplayAllNutrients();
        
        // Display the first ingredient for meal 1
        Console.WriteLine("\nFirst ingredient for meal 1:");
        meal1.DisplayOneIngredient(0);

        /* ------------------------------------------------------------------------------------------------*/

        // Create cart
        Cart cart = new Cart();

        // Display all meals
        Console.WriteLine("\nAll meals:");
        mealManager.DisplayMeals();

        // Get first meal
        Meal mealToAdd = mealManager.GetMeal(0);

        // Add first meal to cart
        cart.AddMeal(mealToAdd);

        // Display cart
        Console.WriteLine("\nCart:");
        cart.Display();

        // Display items in cart
        Console.WriteLine("\nItems in cart:");
        cart.DisplayItems();
    }
}