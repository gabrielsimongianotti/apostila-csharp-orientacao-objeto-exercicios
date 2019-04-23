using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade1 = 0;
            int idade2 = 0;
            int idade3 = 0;
            Console.WriteLine("fala uma idade ai");
            //pega informação do terminal e converte string para int
            idade1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("fala outro idade ai");
            //pega informação do terminal e converte string para int
            idade2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("fala mais uma idade ai");
            //pega informação do terminal e converte string para int
            idade3 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("media : {0}",(idade1 + idade2+ idade3)/3);
        }
    }
}
