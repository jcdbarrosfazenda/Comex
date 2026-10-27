using Comex.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comex.Filtros;

internal class LinqFilter
{
    public static void FiltrarProdutosNome(Dictionary<string, Produto> produtos)
    {
        Console.Clear();
        var listaprodutos = produtos.Values;
        var listaprodutosordernados = listaprodutos.OrderBy(p => p.Nome).ToList();
        Console.WriteLine("Lista de Produtos (Ordenada por Nome):");
        foreach(var produto in listaprodutosordernados)
        {
            Console.WriteLine($"Nome: {produto.Nome}");
        }
        Thread.Sleep(2000);
    }

    public static void FiltrarProdutosPreco(Dictionary<string, Produto> produtos)
    {
        Console.Clear();    
        var listaprodutos = produtos.Values;
        var listaprodutosordernados = listaprodutos.OrderBy(p => p.PrecoUnitario).ToList();
        Console.WriteLine("Lista de Produtos (Ordenada por Preço):");
        foreach (var produto in listaprodutosordernados)
        {
            Console.WriteLine($"Nome: {produto.Nome}, Preço: {produto.PrecoUnitario}");
        }
        Thread.Sleep(2000);
    }
}
