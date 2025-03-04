class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", 5);
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        Console.WriteLine();

        Rectangle rectangle = new Rectangle("blue", 5, 3);
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());

        Console.WriteLine();

        Circle circle = new Circle("green", 5);
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());
    }
}