using Comex.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comex.Menus;

internal class MenuCadastrarCliente : Menu
{
    public override void Executar(Dictionary<string, Cliente> clientes, Dictionary<string, List<string>> carrinho, Dictionary<string, Produto> produtos)
    {
        base.Executar(clientes, carrinho, produtos);
        Console.WriteLine("Opção Selecionada:\n1. Cadastrar Cliente");
        Console.Write("\nDigite o nome do usuario:");
        string usuario = Console.ReadLine();
        Console.Write("\nDigite o CPF do usuario:");
        string cpf = Console.ReadLine();
        Cliente cliente = new Cliente(usuario, cpf);
        clientes.Add(usuario, cliente);
        carrinho.Add(usuario, []);

        Console.WriteLine($"Usuario {usuario} ({cpf}) cadastrado com sucesso!");
        Thread.Sleep(1000);
        Console.Clear();
    }
}
