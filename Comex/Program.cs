using System.Diagnostics;
using System.Net.Http.Json;

Console.WriteLine("Hello, World!");
Dictionary<int, string> clientes = new Dictionary<int, string>();
Dictionary<string, int> produtos = new Dictionary<string, int>();


void ExibirMenuDeOpcoes()
{
    string opcao;
    Console.Clear();
    Console.WriteLine("Menu de Opções:");
    Console.WriteLine("1. Cadastrar Cliente");
    Console.WriteLine("2. Listar Clientes");
    Console.WriteLine("3. Cadastrar Produto");
    Console.WriteLine("4. Alterar Produto");

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
    int cpf = int.Parse(Console.ReadLine());
    clientes.Add(cpf, usuario);

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
        Console.WriteLine($"Nome: {cliente.Value}, CPF: {cliente.Key}");
    }

    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenuDeOpcoes();
}

void CadastrarProduto()
{
    Console.WriteLine("Opção Selecionada:\n3. Cadastrar Produto");
    Console.Write("\nDigite o nome do produto:");
    string produto = Console.ReadLine();
    Console.Write("\nDigite o preço do produto:");
    int preco = int.Parse(Console.ReadLine());
    produtos.Add(produto, preco);

    Console.WriteLine($"Produto {produto} cadastrado com sucesso!");
    Thread.Sleep(1000);
    Console.Clear();
    ExibirMenuDeOpcoes();
}

void AjustarPrecoDeProduto()
{
    Console.WriteLine("Opção Selecionada:\n4. Alterar Produto");
    Console.Write("\nDigite o nome do produto que deseja alterar:");
    string produto = Console.ReadLine();

    if (produtos.ContainsKey(produto))
    {
        Console.Write("Qual o novo preço do produto?");
        int novoPreco = int.Parse(Console.ReadLine());
        produtos[produto] = novoPreco;
        Console.WriteLine("Alteração de preço do produto cadastrada com sucesso.");
        Thread.Sleep(1000);
        Console.Clear();
        ExibirMenuDeOpcoes();
    }
    else
    {
        Console.WriteLine("Produto não cadastrado no sistema.");
        Thread.Sleep(1000);
        Console.Clear();
        ExibirMenuDeOpcoes();
    }

    Thread.Sleep(1000);
    Console.Clear();
    ExibirMenuDeOpcoes();
}
void Finalizar()
{
    Console.WriteLine("COMEX FINALIZADO!");
}

ExibirMenuDeOpcoes();