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

        object[] shapes = { rectangle, circle };

        AreaCalculator areaCaclculate = new();
        areaCaclculate.TotalArea(shapes);
    }
}
