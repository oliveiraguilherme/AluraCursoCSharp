using System;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 8 Condicionais 2");

            int idadeJoao = 18;
            //int quantidadePessoas = 2;

            //bool acompanhado = quantidadePessoas >= 2;

            bool acompanhado = false;

            if (idadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("João  pode entrar");
            }
            else
            {
                Console.WriteLine("João não pode entrar");   
            }


            Console.WriteLine("Execução finalizada, tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
