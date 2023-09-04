using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula03_21_08_23
{
    internal class Moto : Veiculo
    {
        private bool _bau;

        public bool Bau
        {
            get => _bau;
            set => _bau = value;

        }
    }
}
