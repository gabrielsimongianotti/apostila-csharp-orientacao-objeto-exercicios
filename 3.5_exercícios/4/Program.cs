using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = 0;
            double a = 0;
            double c = 0;

            Console.WriteLine("valor de b");
            //pega informação do terminal e converte string para int
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("valor de a");
            //pega informação do terminal e converte string para int
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("valor de c");
            //pega informação do terminal e converte string para int
            c = Int32.Parse(Console.ReadLine());

            double delta = b * b - 4 * a * c;
            double a1 = ((-1 * b + raiz(delta)) / (2 * a));
            double a2 = ((-1 * b - raiz(delta)) / (2 * a));

            Console.WriteLine("delta: {0}", delta);
            Console.WriteLine("a1: {0}", a1);
            Console.WriteLine("a2: {0}", a2);
        }
        private static double raiz(double delta)
        {
            double r = Math.Sqrt(delta);
            return r;
        }
    }
}
