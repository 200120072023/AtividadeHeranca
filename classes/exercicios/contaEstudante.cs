using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herença1.classes.exercicios
{
    internal class contaEstudante:Conta
    {
   
        public string nomeIstutuição { get; set; }

        public double ChequeEspecial { get; set; }

        public string cpf { get; set; }

        public contaEstudante(string nomeIstutuição, double chequeEspecial, string cpf , int conta , string nome , double Saldo , string agencia )
            : base(conta, nome, Saldo, agencia)
        {
            this.nomeIstutuição = nomeIstutuição;
            ChequeEspecial = chequeEspecial;
            this.cpf = cpf;
        }
        public override void Sacar(double valor ) 
        {
            ChequeEspecial = 300;
            if(valor<= Saldo)
            {
                double conta = valor - Saldo; 
                Console.WriteLine(conta);
            }
            else if (valor > Saldo)
            {
                double tudo = Saldo + ChequeEspecial;
                if ( tudo <= Saldo )
                {
                    Console.WriteLine("saque efetuado com sucesso, mas se cheque foi ispirado ");
                }
                   
               

            }
            

        }
    }
}
