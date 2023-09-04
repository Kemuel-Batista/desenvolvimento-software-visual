using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01_07_08_23
{
    internal class Pizza : ItemPedido
    {
        private string _categoria;
        private string _sabor;
        private int _tamanho;
        private List<Complemento> _complementos;
        public static List<Pizza> pizzas = new();

        public string Categoria { get => _categoria; set => _categoria = value; }
        public string Sabor { get => _sabor; set => _sabor = value; }
        public int Tamanho { get => _tamanho; set => _tamanho = value; }

        public List<Complemento> Complementos
        {
            get { return _complementos; }
            set { _complementos = value; }
        }

        public Pizza() {
            _categoria = "";
            _sabor = "";
            _tamanho = 0;
            _complementos = new();
        }

        public Pizza(string sabor)
        {
            Pizza pizza = Pizza.pizzas.Find(x => x.Sabor == sabor);
            if (pizza == null)
            {
                _categoria = string.Empty;
                _sabor = string.Empty;
                _tamanho = 0;
                _complementos = new();
            }
            else
            {
                _categoria = pizza.Categoria;
                _sabor = pizza.Sabor;
                _tamanho = pizza.Tamanho;
                _complementos = pizza.Complementos;
            }
        }

        public Pizza(string categoria, string sabor, int tamanho, List<Complemento> complementos)
        {
            _categoria = categoria;
            _sabor = sabor;
            _tamanho = tamanho;
            _complementos = complementos;
        }
    }
}
