using System;
namespace ConsoleApplication1
{
    interface ICalculation
    {
        double Perform();
    }
    class Add : ICalculation
    {
        private double a;
        private double b;
        public Add(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public double Perform()
        {
            return a + b;
        }
    }
    class Multiply : ICalculation
    {
        private double a;
        private double X;
        public Multiply(double a, double X)
        {
            this.a = a;
            this.X = X;
        }
        public double Perform()
        {
            return a * X;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число a=");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("введите величину b=");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("введите коэффициент Х=");
            double X = double.Parse(Console.ReadLine());
            Add calc1 = new Add(a, b);
            Multiply calc2 = new Multiply(a, X);
            Console.WriteLine("результат: {0} : {1}", calc1.Perform(), calc2.Perform());
            Console.ReadKey();
        }
    }
}
