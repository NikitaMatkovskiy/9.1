using System;
namespace ConsoleApplication1
{
    interface IEquation
    {
        void Roots();
    }
    
    class Linear : IEquation
    {
        private double a, b, c;
        public Linear(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double x()           //x=(-c-b)/a ax+b+c=0
        {
            return (-c - b) / a;
        }
        public void Roots()                     
        {
            Console.WriteLine("корень линейного уравнения Х={0}", x());
        }
    }
    class Quadratic : IEquation           // D = b*б − 4ac.       x1= ((-b+math.sqrt(D)))/(2*a)     x1= ((-b-math.sqrt(D)))/(2*a) 
    {
        private double a, b, c;
        public Quadratic(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double D()                  // если б=0   если -с/а>=0   x=+-math.sqrt(-c/a) если с<0 корней нет если -с/а>=0
        {                                   // если с=0 х1=0, х2=-(б/а)
            return (b * b) - 4 * a * c;
        }
        public double X1()
        {
            if ((D() < 0) || (b == 0 || c == 0)|| (b == 0 || (-c / -a < 0))) return 0;
            else if (b == 0 || (-c / a) >= 0) return Math.Sqrt(-(c / a));
            else return (-b + Math.Sqrt(D())) / (2 * a);

        }
        public double X2()
        {
            if ((D() < 0) || (b == 0 && c == 0) || (b == 0 || (-c / -a < 0))) return 0;            
            else if (b == 0 || (-c / a) >= 0) return -Math.Sqrt(-(c / a));
            else return (-b - Math.Sqrt(D())) / (2 * a);
        }
        
        public void Roots()                
        {
            Console.WriteLine("корень квадратного уравнения Х1={0}, Х2={1} ", X1(), X2());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите коэффициент a=");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("введите коэффициент b=");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("введите коэффициент с=");
            double c = double.Parse(Console.ReadLine());
            Linear line = new Linear(a, b, c);
            Quadratic quad = new Quadratic(a, b, c);

            line.Roots();
            quad.Roots();

            Console.ReadKey();
        }
    }
}
