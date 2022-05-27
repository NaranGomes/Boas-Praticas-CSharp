using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisicoesWeb
{
    internal interface Resposta
    {
        Resposta OutraResposta { get; set; }
        void Responde(Requisicao req, Conta conta);

    }
}
