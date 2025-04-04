class Cart
{
    private List<Meal> _cartList;

    public Cart() { _cartList = new List<Meal>(); }

    public void AddMeal(Meal meal) { _cartList.Add(meal); }
    public void RemoveMeal(int index) { _cartList.RemoveAt(index); }
    public void Display()
    {
        int placeHolder = 1;

        foreach (var item in _cartList)
        {
            Console.Write($"{placeHolder}. ");
            item.Display();
            placeHolder += 1;
        }
    }
    public void DisplayItems()
    {
        foreach (var meal in _cartList)
        {
            meal.DisplayIngredients(false);
        }
    }
}