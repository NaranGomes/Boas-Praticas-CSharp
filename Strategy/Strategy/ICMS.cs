﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ICMS : IImposto
    {
        public ICMS(IImposto outroImposto) : base(outroImposto){}
        public ICMS(){}

        public override double Calcula(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.05) + 50 + CalculoDoOutroImposto(orcamento);
        }
    }
}
