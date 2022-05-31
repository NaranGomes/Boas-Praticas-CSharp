using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class IHIT : TemplateDeImpostoCondicional
    {
        public IHIT()
        {
        }

        public IHIT(IImposto outroImposto) : base(outroImposto)
        {
        }

        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return ExistemDoisItensComMesmoNome(orcamento);
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.13) + 100;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.01) * orcamento.Itens.Count();
        }

        public bool ExistemDoisItensComMesmoNome(Orcamento orcamento)
        {
            return orcamento.Itens.GroupBy(n => n.Nome).Count() > 0;         
            
        }
    }
}
