using Comex.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comex.Menus
{
    internal class MenuCadastrarProduto :  Menu
    {
        public override void Executar(Dictionary<string, Cliente> clientes, Dictionary<string, List<string>> carrinho, Dictionary<string, Produto> produtos)
        {
            base.Executar(clientes, carrinho, produtos);
            Console.WriteLine("Opção Selecionada:\n3. Cadastrar Produto");
            Console.Write("\nDigite o nome do produto:");
            string nome = Console.ReadLine();
            Console.Write("\nDigite o preço do produto:");
            int preco = int.Parse(Console.ReadLine());
            Produto produto = new Produto(nome, preco);
            produtos.Add(nome, produto);

            Console.WriteLine($"Produto {nome} cadastrado com sucesso!");
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}
