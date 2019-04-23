using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor = "";

            Console.WriteLine("valor de b");
            //pega informação do terminal e converte string para int
            valor = Console.ReadLine();
            double saldo =  Int32.Parse((valor));

            if (saldo < 0.0)
            {
                Console.WriteLine("Você está no negativo!");
            }
            else if (saldo < 1000000.0)
            {
                Console.WriteLine("Você é um bom cliente");
                Console.WriteLine("taxa {0}",manutencao(saldo));
            }
            else
            {
                Console.WriteLine("Você é milionário!");
                Console.WriteLine("taxa {0}",manutencao(saldo));
            }
            
        }
        private static double manutencao(double saldo)
        {
            double taxa = 0;
            if (saldo < 1000)
            {
                taxa = 0.01;
            }
            else if (saldo <= 5000)
            {
                taxa = 0.05;
            }
            else
            {
                taxa = 0.1;
            }
            return saldo * taxa;
        }
    }
}
