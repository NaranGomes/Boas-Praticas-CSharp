using System;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IImposto impostoMuitoAlto = new IKCV(new ICPP());
            Orcamento orcamento = new Orcamento(100);

            double valor = impostoMuitoAlto.Calcula(orcamento);

            Console.WriteLine(valor);
            Console.ReadKey();
        }
    }
}
