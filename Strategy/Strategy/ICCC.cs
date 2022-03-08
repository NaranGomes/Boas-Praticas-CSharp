using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ICCC : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            double val = orcamento.Valor;
            if(val <= 999.0)
            {
                return val * 0.05;
            }else if(val <= 3000)
            {
                return val * 0.07;
            }
            return (val * 0.08) + 30;
        }
    }
}
