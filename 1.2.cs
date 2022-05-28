using System;
namespace ConsoleApplication1
{
    interface IPolynomial
    {
        bool IsAbove(bool point);
        bool IsBelow(bool point);
    }
    class Linear : IPolynomial
    {
        private double x1, y1, x, a, b;
        public double y;
        public Linear(double x1, double y1, double a, double b, double x)
        {
            this.y1 = y1;
            this.x1 = x1;
            this.a = a;
            this.b = b;
            this.x = x;
        }
        public double FuncLine()
        {
            y = a * x + b;
            return y;
        }
        public bool IsAbove(bool point)
        {
            if (FuncLine() < y1) return true;
            else return false;
        }
        public bool IsBelow(bool point)
        {
            if (FuncLine() > y1) return true;
            else return false;
        }
    }
    class Quadratic : IPolynomial
    {
        private double y1, x1, x, a, b, c;
        public double y;
        public Quadratic(double x1, double y1, double x, double a, double b, double c)
        {
            this.y1 = y1;
            this.x1 = x1;
            this.x = x;
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double FuncQuad()
        {
            y = a * x * x + b * x + c;
            return y;
        }
        public bool IsAbove(bool point)
        {
            if (FuncQuad() < y1) return true;
            else return false;
        }
        public bool IsBelow(bool point)
        {
            if (FuncQuad() > y1) return true;
            else return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("координаты точки x,y");
            double x1 = int.Parse(Console.ReadLine());
            double y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("введите переменную x");
            double x = int.Parse(Console.ReadLine());
            Console.WriteLine("введите коэффициент а");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("введите коэффициент b");
            double b = int.Parse(Console.ReadLine());
            Console.WriteLine("введите коэффициент c");
            double c = int.Parse(Console.ReadLine());
            Linear L = new Linear(x1, y1, a, b, x);
            Quadratic Q = new Quadratic(x1, y1, x, a, b, c);
            static bool IsBetween(IPolynomial L, IPolynomial Q)
            {
                if ((L.IsBelow(true) == true && Q.IsAbove(true)) == true || (Q.IsBelow(true) == true && L.IsAbove(true) == true))
                    return true;
                else
                    return false;
            }
            if (IsBetween(L, Q) == true)
                Console.WriteLine("Точка лежит между функциями.");
            else
                Console.WriteLine("Точка не лежит между функциями.");

            if (L.IsAbove(true) == true) { Console.WriteLine("Точка находится над графиком многочлена"); } else Console.WriteLine("Точка находится под графиком многочлена");
            if (Q.IsAbove(true) == true) { Console.WriteLine("Точка находится над графиком многочлена"); } else Console.WriteLine("Точка находится под графиком многочлена");
            Console.ReadKey();

        }
    }

}
