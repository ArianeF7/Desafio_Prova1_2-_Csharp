using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_da_prova1_2
{
    class Gerente : Funcionario
    {
        public Gerente(string _nome, int _idade, double _salario) : base(_nome, _idade, _salario)
        {
        }
    

         public override double bonificacao()
         {
            Console.WriteLine("O(a) Gerente " + Nome + " teve a bonificação de 10000 e recebeu: " + (Salario + 10000));
            return Salario + 10000;
         }

    }
    
}