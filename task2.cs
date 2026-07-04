interface IOutput
{
    void Show();
    void Show(string info);
}
interface IMath
{
    int Max();
    int Min();
    float Avg();
    bool Search(int valueToSearch);
}
class Array : IOutput, IMath
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
    public int Max()
    {
        int max = numbers[0];
        foreach (int item in numbers)
        {
            if (item > max)
            {
                max = item;
            }
        }
        return max;
    }
    public int Min()
    {
        int min = numbers[0];
        foreach (int item in numbers)
        {
            if (item < min)
            {
                min = item;
            }    
        }
        return min;
    }
    public float Avg()
    {
        int sum = 0;
        foreach (int item in numbers)
        {
            sum += item;
        }
        return (float)sum / numbers.Length;
    }
    public bool Search(int valueToSearch)
    {
        foreach (int item in numbers)
        {
            if (item == valueToSearch)
            {
                return true;
            }
        }
        return false;
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
        Console.Write();
        Console.WriteLine("Максимум: " + arr.Max());
        Console.WriteLine("Минимум: " + arr.Min());
        Console.WriteLine("Среднее: " + arr.Avg());
        Console.WriteLine("Поиск числа 33: " + arr.Search(33));
        Console.WriteLine("Поиск числа 99: " + arr.Search(99));
    }
}