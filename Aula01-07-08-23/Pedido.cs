using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01_07_08_23
{
    internal class Pedido
    {
        private int _id;
        private List<ItemPedido> _itens;

        public int Id { get; set; }

        public List<ItemPedido> Itens
        {
            get { return _itens; }
            set { _itens = value; }
        }

        public Pedido()
        {
            _id = 0;
            _itens = new();
        }
    }
}
