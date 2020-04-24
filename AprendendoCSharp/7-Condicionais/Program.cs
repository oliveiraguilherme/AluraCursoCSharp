using System;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 7 Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade, pode entrar");
            }
            else
            {
                if(quantidadePessoas >= 2)
                {
                    Console.WriteLine("João não possui mais de 18 mas está acompanhando, pode entrar");
                }
                else
                {
                    Console.WriteLine("João não possui mais de 18, não pode entrar");
                }
                
            }


            Console.WriteLine("Execução finalizada, tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
