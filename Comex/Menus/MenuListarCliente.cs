using Comex.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comex.Menus;

internal class MenuListarCliente : Menu
{
    public override void Executar(Dictionary<string, Cliente> clientes, Dictionary<string, List<string>> carrinho, Dictionary<string, Produto> produtos)
    {
        Console.WriteLine("Opção Selecionada:\n2. Listar Clientes");
        Console.WriteLine("Clientes Cadastrados:");

        foreach (var cliente in clientes)
        {
            Console.WriteLine($"Nome: {cliente.Key}, CPF: {cliente.Value.CPF}");
        }

        Thread.Sleep(2000);
        Console.Clear();
    }
}
