abstract class FoodItem
{
    private string _name;
    private string _desc;
    private int _quantity;

    public FoodItem() { }
    public FoodItem(string name, string desc, int quantity)
    {
        _name = name;
        _desc = desc;
        _quantity = quantity;
    }

    public string GetName() { return _name; }
    public string GetDesc() { return _desc; }
    public int GetQuantity() { return _quantity; }
    
    public abstract void Display();
    public abstract void Describe();
}