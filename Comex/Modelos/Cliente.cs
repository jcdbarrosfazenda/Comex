using System.ComponentModel.DataAnnotations;

namespace Comex.Modelos;

public class Cliente : IIdentificar
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

    public void Identificar()
    {
        Console.WriteLine($"Cliente: {Nome}, CPF: {CPF}");
    }   
}
