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
interface ISort
{
    void SortAsc();
    void SortDesc();
    void SortByParam(bool isAsc);
}
class Array : IOutput, IMath, ISort
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
    public void SortAsc()
    {
        System.Array.Sort(numbers);
    }
    public void SortDesc()
    {
        System.Array.Sort(numbers);
        System.Array.Reverse(numbers);
    }
    public void SortByParam(bool isAsc)
    {
        if (isAsc)
        {
            SortAsc();
        }
        else
        {
            SortDesc();
        }
    }
}
class Program
{
    static void Main()
    {
        int[] prim = { 25, 10, 45, 5, 30 };
        Array arr = new Array(prim);
        arr.Show("Исходный массив:");
        arr.SortAsc();
        Console.WriteLine();
        arr.Show("Сортировка по возрастанию:");
        arr.SortDesc();
        Console.WriteLine();
        arr.Show("Сортировка по убыванию:");
        arr.SortByParam(true);
        Console.WriteLine();
        arr.Show("SortByParam(true):");
        arr.SortByParam(false);
        Console.WriteLine();
        arr.Show("SortByParam(false):");
        Console.WriteLine();
        Console.WriteLine("Максимум: " + arr.Max());
        Console.WriteLine("Минимум: " + arr.Min());
        Console.WriteLine("Среднее: " + arr.Avg());
        Console.WriteLine("Поиск 30: " + arr.Search(30));
        Console.WriteLine("Поиск 100: " + arr.Search(100));
    }
}