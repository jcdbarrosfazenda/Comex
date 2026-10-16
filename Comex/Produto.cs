using System;
using System.Collections.Generic;
using System.Text;

namespace Comex
{
    public class Produto
    {
        public string Nome { get; set; }
        public string Descricao { get; set;}
        public float PrecoUnitario { get; set; }
        public int quantidade { get; set; }

        public Produto(string nome, float preco) {
            this.Nome = nome;
            this.PrecoUnitario = preco;
        }
    }
}
