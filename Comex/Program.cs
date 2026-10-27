using System.Diagnostics;
using System.Net.Http.Json;
using System.Collections.Generic;

using Comex.Modelos;
using Comex.Menus;
using Comex.Filtros;


Dictionary<string, Cliente> clientes = new Dictionary<string, Cliente>();
Dictionary<string, Produto> produtos = new Dictionary<string, Produto>();
Dictionary <string,List<string>> carrinho = new Dictionary<string, List<string>>();

//Produto produto = new Produto("Exemplo", 10.0f, 1);
//Console.WriteLine(produto.Descricao);

void ExibirMenuDeOpcoes()
{
    string opcao;
    Console.Clear();
    Console.WriteLine("Menu de Opções:");
    Console.WriteLine("1. Cadastrar Cliente");
    Console.WriteLine("2. Listar Clientes");
    Console.WriteLine("3. Cadastrar Produto");
    Console.WriteLine("4. Alterar Produto");
    Console.WriteLine("5. Filtrar Produtos por Nome");
    Console.WriteLine("6. Filtrar Produtos por Preço");
    Console.WriteLine("7. Adicionar produto no carrinho");
    Console.WriteLine("8. Fechar Compra");
    Console.WriteLine("-1. Sair");

    Console.Write("\nSelecione uma opção:");
    opcao = Console.ReadLine();


    switch (opcao)
    {
        case "1":
            Menu menu = new MenuCadastrarCliente();
            menu.Executar(clientes, carrinho, produtos);
            ExibirMenuDeOpcoes();
            break;
        case "2":
            Menu menuListar = new MenuListarCliente();
            menuListar.Executar(clientes, carrinho, produtos);
            ExibirMenuDeOpcoes();
            break;
        case "3":
            Menu menuCadastrarProduto = new MenuCadastrarProduto();
            menuCadastrarProduto.Executar(clientes, carrinho, produtos);
            ExibirMenuDeOpcoes();
            break;
        case "4":
            Menu menuAjustarPreco = new MenuAjustarPreco();
            menuAjustarPreco.Executar(clientes, carrinho, produtos);
            ExibirMenuDeOpcoes();   
            break;
        case "5":
            LinqFilter.FiltrarProdutosNome(produtos);
            ExibirMenuDeOpcoes();
            break;
        case "6":
            LinqFilter.FiltrarProdutosPreco(produtos);
            ExibirMenuDeOpcoes();
            break;
        case "7":
            Menu menuAdicionarCarrinho = new MenuAdicionarCarrinho();
            menuAdicionarCarrinho.Executar(clientes, carrinho, produtos);
            ExibirMenuDeOpcoes();
            break;
        case "8":
            Menu menuFecharCompra = new FecharComprarProduto();
            menuFecharCompra.Executar(clientes, carrinho, produtos);
            ExibirMenuDeOpcoes();
            break;
        default:
            Finalizar();
            break;
    }

}
;


void Finalizar()
{
    Console.WriteLine("COMEX FINALIZADO!");
}

ExibirMenuDeOpcoes();