using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herença1.classes.exercicios
{
    internal class Conta
    {
        public Conta()
        {
        }

        public int conta  { get; set; }
        public string nome { get; set; }

        public double saldo  { get; set; }

        public string agencia   { get; set;}

        public Conta(int conta, string nome, double saldo, string agencia)
        {
            this.saldo = saldo;

        }

        public  virtual void Sacar(double valor  )
        {
            if (valor <= saldo) 
            {
                saldo -= valor;
                Console.WriteLine($"seque efetuado! seu saldo é {saldo}");
            }
            else
            {
                Console.WriteLine("saldo insuficiente");
            }
            
        }
        public virtual void Depositar(double valor)
        {
            if (valor >= 0)
            {
                saldo+= valor;
                Console.WriteLine($"foi depositado {valor} na sua conta , seu saldo é {saldo}");
            }

        }

    }
  
}
