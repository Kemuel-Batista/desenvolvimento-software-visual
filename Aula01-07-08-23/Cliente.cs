using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01_07_08_23
{
    internal class Cliente
    {
        private string _cpf;
        private string _nome;
        public static List<Cliente> clientes = new();

        // Todos os metodos tem que começar com letra maiusculas
        public string Cpf { get => _cpf; set => _cpf = value; }
        public string Nome { get => _nome; set => _nome = value; }

        public Cliente() { 
            _cpf = string.Empty;
            _nome = string.Empty;
        }

        // Novo construtor apenas com o CPF
        public Cliente(string cpf)
        {
            // Vai localizar o cpf que foi recebido na lista de clientes cadastrados
            Cliente cli = Cliente.clientes.Find(x => x.Cpf == cpf);
            if (cli == null)
            {
                _cpf = string.Empty;
                _nome = string.Empty;
            }
            else
            {
                _cpf = cli.Cpf;
                _nome = cli.Nome;
            }
        }

        public Cliente(string cpf,  string nome)
        {
            _nome = nome;
            _cpf = cpf;
        }
    }
}
