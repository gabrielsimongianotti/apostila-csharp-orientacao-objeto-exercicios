using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo = 5.0;
            double valorSaque = 10.0;
            if (saldo >= valorSaque)
            {
                saldo -= valorSaque;
                Console.WriteLine("Saque realizado com sucesso");
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente");
            }
      
        }
    }
}
