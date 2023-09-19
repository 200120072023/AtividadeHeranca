
using herença1.classes;
using herença1.classes.exercicios;
using herença1.classes_de_exercicios;

public class program
{
    static void Main(string[] args)
    {
        while (true)
        {
            int conta = 1;
            string agencia = "jipa";

            Console.WriteLine("digite 1- para conta normal \n 2- para conta estudnte \n 3- para conta empresarial ");
            int opção = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite o nome do titular ");
            string nome = Convert.ToString(Console.ReadLine());





            //-------------------------------------------------------------------------NORMAL------------------------------------------------------------------------------

            if (opção == 1)
            {
                Conta c = new Conta(conta, nome, 0, nome);
                conta += 1;
                while (true)
                {
                    Console.WriteLine("1- para sacar \n 2- pra depositra \n 3-sair  ");
                    int f = Convert.ToInt32(Console.ReadLine());

                    if (f == 1)
                    {
                        Console.WriteLine("digite o valor?");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        c.Sacar(valor);
                    }
                    else if (f == 2)
                    {
                        Console.WriteLine("digite o valor?");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        c.Depositar(valor);
                    }
                    else if (f == 3)
                    {
                        break;
                    }

                }
            }



            //-------------------------------------------------------------------------------------------contaEstudante--------------------------------------------------------------------------\\

            else if (opção == 2)
            {
                Console.WriteLine("digite seu cpf");
                string cpf = Convert.ToString(Console.ReadLine());

                Console.WriteLine("iforme a instituição");
                string nomeistituição = Convert.ToString(Console.ReadLine());

                contaEstudante ce = new contaEstudante("bradesco", 100, cpf, conta, nome, 0, agencia);
                conta += 1;
                while (true)
                {
                    Console.WriteLine(" digite 1: Sacar \n digite 2: Despositar  3- sair");
                    int f = Convert.ToInt32(Console.ReadLine());
                    if (f == 1)
                    {
                        Console.WriteLine("digite o valor?");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        ce.Sacar(valor);
                    }
                    else if (f == 2)
                    {
                        Console.WriteLine("digite o valor?");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        ce.Depositar(valor);
                    }
                    else if (f == 3)
                    {
                        break;
                    }







                }
            }


            //---------------------------------------------------------------------------EMPRESARIAL------------------------------------------------------------------------------------//

            else if (opção == 3)
            {
                Console.WriteLine("digite seu cpf");
                string cpf = Convert.ToString(Console.ReadLine());
                ContaEmpresarial ca = new ContaEmpresarial(10, 1000, conta, nome, 0, "bradesco");

                while (true)
                {

                    Console.WriteLine(" digite 1: Sacar \n digite 2: Despositar  \n 3- emprestimo ");
                    int f = Convert.ToInt32(Console.ReadLine());

                    conta += 1;
                    if (f == 1)
                    {
                        Console.WriteLine("digite o valor?");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        ca.Sacar(valor);
                    }
                    else if (f == 2)
                    {
                        Console.WriteLine("digite o valor?");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        ca.Depositar(valor);
                    }
                    else if (f == 3)
                    {
                        Console.WriteLine("digite o valor?");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        ca.Eprestimo(valor);



                    }
                    else if (f == 4)
                    {
                        break;
                    }



                }




            }
        }
    }
}
