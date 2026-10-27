namespace Comex
{
    public class Endereco
    {
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Complemento { get; set; }
        public int Numero { get; set; }

        public Endereco(string rua, string complemento, int numero)
        {
            this.Rua = rua;
            this.Complemento = complemento;
            this.Numero = numero;
        }
    }
}
