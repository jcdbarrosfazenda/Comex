using Comex.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comex.Menus
{
    internal class MenuAjustarPreco : Menu
    {
        public override void Executar(Dictionary<string, Cliente> clientes, Dictionary<string, List<string>> carrinho, Dictionary<string, Produto> produtos)
        {
            Console.WriteLine("Opção Selecionada:\n4. Alterar Produto");
            Console.Write("\nDigite o nome do produto que deseja alterar:");
            string nome = Console.ReadLine();

            if (produtos.ContainsKey(nome))
            {
                Console.Write("Qual o novo preço do produto?");
                int novoPreco = int.Parse(Console.ReadLine());
                produtos[nome].PrecoUnitario = novoPreco;
                Console.WriteLine("Alteração de preço do produto cadastrada com sucesso.");
            }
            else
            {
                Console.WriteLine("Produto não cadastrado no sistema.");
            }

            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}
