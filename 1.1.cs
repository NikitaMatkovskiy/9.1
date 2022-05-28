using System;

interface ISequence
{
    double GetElement();
}
class ArithmeticProgression : ISequence
{
    private int k;
    private int x;
    private int n, r;
    public ArithmeticProgression(int k, int x, int n, int r)
    {
        this.k = k;
        this.x = x;
        this.n = n;
        this.r = r;
    }

    public double GetElement()
    {
        int[] array = new int[n];
        for (int i = 1; i < n; i++)
        {
            array[0] = x;
            array[i] = array[i - 1] + r;
        }
        return array[k - 1];
    }
    public int Sum()
    {
        int[] array = new int[n];
        for (int i = 1; i < n; i++)
        {
            array[0] = x;
            array[i] = array[i - 1] + r;
        }
        int sum = 0;
        for (int i = 0; i < k; i++)
        { sum = array[i] + sum; }
        return sum;
    }
    public override string ToString()
    {
        return string.Format("сумма чисел последовательности до выбранного элемента{0}", Sum());
    }
}
class GeometricProgression : ISequence
{
    private int k;
    private int x;
    private int n, z;
    public GeometricProgression(int k, int x, int n, int z)
    {
        this.k = k;
        this.x = x;
        this.n = n;
        this.z = z;
    }
    public double GetElement()
    {

        int[] array = new int[n];
        for (int i = 1; i < n; i++)
        {
            array[0] = x;
            array[i] = (int)(array[i - 1] * Math.Pow(z, i));
        }
        return array[k - 1];
    }
    public int Sum()
    {
        int[] array = new int[n];
        for (int i = 1; i < n; i++)
        {
            array[0] = x;
            array[i] = (int)(array[i - 1] * Math.Pow(z, i));
        }
        int sum = 0;
        for (int i = 0; i < k; i++)
        { sum = array[i] + sum; }
        return sum;
    }
    public override string ToString()
    {
        return string.Format("сумма чисел последовательности до выбранного элемента{0}", Sum());
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("введите номер  возвращающий элемент последовательности");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine("введите первый элемент прогрессии");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("введите количество элементов прогрессии");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("введите разность элементов арифметической прогрессии");
        int r = int.Parse(Console.ReadLine());
        Console.WriteLine("введите знаменатель элементов геометрической прогрессии");
        int z = int.Parse(Console.ReadLine());
        ArithmeticProgression A = new ArithmeticProgression(k, x, n, r);
        GeometricProgression G = new GeometricProgression(k, x, n, z);
        Console.WriteLine("{0};  {1}", A.GetElement(), A.ToString());
        Console.WriteLine("{0};  {1}", G.GetElement(), G.ToString());
        Console.ReadKey();
    }
}
