using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisicoesWeb
{
    public class Conta
    {
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta(string nome, double saldo)
        {
            Titular = nome;
            Saldo = saldo;
        }
    }    
}
