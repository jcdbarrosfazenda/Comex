using System;
using System.Collections.Generic;
using System.Text;

namespace Comex.Modelos
{
    internal class Eletronico : Produto
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float PrecoUnitario { get; set; }
        public int quantidade { get; set; }
        public int Voltagem { get; set; }
        public int Potencia { get; set; }

        public Eletronico(string nome, float preco, int voltagem, int potencia) : base(nome, preco)
        {
            this.Nome = nome;
            this.PrecoUnitario = preco;
            this.Voltagem = voltagem;
            this.Potencia = potencia;
        }
    }
}
