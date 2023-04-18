using Shape.Models;

class Programm
{
    public static void Main(string[] args)
    {
        Rectangle rectangle = new();
        rectangle.Widht = 10;
        rectangle.Height = 5;

        Circle circle = new();
        circle.Radius = 5;

        Triangle triangle = new();
        triangle.CoteLeft = 5;
        triangle.CoteRight = 5;
        triangle.CoteDown = 5;

        object[] shapes = { rectangle, circle, triangle };

        AreaCalculator areaCaclculate = new();
        areaCaclculate.TotalArea(shapes);
    }
}
