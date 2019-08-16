namespace aula02
{
    public class Clientes
    {


        public Clientes(string nome, int cod)
        {
            Nome = nome;
            Cod = cod;
        }

        public Clientes(string nome, int cod)
        {
            this.Nome = Nome;
            this.Cod = Cod;

        
        }
        public string Nome { get; set; }

        public int Cod { get; set; }

    }
}