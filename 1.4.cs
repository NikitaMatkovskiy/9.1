using System;
namespace ConsoleApplication1
{
    interface IISolid
    {
        void Volume();
        void SurfaceArea();
    }
    class Cube : IISolid
    {
        private double a;
        public Cube(double a)
        {
            this.a = a;
        }
        private double S()
        {
            return 6 * a * a;
        }
        private double V()
        {
            return a * a * a;
        }
        public void Volume()
        {
            Console.WriteLine("площадь поверхности куба = {0}", S());
        }
        public void SurfaceArea()
        {
            Console.WriteLine("объем куба = {0}", V());
        }
    }
    class Cylinder : IISolid
    {
        private double r, h;
        public Cylinder(double r, double h)
        {
            this.r = r;
            this.h = h;
        }
        private double S()
        {
            return 2 * 3.14 * r * (r + h);
        }
        private double V()
        {
            return 3.14 * r * r * h;
        }
        public void Volume()
        {
            Console.WriteLine("площадь цилиндра = {0}", S());
        }
        public void SurfaceArea()
        {
            Console.WriteLine("объем цилиндра = {0}", V());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите сторону куба а=");
            double a = double.Parse(Console.ReadLine());
            Cube vivodcub = new Cube(a);
            Console.WriteLine("введите радиус цилиндра r=");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("введите высоту цилиндра h=");
            double h = double.Parse(Console.ReadLine());
            Cylinder vivodcylonder = new Cylinder(r, h);

            vivodcub.Volume();
            vivodcub.SurfaceArea();

            vivodcylonder.Volume();
            vivodcylonder.SurfaceArea();
        }
    }
}
