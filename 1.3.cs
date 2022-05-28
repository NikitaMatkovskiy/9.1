using System;
namespace ConsoleApplication1
{
    interface IVector
    {
        void Size();
        int Get(int index);
    }
    class Vector2 : IVector
    {
        public int xn2, yn2, xk2, yk2;
        public Vector2(int xn2, int yn2, int xk2, int yk2)
        {
            this.xn2 = xn2;
            this.yn2 = yn2;
            this.xk2 = xk2;
            this.yk2 = yk2;
        }
        public int A()
        {
            return xk2 - xn2; //AB = {Bx - Ax; By - Ay}
        }
        public int B()
        {
            return yk2 - yn2;
        }

        public void Size()
        {
            Console.WriteLine("вектор = {0} :{1}", A(), B());
        }
        public int Get(int index)
        {
            return 1;
        }
    }
    class Vector3 : IVector
    {
        public int xn3, yn3, zn3, xk3, yk3, zk3;
        public Vector3(int xn3, int yn3, int zn3, int xk3, int yk3, int zk3)
        {
            this.xn3 = xn3;
            this.yn3 = yn3;
            this.zn3 = zn3;
            this.xk3 = xk3;
            this.yk3 = yk3;
            this.zk3 = zk3;
        }
        public int C()                  //{Dx - Cx; Dy - Cy; Dz - Cz} 
        {
            return xk3 - xn3;
        }
        public int D()
        {
            return yk3 - yn3;
        }
        public int E()
        {
            return zk3 - zn3;
        }
        public void Size()
        {
            Console.WriteLine("вектор = {0} :{1} : {2}", C(), D(), E());
        }
        public int Get(int index)
        {
            return 1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("координаты начальной точки x,y двумерного вектора");
            int xn2 = int.Parse(Console.ReadLine());
            int yn2 = int.Parse(Console.ReadLine());
            Console.WriteLine("координаты конечной точки x,y двумерного вектора");
            int xk2 = int.Parse(Console.ReadLine());
            int yk2 = int.Parse(Console.ReadLine());
            Vector2 AB = new Vector2(xn2, yn2, xk2, yk2);

            Console.WriteLine("координаты начальной точки x,y,z трехмерного вектора");
            int xn3 = int.Parse(Console.ReadLine());
            int yn3 = int.Parse(Console.ReadLine());
            int zn3 = int.Parse(Console.ReadLine());
            Console.WriteLine("координаты конечной точки x,y,z трехмерного вектора");
            int xk3 = int.Parse(Console.ReadLine());
            int yk3 = int.Parse(Console.ReadLine());
            int zk3 = int.Parse(Console.ReadLine());
            Vector3 CD = new Vector3(xn3, yn3, zn3, xk3, yk3, zk3);


            AB.Size();
            CD.Size();


            int ScalarProduct = ((xk2 - xn2) * (xk3 - xn3)) + ((yk2 - yn2) * (yk3 - yn3));//ABx • CDx + ABy • CDy + (ABz • CDz)=0
            Console.WriteLine("скалярное произведение {0}", ScalarProduct);
            Console.ReadKey();
        }
    }

}
