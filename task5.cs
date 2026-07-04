interface IDrivable
{
    void StartEngine();
    void StopEngine();
    void Drive();
}
class Car : IDrivable
{
    public void StartEngine()
    {
        Console.WriteLine("Двигатель автомобиля вкл");
    }
    public void StopEngine()
    {
        Console.WriteLine("Двигатель автомобиля выкл");
    }
    public void Drive()
    {
        Console.WriteLine("Автомобиль едет");
    }
}
class Motorcycle : IDrivable
{
    public void StartEngine()
    {
        Console.WriteLine("Двигатель мотоцикла вкл");
    }

    public void StopEngine()
    {
        Console.WriteLine("Двигатель мотоцикла выкл");
    }
    public void Drive()
    {
        Console.WriteLine("Мотоцикл едет");
    }
}
class Program
{
    static void Main()
    {
        Car car = new Car();
        Motorcycle motorcycle = new Motorcycle();
        Console.WriteLine("Автомобиль:");
        car.StartEngine();
        car.Drive();
        car.StopEngine();
        Console.WriteLine();
        Console.WriteLine("Мотоцикл:");
        motorcycle.StartEngine();
        motorcycle.Drive();
        motorcycle.StopEngine();
    }
}