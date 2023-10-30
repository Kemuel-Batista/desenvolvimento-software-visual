using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Carro
    {
        private string _placa;
        private string _descricao;

        [Key]
        public string Placa { get { return _placa; } set { _placa = value; } }

        public string Descricao { get { return _descricao; } set { _descricao = value; } }

        public Carro()
        {
            _placa = string.Empty;
            _descricao = string.Empty;
        }

        public Carro(string placa, string descricao)
        {
            _placa = placa;
            _descricao = descricao;
        }
    }
}
