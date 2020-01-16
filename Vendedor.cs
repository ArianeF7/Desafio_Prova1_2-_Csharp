using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_da_prova1_2
{
    class Vendedor : Funcionario
    {
        public Vendedor(string _nome, int _idade, double _salario) : base(_nome, _idade, _salario)
        {
        }

        public override double bonificacao()
        {
            Console.WriteLine("O(a) Vendedor(a) " + Nome + " teve a bonificação de 3000 e recebeu: " + (Salario + 3000));
            return Salario + 3000;
        }
    }
}
