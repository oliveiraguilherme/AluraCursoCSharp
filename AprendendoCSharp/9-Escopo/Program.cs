using System;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 9 Escopo");

            int idadeJoao = 18;
            //int quantidadePessoas = 2;

            //bool acompanhado = quantidadePessoas >= 2;

            bool acompanhado = true;
            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "João está acompanhado";
            }
            else
            {
                mensagemAdicional = "João NÃO está acompanhado";
            }

            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("João  pode entrar");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("João não pode entrar");
                Console.WriteLine(mensagemAdicional);
            }


            Console.WriteLine("Execução finalizada, tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
