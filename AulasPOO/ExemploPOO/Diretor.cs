using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO
{
    public class Diretor : Professor
    {
        public override void Apresentar() // classe "professor" selada não permite utlizar o método copiado

        {
            Console.WriteLine();
            Console.WriteLine($"Diretorrrrr");
            Console.WriteLine();
        }
    }
}
