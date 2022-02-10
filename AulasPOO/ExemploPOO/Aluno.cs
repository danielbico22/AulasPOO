using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }
        public override void Apresentar()

        {
            Console.WriteLine();
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos!");
            Console.WriteLine($"Meu documento é {Documento} e minha nota é {Nota}.");
        }
    }

}

