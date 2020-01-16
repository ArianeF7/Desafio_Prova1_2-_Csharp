using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_da_prova1_2
{
    class Supervisor : Funcionario
    {
        public Supervisor(string _nome, int _idade, double _salario) : base(_nome, _idade, _salario)
        {
        }

        public override double bonificacao()
        {
            Console.WriteLine("O(a) Supervisor(a) " + Nome + " teve a bonificação de 5000 e recebeu: " + (Salario + 5000));
            return Salario + 5000;
        }
    }
}
