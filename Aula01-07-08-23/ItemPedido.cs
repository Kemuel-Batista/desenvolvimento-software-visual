using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01_07_08_23
{
    internal class ItemPedido
    {
        private int _id;
        private int _quantidade;
 

        public int Id { get => _id; set => _id = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }

        public ItemPedido()
        {
            _id = 0;
            _quantidade = 0;
        }
    }
}
