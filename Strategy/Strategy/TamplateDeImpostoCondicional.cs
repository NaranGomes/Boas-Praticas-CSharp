using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract class TemplateDeImpostoCondicional : IImposto
    {
        protected TemplateDeImpostoCondicional()
        {
        }

        protected TemplateDeImpostoCondicional(IImposto outroImposto) : base(outroImposto)
        {
        }

        public override double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento) + CalculoDoOutroImposto(orcamento);
            }
            return MinimaTaxacao(orcamento) + CalculoDoOutroImposto(orcamento);
        }

        public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        public abstract double MaximaTaxacao(Orcamento orcamento);
        public abstract double MinimaTaxacao(Orcamento orcamento);

    }
}
