using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01_07_08_23
{
    internal class Complemento
    {
        private int _id;
        private string _descricao;
        private int _valor;

        public int Id { get => _id; set => _id = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public int Valor { get => _valor; set => _valor = value; }

        public Complemento() { 
            _id = 0;
            _descricao = "";
            _valor = 0;
        }
    }
}
