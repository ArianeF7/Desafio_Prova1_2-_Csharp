using System;

namespace Desafio_da_prova1_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Gerente g1 = new Gerente("Joanita", 46, 15000);
            Supervisor s1 = new Supervisor("Charles", 28, 7000);
            Vendedor v1 = new Vendedor("Clarice", 19, 2500);

            g1.bonificacao();
            s1.bonificacao();
            v1.bonificacao();
            
        }
    }
}
