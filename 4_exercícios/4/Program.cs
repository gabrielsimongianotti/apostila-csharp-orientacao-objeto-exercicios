using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 0;
            string text = "";

            Console.WriteLine("qual a sua idade");
            //pega informação do terminal e converte string para int
            idade = Int32.Parse(Console.ReadLine());

            Console.WriteLine("você é cidadão brasileiro? se sim digite s");
            text = Console.ReadLine();
            bool brasileira = (text == "s");
            if (idade > 16 && brasileira == true)
            {
                Console.WriteLine("pode votar");
            }
            else
            {
                Console.WriteLine("não pode votar");
            }
        }
    }
}
