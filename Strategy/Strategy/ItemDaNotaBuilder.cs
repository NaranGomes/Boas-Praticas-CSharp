using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ItemDaNotaBuilder
    {
        public string Descricao { get; private set; }
        public double Valor { get; private set; }

        public ItemDaNotaBuilder ComDescricao(string descricao)
        {
            this.Descricao = descricao;
            return this;
        }
        public ItemDaNotaBuilder ComValor(double valor)
        {
            this.Valor = valor;
            return this;
        }
        public ItemDaNota Constroi()
        {
            return new ItemDaNota(Descricao, Valor);
        }
    }
}
