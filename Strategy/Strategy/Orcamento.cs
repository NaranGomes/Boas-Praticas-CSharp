using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Orcamento
    {
        public EstadoDeUmOrcamento EstadoAtual { get; set; }
        private bool DescontoExtraAplicado = false;
        public double Valor { get; set; }
        public IList<Item> Itens { get; set;}

        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
            EstadoAtual = new EmAprovacao();           
        }
        public void AplicaDescontoExtra()
        {
            if (DescontoExtraAplicado == true) return;
            
            EstadoAtual.AplicaDescontoExtra(this);
            DescontoExtraAplicado = true;
        }
        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }
        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }
        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }
    }
}
