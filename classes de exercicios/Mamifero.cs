using herença1.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herença1.classes_de_exercicios
{
    internal class Mamifero
    {
        public DateOnly Nascim { get; set; }
        public string Nome{ get; set; }
        public string raca { get; set; }
        public virtual void barulho ()
        {
            Console.WriteLine(this.raca + "fazer barulho");
        }

        }



    }

