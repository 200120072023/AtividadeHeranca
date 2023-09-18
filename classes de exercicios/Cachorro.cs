using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herença1.classes_de_exercicios
{
    internal class Cachorro:Mamifero
    {
        public double  peso { get; set; }
        public override void barulho()
        {
            Console.WriteLine("auau");
        }
    }
}
