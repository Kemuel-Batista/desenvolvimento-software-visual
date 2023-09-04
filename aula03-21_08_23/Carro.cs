using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace aula03_21_08_23
{
    internal class Carro : Veiculo
    {
        private Modelo _modeloCarro;
        private int _nroPortas;

        public Modelo ModeloCarro
        {
            get => _modeloCarro;
            set => _modeloCarro = value;
        }
        public int NroPortas
        {
            get => _nroPortas;
            set => _nroPortas = value;
        }

        public Carro()
        {
            _modeloCarro = null;
            _nroPortas = 0;
        }
        public Carro(string placa, string descricao, Cor corExterna, int nroPortas, Modelo modeloCarro)
            : base(placa, descricao, corExterna)
        {
            _modeloCarro = modeloCarro;
            _nroPortas = nroPortas;
        }

        public override void Mostrar()
        {
            Console.WriteLine("Numero de portas: " + _nroPortas);
            Console.WriteLine("Modelo: " + _modeloCarro.Nome + _modeloCarro.Descri);
            base.Mostrar();
        }

    }
}
