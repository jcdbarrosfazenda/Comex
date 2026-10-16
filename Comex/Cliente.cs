using System.ComponentModel.DataAnnotations;

namespace Comex
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Profissao { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }

        public Cliente (string nome, string cpf)
        {
            this.Nome = nome;
            this.CPF = cpf;
        }
    }
}
