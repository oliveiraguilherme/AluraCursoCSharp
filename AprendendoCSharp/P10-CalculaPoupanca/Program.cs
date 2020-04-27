using System;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Porjeto 10 - Calcula Poupança");

            double valorInvestido;
            valorInvestido = 1000;

            int contadorMes = 1;
            while(contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + valorInvestido);
                //contadorMes = contadorMes + 1;
                //contadorMes += 1;
                contadorMes++;
            }

            Console.WriteLine("Execução finalizada, tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
