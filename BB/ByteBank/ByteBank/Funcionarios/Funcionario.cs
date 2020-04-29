using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        // 0 - funcionario
        // 1 - diretor
        // 2 - designer
        // N - ...
        private int _tipo;

        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public Funcionario(int tipo)
        {
            _tipo = tipo;
        }
        public double GetBonificacao()
        {
            if (_tipo == 1)
            {
                return Salario;
            }
            return this.Salario * 0.1;
        }
    }
}
