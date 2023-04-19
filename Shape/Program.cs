using Shape.Models;

class Programm
{
    public static void Main(string[] args)
    {
        Rectangle rectangle = new();
        rectangle.Width = 10;
        rectangle.Height = 5;

        Circle circle = new();
        circle.Radius = 5;

        Triangle triangle = new();
        triangle.Length = 5;
        triangle.Width = 5;

        Square square = new();
        square.Cote = 5;

        Shape.Models.Shape[] shapes = { rectangle, circle, triangle, square };

        AreaCalculator areaCaclculate = new();
        areaCaclculate.TotalArea(shapes);

        Console.ReadLine();
    }
}
