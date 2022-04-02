using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investimentos
{
    public class Conta
    {
        public double Saldo { get; set; }
        public void Deposita(double valor)
        {
            Saldo += valor;
        }
        
    }
}
