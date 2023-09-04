using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula03_21_08_23
{
    internal class Veiculo
    {
        public enum Cor { Amarelo, Azul, Branca, Preta }
        protected string _placa;
        protected string _descricao;
        protected Cor _corExterna;

        public string Placa
        {
            get => _placa;
            set => _placa = value;
        }

        public string Descricao
        {
            get => _descricao;
            set => _descricao = value;
        }

        public Cor CorExterna
        {
            get => _corExterna;
            set => _corExterna = value;
        }


        public Veiculo()
        {
            _placa = string.Empty;
            _descricao = string.Empty;
            _corExterna = Cor.Amarelo;
        }

        public Veiculo(string placa, string descricao, Cor corExterna)
        {
            _placa = placa;
            _descricao = descricao;
            _corExterna = corExterna;

        }

        public virtual void Mostrar()
        {
            Console.WriteLine("Placa: " + _placa);
            Console.WriteLine("Descrição: " + _descricao);
            Console.WriteLine("Cor externa: " + _corExterna);
        }
    }
}
