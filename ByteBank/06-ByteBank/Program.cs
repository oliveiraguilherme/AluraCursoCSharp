using System;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.nome = "Guilherme";
            cliente.cpf = "434.564.879.20";
            cliente.profissao = "Desenvolvedor";

            conta.Titular = cliente;

            conta.Saldo = -10;
            Console.WriteLine(conta.Titular.nome);
            Console.WriteLine(conta.Saldo);

            Console.ReadLine();
        }
    }
}
