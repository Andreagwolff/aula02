using System;

namespace aula02
{
    public class CartaoDeCredito
    {
        public CartaoDeCredito(int numero, DateTime dataValidade)
        {
            this.numero = numero;
            this.DataValidade = dataValidade;

        }
        public int numero { get; set; }
        public DateTime DataValidade { get; set; }
    }
}