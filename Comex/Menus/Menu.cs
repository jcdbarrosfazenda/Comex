using Comex.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comex.Menus;

internal class Menu
{
    public virtual void  Executar(Dictionary<string, Cliente> clientes, Dictionary<string, List<string>> carrinho, Dictionary<string, Produto> produtos)
    {
        Console.Clear();
    }
}
