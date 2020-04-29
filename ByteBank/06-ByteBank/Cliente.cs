using System;
using System.Collections.Generic;
using System.Text;

namespace _06_ByteBank
{
    public class Cliente
    {
        private string _cpf;

        public string Nome { get; set; }
        public string CPF
        {
            get
            {
                return _cpf;

            }
            set
            {
                //escrevo a minha logica aqui
                _cpf = value;
            }
        }
        public string Profissao { get; set; }
       
    }
}
