using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueV1
{
    class NotificaQtd
    {
        public int Quantidade { get; set; }
        public int QtdMinimo { get; set; }

        public NotificaQtd(int qtd, int qtdmin)
        {
            this.Quantidade = qtd;
            this.QtdMinimo = qtdmin;
        }
    }

    
    
}
