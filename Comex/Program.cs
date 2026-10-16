using System.Diagnostics;
using System.Net.Http.Json;
using System.Collections.Generic;
using Produto = Comex.Produto;
using Cliente = Comex.Cliente;
using Endereco = Comex.Endereco;


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
    Console.WriteLine("5. Adicionar produto no carrinho");
    Console.WriteLine("6. Fechar Compra");
    Console.WriteLine("-1. Sair");

    Console.Write("\nSelecione uma opção:");
    opcao = Console.ReadLine();


    switch (opcao)
    {
        case "1":
            CadastrarCliente();
            break;
        case "2":
            ListarClientes();
            break;
        case "3":
            CadastrarProduto();
            break;
        case "4":
            AjustarPrecoDeProduto();
            break;
        case "5":
            AdicionarProdutoNoCarrinho();
            break;
        case "6":
            FecharCompra();
            break;
        default:
            Finalizar();
            break;
    }

}
;

void CadastrarCliente()
{
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
    ExibirMenuDeOpcoes();
}
;

void ListarClientes()
{
    Console.WriteLine("Opção Selecionada:\n2. Listar Clientes");
    Console.WriteLine("Clientes Cadastrados:");

    foreach (var cliente in clientes)
    {
        Console.WriteLine($"Nome: {cliente.Key}, CPF: {cliente.Value.CPF}");
    }

    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenuDeOpcoes();
}

void CadastrarProduto()
{
    Console.WriteLine("Opção Selecionada:\n3. Cadastrar Produto");
    Console.Write("\nDigite o nome do produto:");
    string nome = Console.ReadLine();
    Console.Write("\nDigite o preço do produto:");
    int preco = int.Parse(Console.ReadLine());
    Produto produto = new Produto (nome, preco);
    produtos.Add(nome, produto);

    Console.WriteLine($"Produto {nome} cadastrado com sucesso!");
    Thread.Sleep(1000);
    Console.Clear();
    ExibirMenuDeOpcoes();
}

void AjustarPrecoDeProduto()
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
    ExibirMenuDeOpcoes();
}
void AdicionarProdutoNoCarrinho()
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
    ExibirMenuDeOpcoes();
}


void FecharCompra()
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
    ExibirMenuDeOpcoes();
}

void Finalizar()
{
    Console.WriteLine("COMEX FINALIZADO!");
}

ExibirMenuDeOpcoes();