using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01_07_08_23
{
    internal class Acompanhamento : ItemPedido
    {
        private string _tipo;
        private string _descricao;
        private int _tamanho;

        public string Tipo { get => _tipo; set => _tipo = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public int Tamanho { get => _tamanho; set => _tamanho = value; }

        public Acompanhamento() { 
            _tipo = string.Empty;
            _descricao = string.Empty;
            _tamanho = 0;
        }
    }
}
