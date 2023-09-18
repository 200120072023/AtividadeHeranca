using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herença1.classes_de_exercicios
{
    internal class GAto:Mamifero
    {
        public string corolhos { get; set; }
        public override void barulho()
        {
            Console.WriteLine("miau");
        }
    }
}
