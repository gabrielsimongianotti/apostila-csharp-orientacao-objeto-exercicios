using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorDaNotaFiscal = 0;

            Console.WriteLine("qual o valor da nota fical?");
            valorDaNotaFiscal = Int32.Parse(Console.ReadLine());
            if (valorDaNotaFiscal <= 999)
            {
                Console.WriteLine("2% {0}",valorDaNotaFiscal * 0.02);
            }
            else if (valorDaNotaFiscal <= 2999 && valorDaNotaFiscal >= 1000)
            {
                Console.WriteLine("2,5% {0}",valorDaNotaFiscal * 0.025);
            }
            else if (valorDaNotaFiscal <= 6999 && valorDaNotaFiscal >= 3000)
            {
                Console.WriteLine("2,8% {0}",valorDaNotaFiscal * 0.028);
            }else if(valorDaNotaFiscal>=7000){
                Console.WriteLine("3% {0}",valorDaNotaFiscal *0.03);
            }
        }
    }
}
