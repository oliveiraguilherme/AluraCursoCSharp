using System;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 6 Atribuicoes de Variaveis");

            int idade = 36;

            int idadeGuilherme = idade;

            idade = 20; 

            Console.WriteLine(idade);
            Console.WriteLine(idadeGuilherme);

            Console.WriteLine("Execução finalizada, tecle enter para sair...");
            Console.ReadLine();

        }
    }
}
