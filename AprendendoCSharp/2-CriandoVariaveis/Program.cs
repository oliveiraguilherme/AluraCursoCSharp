using System;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 2, criando variaveis");

            int idade;
            idade = 26;

            Console.WriteLine(idade);

            idade = 10 + 5;

            Console.WriteLine(idade);

            idade = (10 + 5) * 2;

            Console.WriteLine(idade);

            idade = 10 + 5 * 2;

            Console.Write(idade);

            Console.WriteLine("sua idade é " + idade + "!");

            Console.WriteLine("Execução finalizada. Tecle enter para sair");
            Console.ReadLine();
        }
    }
}
