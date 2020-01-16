using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_da_prova1_2
{
    abstract class Funcionario
    {
        private string nome;
        private int idade;
        private double salario;

        public Funcionario(string _nome, int _idade, double _salario)
        {
            this.Nome = _nome;
            this.Idade = _idade;
            this.Salario = _salario;
        }

        public string Nome {get; set;}
        public int Idade { get; set; }
        public double Salario { get; set; }


        public virtual double bonificacao()
        {
            return salario;
        }
    }
}
