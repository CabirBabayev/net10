interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
}
class Circle : IShape
{
    private double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
    public double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }
}
class Rectangle : IShape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public double CalculateArea()
    {
        return width * height;
    }

    public double CalculatePerimeter()
    {
        return 2 * (width + height);
    }
}
class Triangle : IShape
{
    private double a, b, c;
    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public double CalculatePerimeter()
    {
        return a + b + c;
    }
    public double CalculateArea()
    {
        double p = CalculatePerimeter() / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(4, 6);
        Triangle triangle = new Triangle(3, 4, 5);
        Console.WriteLine("Круг");
        Console.WriteLine("Площадь: " + circle.CalculateArea());
        Console.WriteLine("Периметр: " + circle.CalculatePerimeter());
        Console.WriteLine();
        Console.WriteLine("Прямоугольник");
        Console.WriteLine("Площадь: " + rectangle.CalculateArea());
        Console.WriteLine("Периметр: " + rectangle.CalculatePerimeter());
        Console.WriteLine();
        Console.WriteLine("Треугольник");
        Console.WriteLine("Площадь: " + triangle.CalculateArea());
        Console.WriteLine("Периметр: " + triangle.CalculatePerimeter());
    }
}