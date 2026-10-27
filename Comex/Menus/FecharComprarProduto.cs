using Comex.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comex.Menus
{
    internal class FecharComprarProduto : Menu
    {
        public override void Executar(Dictionary<string, Cliente> clientes, Dictionary<string, List<string>> carrinho, Dictionary<string, Produto> produtos)
        {
            Console.WriteLine("Opção Selecionada:\n6. Fechar Compra");
            Console.Write("\nDigite o nome do usuário:");
            string usuario = Console.ReadLine();
            float valor = 0;

            if (clientes.ContainsKey(usuario))
            {
                Console.Write("Listando carrinho do usuario:");
                foreach (var item in carrinho[usuario])
                {
                    Console.WriteLine($"Produto {item}, Valor: R$ {produtos[item].PrecoUnitario:F2}.");
                    valor += produtos[item].PrecoUnitario;
                }
                Console.WriteLine($"Valor total da compra: R$ {valor:F2}");
                Console.Write("Informe os dados do cartao: ");
                int dadosCartao = int.Parse(Console.ReadLine());
                Console.WriteLine($"Realizando pagamento de R$ {valor:F2} no cartao {dadosCartao}.");

            }
            else
            {
                Console.WriteLine("Usuário não cadastrado.");
            }



            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
