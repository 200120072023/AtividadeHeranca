using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herença1.classes.exercicios
{
    internal class ContaEmpresarial:Conta
    {
   
       public double  totalemprestimo { get; set; }

        public double anuidade { get; set; }

        public double  LimiteEmprestimo { get; set; }

        public ContaEmpresarial(double totalemprestimo, double anuidade, double limiteEmprestimo, int conta , string nome , double Saldo , string agencia )
       
            :base(conta , nome, Saldo , agencia) 
        {
            this.totalemprestimo = totalemprestimo;
            this.anuidade = anuidade;
            LimiteEmprestimo = limiteEmprestimo;
        }

        public void Eprestimo(double valor )
        {
            if (valor <= LimiteEmprestimo) 
            {
                Saldo += valor;
                totalemprestimo += valor;
                Console.WriteLine($" Emprestimo de R$ {valor} realizado com suesso  ");

            }
            else
            {
                Console.WriteLine("lista de emprestimo anativa");
            }
                

        }
        public override void Sacar(double valor )
        {

            if (valor <= 5000.00)
            {
                base.Sacar(valor);
            }
            else
            {
                if (valor > 5000.00)
                {
                    Saldo -= (valor + 5);
                    Console.WriteLine(valor);
                }
                else
                {
                    Console.WriteLine("saldo insuficiente");
                }
            }



        }


    }
}
