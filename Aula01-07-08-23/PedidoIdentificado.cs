using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01_07_08_23
{
    internal class PedidoIdentificado : Pedido
    {
        private Cliente _cliente = new();

        public Cliente Cliente { get; set; }
    }
}
