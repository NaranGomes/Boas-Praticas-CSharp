using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ISS : IImposto
    {
        public ISS(IImposto outroImposto) : base(outroImposto){}
        public ISS() { }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculoDoOutroImposto(orcamento) ;
        }       
    }
}
