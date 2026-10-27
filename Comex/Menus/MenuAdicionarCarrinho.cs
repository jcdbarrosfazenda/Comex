using Comex.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comex.Menus;

internal class MenuAdicionarCarrinho : Menu
{
    public override void Executar(Dictionary<string, Cliente> clientes, Dictionary<string, List<string>> carrinho, Dictionary<string, Produto> produtos)
    {
        Console.WriteLine("Opção Selecionada:\n5. Adicionar produto no carrinho");
        Console.Write("\nDigite o nome do usuário:");
        string usuario = Console.ReadLine();

        if (clientes.ContainsKey(usuario))
        {
            Console.Write("Qual produto quer adicionar ao carrinho?");
            string nome = Console.ReadLine();

            if (produtos.ContainsKey(nome))
            {
                carrinho[usuario].Add(nome);
                Console.Write("Produto adicionado com successo.");
            }
            else
            {
                Console.WriteLine("Produto não cadastrado no sistema.");
            }
        }
        else
        {
            Console.WriteLine("Usuário não cadastrado.");
        }

        Thread.Sleep(1000);
        Console.Clear();
    }
}
