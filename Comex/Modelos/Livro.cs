using System;
using System.Collections.Generic;
using System.Text;

namespace Comex.Modelos;

internal class Livro : Produto, IIdentificar
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public float PrecoUnitario { get; set; }
    public int quantidade { get; set; }
    public string Isbn { get; set; }
    public int Total_de_Paginas  { get; set; }

    public Livro(string nome, float preco, string isbn, int totalDePaginas) : base(nome, preco)
    {
        this.Nome = nome;
        this.PrecoUnitario = preco;
        this.Isbn = isbn;
        this.Total_de_Paginas = totalDePaginas;
    }

    public void Identificar()
    {
        Console.WriteLine($"Livro: {Nome}, ISBN: {Isbn}, Total de Páginas: {Total_de_Paginas}");
    }
}
