﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO
{
    public class Corrente : Conta

    {
        public override void Creditar(double valor)
        {
            base.saldo = valor;
        }
    }
}
