using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula03_21_08_23
{
    internal class Marca
    {
        protected string _nome;


        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }

        public Marca(string nome)
        {
            _nome = nome;
        }
    }
}
