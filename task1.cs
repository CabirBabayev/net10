interface IOutput
{       
    void Show();
    void Show(string info);
}
class Array : IOutput
{
    private int[] numbers;
    public Array(int[] numbers)
    {
        this.numbers = numbers;
    }
    public void Show()
    {
        Console.WriteLine("Элементы массива:");
        foreach (int item in numbers)
        {
            Console.Write(item + " ");
        }
    }
    public void Show(string info)
    {
        Console.WriteLine(info);
        foreach (int item in numbers)
        {
            Console.Write(item + " ");
        }
    }
}
class Program
{
    static void Main()
    {
        int[] prim = { 11, 22, 33, 44, 55 };
        Array arr = new Array(prim);
        arr.Show();
        Console.WriteLine();
        arr.Show("Иформация какой-то");
    }
}