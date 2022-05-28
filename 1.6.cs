using System;
namespace ConsoleApplication1
{
    interface IShape
    {
        void Perimeter();
        void Area();
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
        private double P()
        {
            return a + b + c;
        }
        private double p()
        {
            return P() / 2;
        }
        private double S()
        {
            return Math.Sqrt(p() * (p() - a) * (p() - b) * (p() - c));
        }
        public void Perimeter()
        {
            Console.WriteLine("периметр треугольника = {0}", P());
        }
        public void Area()
        {
            Console.WriteLine("площадь треугольника = {0}", S());
        }
    }
    class Disk : IShape
    {
        private double r;
        public Disk(double r)
        {
            this.r = r;
        }
        private double S()
        {
            return 2 * 3.14 * r * r;
        }
        private double P()
        {
            return 2 * 3.14 * r;
        }
        public void Perimeter()
        {
            Console.WriteLine("площадь круга = {0}", S());
        }
        public void Area()
        {
            Console.WriteLine("периметр круга = {0}", P());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите сторону треугольника а=");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("введите сторону треугольника b=");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("введите сторону треугольника c=");
            double c = double.Parse(Console.ReadLine());
            Triangle vivodTriangle = new Triangle(a, b, c);
            Console.WriteLine("введите радиус цилиндра r=");
            double r = double.Parse(Console.ReadLine());
            Disk vivodDisk = new Disk(r);

            vivodTriangle.Perimeter();
            vivodTriangle.Area();

            vivodDisk.Perimeter();
            vivodDisk.Area();
        }
    }
}
