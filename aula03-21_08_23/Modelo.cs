using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace aula03_21_08_23
{
    internal class Modelo : Marca
    {
        private string _descri;

        public Modelo(string nome, string descri) : base(nome)
        {
            _descri = descri;
        }

        public string Descri
        {
            get => _descri;
            set => _descri = value;
        }
    }
}
