using System;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Orcamento reforma = new Orcamento(500);

            Console.WriteLine(reforma.Valor);

            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);

            reforma.Aprova();
            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);

            reforma.Finaliza();
            Console.WriteLine(reforma.Valor);

            Console.ReadKey();
        }
    }
}
