using System;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 4");

            double salario;
            salario = 1200.70;

            int salarioEmInteiro;

            //O int é um tipo  de variável que suporte valores ate 32 bits 
            salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            //O long é uma variável de 64 bits 
            long idade;
            idade = 13000000000000;
            Console.WriteLine(idade);


            //O short é um tipo de variável de 16 bits
            short quantidadeProdutos;
            quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;

            Console.WriteLine(altura);


            Console.WriteLine("Execução finalizada, tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
